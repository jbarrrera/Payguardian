//
//  FPGWResponse.m
//
//  Created by Alberto Aguilar on 2017/08/17.
//  Copyright © 2017. All rights reserved.
//

#import "FPGWResponse.h"

@implementation FPGWResponse

//-(void) initWithResponseCode:(int) nResponseCode
-(void) fromPGResponseCode:(int) nResponseCode
				ResponseText:(NSString *_Nullable) responseText
		   AuthorizationCode:(NSString *_Nullable) AuthCode
				   MaskedPAN:(NSString *_Nullable) MaskedPAN
					CardType:(NSString *_Nullable) CardType
			  ExpirationDate:(NSString *_Nullable) ExpireDate
			IsCommercialCard:(NSString *_Nullable) IsCommCard
				ReferenceNum:(NSString *_Nullable) RefNum
			AuthorizedAmount:(NSDecimalNumber *_Nullable) AuthorizedAmt
			 RequestedAmount:(NSDecimalNumber *_Nullable) RequestedAmt
			 RemainingAmount:(NSDecimalNumber *_Nullable) RemainAmt
			 SubmittedAmount:(NSString *_Nullable) SubmittedAmt
				   TipAmount:(NSString *_Nullable) TipAmt
			  RemaingBalance:(NSString *_Nullable) RemainBal
					AppLabel:(NSString *_Nullable) AppLbl
				 ChipCardAID:(NSString *_Nullable) AID
				 EntryMethod:(NSString *_Nullable) EntryMeth
				  InvoiceNum:(NSString *_Nullable) InvoiceNum
			  GatewayMessage:(NSString *_Nullable) GatewayMsg
			 InternalMessage:(NSString *_Nullable) InternalMsg
					 Message:(NSString *_Nullable) msg
			ResponseTypeDesc:(NSString *_Nullable) RespTypeDesc {
	
	_resultCode			= nResponseCode;
	_resultText			= responseText;
	_authCode			= AuthCode;
	_maskedCardNo		= MaskedPAN;
	_cardType			= CardType;
	_expireDate			= ExpireDate;
	_isCommercialCard	= IsCommCard;
	_refNo				= RefNum;
	_approvedAmount		= [NSString stringWithFormat:@"%@", AuthorizedAmt];
	_requestedAmt		= [NSString stringWithFormat:@"%@", RequestedAmt];
	_remainingAmt		= [NSString stringWithFormat:@"%@", RemainAmt];
	_submittedAmt		= SubmittedAmt;
	_tipAmt				= TipAmt;
	_remainingBalance	= RemainBal;
	_appLabel			= AppLbl;
	_chipCardAID		= AID;
	_entryMethod		= EntryMeth;
	_invoiceNo			= InvoiceNum;
	_gatewayMessage		= GatewayMsg;
	_internalMessage	= InternalMsg;
	_message			= msg;
	_responseTypeDesc	= RespTypeDesc;
}

@end
