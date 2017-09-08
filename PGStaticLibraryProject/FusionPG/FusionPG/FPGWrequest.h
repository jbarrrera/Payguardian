

#import <Foundation/Foundation.h>


@interface FPGWRequest : NSObject

@property (copy, nonatomic, nullable) NSString	*tendType;
@property (copy, nonatomic, nullable) NSString	*tranType;
@property (copy, nonatomic, nullable) NSString	*amount;
@property (copy, nonatomic, nullable) NSString	*tipAmount;
@property (copy, nonatomic, nullable) NSString	*invcNo;
@property (copy, nonatomic, nullable) NSString	*user;
@property (copy, nonatomic, nullable) NSString	*pwd;
@property (copy, nonatomic, nullable) NSString	*merchCode;
@property (copy, nonatomic, nullable) NSString	*merchAcctCode;
@property (copy, nonatomic, nullable) NSString	*refNo;
@property (copy, nonatomic, nullable) NSString	*cashBackAmt;
@property (copy, nonatomic, nullable) NSString	*deviceType;

@property (copy, nonatomic, nullable) NSString	*testMode;

@property (copy, nonatomic, nullable) NSString	*clerkID;
@property (copy, nonatomic, nullable) NSString	*registerID;

-(void) initWithTenderType:(NSString *_Nullable) tt
				  transactionType:(NSString *_Nullable) xt
					invoiceNumber:(NSString *_Nullable) invno
						  clerkId:(NSString *_Nullable) ck
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
						 testMode:(NSString *_Nullable) test ;


@end


