//
//  FPGWResponse.h
//
//  Created by Alberto Aguilar on 2017/08/17.
//  Copyright © 2017. All rights reserved.
//

#import <Foundation/Foundation.h>


@interface FPGWResponse : NSObject

@property int		resultCode;
@property (copy, nonatomic, nullable) NSString	*resultText;

@property (copy, nonatomic, nullable) NSString	*authCode;
@property (copy, nonatomic, nullable) NSString	*maskedCardNo;
@property (copy, nonatomic, nullable) NSString	*cardType;

@property (copy, nonatomic, nullable) NSString	*expireDate;

@property (copy, nonatomic, nullable) NSString	*isCommercialCard;
@property (copy, nonatomic, nullable) NSString	*refNo;
@property (copy, nonatomic, nullable) NSString	*approvedAmount;
@property (copy, nonatomic, nullable) NSString	*requestedAmt;
@property (copy, nonatomic, nullable) NSString	*remainingAmt;
@property (copy, nonatomic, nullable) NSString	*submittedAmt;
@property (copy, nonatomic, nullable) NSString	*tipAmt;
@property (copy, nonatomic, nullable) NSString	*remainingBalance;


@property (copy, nonatomic, nullable) NSString	*appLabel;
@property (copy, nonatomic, nullable) NSString	*chipCardAID;
@property (copy, nonatomic, nullable) NSString	*entryMethod;
@property (copy, nonatomic, nullable) NSString	*invoiceNo;

@property (copy, nonatomic, nullable) NSString	*gatewayMessage;
@property (copy, nonatomic, nullable) NSString	*internalMessage;
@property (copy, nonatomic, nullable) NSString	*message;
@property (copy, nonatomic, nullable) NSString	*responseTypeDesc;



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
			ResponseTypeDesc:(NSString *_Nullable) RespTypeDesc ;


@end
