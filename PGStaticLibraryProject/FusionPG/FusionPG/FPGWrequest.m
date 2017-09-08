//
//  FPGWrequest.m
//  PayGuardianTest
//
//  Created by Alberto Aguilar on 2017/08/17.
//  Copyright © 2017. All rights reserved.
//

#import "FPGWrequest.h"

@implementation FPGWRequest


-(void) initWithTenderType:(NSString *) tt
				  transactionType:(NSString *_Nullable) xt
					invoiceNumber:(NSString *_Nullable) invno
						  clerkId:(NSString *_Nullable ) ck
						regiserId:(NSString *_Nullable) regId
						   amount:(NSString *_Nullable) amt
						tipAmount:(NSString *_Nullable) tipamt
				   cashBackAmount:(NSString *_Nullable) cashbkamt
		  originalReferenceNumber:(NSString *_Nullable) refno
						 username:(NSString *_Nullable) usr
						 password:(NSString *_Nullable) password
					 merchantCode:(NSString *_Nullable) merchant
			  merchantAccountCode:(NSString *_Nullable) merchacct
					   deviceType:(NSString *_Nullable) devtype
						 testMode:(NSString *_Nullable) test	{
	
    if ([super init]){
		_tendType		= tt;
		_tranType		= xt;
		_invcNo			= invno;
		_clerkID		= ck;
		_registerID		= regId;
        _amount			= amt;
        _tipAmount		= tipamt;
		_cashBackAmt	= cashbkamt;
		_refNo			= refno;
		_user			= usr;
		_pwd			= password;
		_merchCode		= merchant;
		_merchAcctCode	= merchacct;
		_deviceType		= devtype;
		_testMode		= test;
    };

}
/*
 -(void) initWithAmount:(NSDecimalNumber * ) amount
 tipAmount:(NSDecimalNumber *  ) tipAmount
 invoiceNumber:(NSString *) invoicenum
 tenderType:(NSString *) tendtype
 transactionType:(NSString * )transtype
 username:(NSString * )user
 password:(NSString * ) pass
 merchantCode:(NSString * ) mercode
 merchantAccountCode:(NSString * )meraccode
 originalReferenceNumber:(NSString * )refnumber
 connectionService:(NSObject<RBAConnectionService> *) conectservice
 connectionQueue:(RBAConnectionQueue * )conectqueue
 cashBackAmount:(NSDecimalNumber * )cashbank
 paymentAccountNumber:(NSString * )payaccount
 expirationDate:(NSString * )expdate
 shippingAddress:(BPNAddress * )shipadress
 deviceType:(NSString * ) devtype
 testMode:(BOOL) test
 withToken:(NSString * ) wtoken {
 */

@end
