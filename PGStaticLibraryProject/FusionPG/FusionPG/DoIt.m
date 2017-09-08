//
//  DoIt.m
//
//  Created by Manuel Acosta on 2017/08/04.
//  Copyright © 2017 Fusion Software. All rights reserved.
//

#import "DoIt.h"
#import "FPGWrequest.h"
#import "FPGWResponse.h"
#import <PayGuardian_SDK/PayGuardian_SDK.h>


@interface DoIt ()
@property BPNPaymentRequest *request;
@property PayGuardianTransaction *transaction;
@property RBAConnectionQueue *queue;
@property BPNPayment *pmtResponse;

- (BPNPaymentRequest *) FPGWRequestToPG:(FPGWRequest *) rq;
- (BOOL) PGResponseCnv:(BPNPayment *) pgPmt
			 ToFPGW:(FPGWResponse *) frsRp;

- (void) DumpPGResponse:(BPNPayment *)pmt;
- (void) DumpPGRequest:(BPNPaymentRequest *) rq;
@end


@implementation DoIt

@synthesize frsRequest	= _frsRequest;
@synthesize transaction	= _transaction;
@synthesize request		= _request;
@synthesize pmtResponse	= _pmtResponse;



- (void) ProcessCardRequest:(FPGWRequest *) rq
				ResponsePtr:(FPGWResponse *) rp {
	_frsRequest		= rq;
	_frsResponse	= rp;
	[self ProcessCardRequest];
}

- (void) ProcessCardRequest {
	NSLog( @"DoIt.ProcessCardRequest:ResponsePtr" );
	_result		= NO;


	BOOL	bTest	= NO;
	if( [_frsRequest.testMode isEqualToString:@"TRUE"] || [_frsRequest.testMode isEqualToString:@"YES"] )
		bTest	= YES;
	NSString *theRefNo	= ([_frsRequest.refNo length] == 0) ? nil : _frsRequest.refNo;
	_request		= [[BPNPaymentRequest alloc]
							   initInvoiceNumber:_frsRequest.invcNo
							   pnRefNum:theRefNo
							   amount:[NSDecimalNumber decimalNumberWithString:_frsRequest.amount]
							   tipAmount:[NSDecimalNumber decimalNumberWithString:_frsRequest.tipAmount]
							   cashBackAmount:[NSDecimalNumber decimalNumberWithString:_frsRequest.cashBackAmt]
							   tenderType:TENDER_TYPE_CREDIT
							   transactionType:TRANSACTION_TYPE_SALE
							   username:_frsRequest.user
							   password:_frsRequest.pwd
							   merchantCode:_frsRequest.merchCode
							   merchantAccountCode:_frsRequest.merchAcctCode
							   paymentAccountNumber:nil
							   token:nil
							   expirationDate:nil
							   terminalType:TERMINAL_TYPE_INGENICO_BLUETOOTH
							   industryType:TRANSACTION_INDUSTRY_TYPE_RETAIL
							   disableEmv:NO
							   testMode:bTest];
	
	//tipAmount:[NSDecimalNumber decimalNumberWithString:_frsRequest.tipAmount]
	//cashBackAmount:[NSDecimalNumber decimalNumberWithString:_frsRequest.cashBackAmt]
	
	[self DumpPGRequest:_request];

	
	if( _request == nil ) {
		NSLog( @"  => Failed to convert FPGWRequest to PG Request." );
		return;
	}
	
	NSTimeInterval	nVal	= 10;
	int				nMin	= 7;
	int				nSecCnt	= 0;
	int				nSecLim	= (nMin * 60) / (int)nVal;
	
	__weak DoIt	*weakSelf	= self;
	
	NSLog( @"DoIt strong self = %p", self );
	NSLog( @"DoIt weak   self = %p", weakSelf );
	
	_transaction = [[PayGuardianTransaction alloc] initWithPaymentRequest:_request];
	
	opQueue	= [NSOperationQueue new];
	NSBlockOperation	*blockOp	= [NSBlockOperation blockOperationWithBlock:^{
		
		NSLog( @"DoIt weak   self = %p", weakSelf );
		
		[weakSelf.transaction runOnCompletion: ^(BPNPayment *payment, NSError *error) {
			//process response
			NSLog( @"DoIt.runOnCompletion()" );
			if( error != nil )
				NSLog( @"[CompletionERROR] %@", error );
			_pmtResponse = payment;
			
			NSLog( @"DoIt weak   self = %p", weakSelf );
			[weakSelf DumpPGResponse:payment];
			
			BOOL	bOk	= [weakSelf PGResponseCnv:payment ToFPGW:_frsResponse];
			
			if( bOk ) {
				weakSelf.result	= YES;
			}
			else {
				NSLog( @"  => Results Conversion Error!" );
				weakSelf.result	= NO;
				return;
			}
			NSLog( @"  runOnCompletion DONE -- %d.", weakSelf.result );
		} onStateChanged: ^(PayGuardianTransactionState state) {
			//process state change
			NSString    *ststr;
			switch (state) {
				case PayGuardianTransactionStateNotStarted:
					ststr   = @"Not Started";
					break;
				case PayGuardianTransactionStateWaitingForCard:
					ststr   = @"Waiting for Card";
					break;
				case PayGuardianTransactionStateReadingCard:
					ststr   = @"Reading Card";
					break;
				case PayGuardianTransactionStateChipCardWithUnreadChipSwiped:
					ststr   = @"Chip Card with Unread Chip Swiped";
					break;
				case PayGuardianTransactionStateCardReadWithBrokenChip:
					ststr   = @"Card Read with Broken Chip";
					break;
				case PayGuardianTransactionStateCardReadWithError:
					ststr   = @"Card Read with Error";
					break;
				case PayGuardianTransactionStateWaitingForGateway:
					ststr   = @"Waiting for Gateway";
					break;
				case PayGuardianTransactionStateRespondingToCard:
					ststr   = @"Responding to Card";
					break;
				case PayGuardianTransactionStateVoiding:
					ststr   = @"Voiding";
					break;
				case PayGuardianTransactionStateFinished:
					ststr   = @"Finished";
					break;
				default:
					ststr   = @"UNKNOWN STATE VALUE";
					break;
			}
			
			NSLog( @"Status: %@", ststr );
		}];
		
	}];
	[opQueue addOperation:blockOp];
	
	NSLog( @" => ProcLoop Ctrl(2): %ld(limVal); %d mins at %ld sec intervals", (long)nSecLim, nMin, (long)nVal );
	BOOL	bTmOut	= NO;
	while( (nSecCnt < nSecLim) && (_result == NO) ) {
		[[NSRunLoop currentRunLoop] runUntilDate:[NSDate dateWithTimeIntervalSinceNow:nVal]];
		if( _result == YES ) {
			NSLog( @"  Break timeout loop -- PG callback set TRUE result." );
			break;
		}
	//	if( 5 > nSecCnt )
			NSLog( @"  -- in Wait Loop  (%d of %d)...", nSecCnt, nSecLim );
		++nSecCnt;
		if( nSecCnt >= nSecLim ) {
			NSLog( @" ==> TIMED OUT !" );
			bTmOut	= YES;
			break;
		}
	}
	NSLog( @" => DoIt Task loop done." );
	
	if( bTmOut == YES ) {
		if( _result == NO ) {
			NSLog( @" ==> TIMED OUT verified !" );
		}
	}
	
	
	
	
	NSLog( @"Exit - DoIt.ProcessCardRequest:ResponsePtr" );
	
}

- (BPNPaymentRequest *) FPGWRequestToPG:(FPGWRequest *) rq {
	
	NSLog( @"DoIt.FPGWRequestCnv:ToPG" );
	BOOL	bTest	= NO;
	if( [rq.testMode isEqualToString:@"TRUE"] || [rq.testMode isEqualToString:@"YES"] )
		bTest	= YES;
	NSString *theRefNo	= ([rq.refNo length] == 0) ? nil : rq.refNo;
	BPNPaymentRequest *pgRq = [[BPNPaymentRequest alloc]
				initInvoiceNumber:rq.invcNo
				pnRefNum:theRefNo
				amount:[NSDecimalNumber decimalNumberWithString:rq.amount]
				tipAmount:[NSDecimalNumber decimalNumberWithString:rq.tipAmount]
				cashBackAmount:nil
				tenderType:TENDER_TYPE_CREDIT
				transactionType:TRANSACTION_TYPE_SALE
				username:rq.user
				password:rq.pwd
				merchantCode:rq.merchCode
				merchantAccountCode:rq.merchAcctCode
				paymentAccountNumber:nil
				token:nil
				expirationDate:nil
				terminalType:TERMINAL_TYPE_INGENICO_BLUETOOTH
				industryType:TRANSACTION_INDUSTRY_TYPE_RETAIL
				disableEmv:NO
				testMode:bTest];
	
	//cashBackAmount:[NSDecimalNumber decimalNumberWithString:rq.cashBackAmt]
	NSLog( @"  - requestAmt : %@", [NSString stringWithFormat:@"%@", pgRq.amount] );
	NSLog( @"  - tipAmt     : %@", [NSString stringWithFormat:@"%@", pgRq.tipAmount] );
	NSLog( @"  - cashBackAmt: %@", [NSString stringWithFormat:@"%@", pgRq.cashBackAmount] );
	return pgRq;
}

- (BOOL) PGResponseCnv:(BPNPayment *) pgPmt
			 ToFPGW:(FPGWResponse *) frsRp {
	NSLog( @"DoIt.PGResponseCnv:ToFPGW" );
	BridgeCommResponse	*bcr	= pgPmt.bridgeCommResponse;
	BPNReceipt			*rct	= pgPmt.receipt;
	frsRp.resultCode		= bcr.responseCode;
	frsRp.resultText		= bcr.responseDescription;
	frsRp.authCode			= bcr.authorizationCode;
	frsRp.maskedCardNo		= bcr.maskedPAN;
	frsRp.cardType			= bcr.cardType;
	frsRp.expireDate		= bcr.expirationDate;
	frsRp.isCommercialCard	= bcr.isCommercialCard;
	frsRp.refNo				= bcr.networkReferenceNumber;
	frsRp.approvedAmount	= [NSString stringWithFormat:@"%@", bcr.authorizedAmount];
	frsRp.requestedAmt		= [NSString stringWithFormat:@"%@", bcr.originalAmount];
	frsRp.remainingAmt		= [NSString stringWithFormat:@"%@", bcr.remainingAmount];
	frsRp.submittedAmt		= _frsRequest.amount;
	frsRp.tipAmt			= _frsRequest.tipAmount;
	frsRp.remainingBalance	= @"";	// apparently, no way to get this in PG iOS
	frsRp.appLabel			= rct.appLabel;
	frsRp.chipCardAID		= rct.chipCardAID;
	frsRp.entryMethod		= rct.entryMethod;
	frsRp.invoiceNo			= _frsRequest.invcNo;
	if( frsRp.invoiceNo == nil || [frsRp.invoiceNo isEqual: @""] )
		frsRp.invoiceNo	= rct.invoice;
	frsRp.gatewayMessage	= bcr.gatewayMessage;
	frsRp.internalMessage	= bcr.internalMessage;
	frsRp.message			= @"";
	frsRp.responseTypeDesc	= bcr.responseTypeDescription;
	return YES;
}

//- (NSString *) FrsTenderTypeCnv:(NSString *) frsType {}

//- (NSString *) FrsTranTypeCnv:(NSString *) frsType {}



- (void) DumpPGResponse:(BPNPayment *)pmt {
	NSLog( @"DoIt.DumpPGResponse" );
	NSLog( @"  Response Code: %ld: %@", (long)pmt.bridgeCommResponse.responseCode,
		  pmt.bridgeCommResponse.responseDescription );
	NSLog( @"  Reference Num: %@", pmt.bridgeCommResponse.networkReferenceNumber );
	NSLog( @"  Authorization: %@", pmt.bridgeCommResponse.authorizationCode );
	NSLog( @"  Card         : %@  %@", pmt.bridgeCommResponse.cardType,
		  pmt.bridgeCommResponse.maskedPAN );
	NSLog( @"  AuthorizedAmt: %@", pmt.bridgeCommResponse.authorizedAmount );
	NSLog( @"  XactStatusInf: %@", pmt.bridgeCommResponse.transactionStatusInformation );
	NSLog( @"  AID/Entry/Lbl: %@ / %@ / %@", pmt.receipt.chipCardAID,
		  pmt.receipt.entryMethod, pmt.receipt.appLabel );
	NSLog( @"  Card(receipt): %@  %@", pmt.receipt.cardType,
		  pmt.receipt.maskedCardNumber );
	NSLog( @"  Card Holder  : %@", pmt.receipt.cardHolderName );
	NSLog( @"  Total Amt    : %@  [Invc#:%@]", pmt.receipt.totalAmount,
		  pmt.receipt.invoice );
	NSLog( @"  ReqSig/PINgot: %s / %s", pmt.receipt.requiresSignature ? "Yes" : "No",
		  pmt.receipt.pinEntered ? "Yes" : "No" );
	
}

- (void) DumpPGRequest:(BPNPaymentRequest *) rq {
	
	NSLog( @"DoIt.DumpPGRequest" );
	NSLog( @"  TenderType   : %@", rq.tenderType );
	NSLog( @"  TransType    : %@", rq.transactionType );
	NSLog( @"  TerminalType : %@", rq.terminalType );
	NSLog( @"  IndustryType : %@", rq.industryType );
	NSLog( @"  Disable EMV  : %s", rq.disableEmv ? "Yes" : "No" );
	NSLog( @"  TestMode     : %s", rq.testMode ? "Yes" : "No" );
	NSLog( @"  PnRefNum     : %@", rq.pnRefNum );
	NSLog( @"  Amount       : %@", rq.amount );
	NSLog( @"  Tip Amount   : %@", rq.tipAmount );
	NSLog( @"  CashBackAmt  : %@", rq.cashBackAmount );
	NSLog( @"  TransactionID: %@", rq.transactionID );
	NSLog( @"  ExpireDate   : %@", rq.expirationDate );
	NSLog( @"  PmtAcctNumber: %@", rq.paymentAccountNumber );
	NSLog( @"  UserName     : %@", rq.username );
	NSLog( @"  Password     : %@", rq.password );
	NSLog( @"  Merchant Code: %@", rq.merchantCode );
	NSLog( @"  MerchAcctCode: %@", rq.merchantAccountCode );
	NSLog( @"  token        : %@", rq.token );
	NSLog( @"  ShippingAddrs: %@", rq.shippingAddress );

}



@end
