//
//  FPGWrapper.m
//  PayGuardianTest
//
//  Created by Alberto Aguilar on 2017/08/17.
//  Copyright © 2017. All rights reserved.
//

#import "FPGWrapper.h"
#import "FPGWrequest.h"
#import "FPGWResponse.h"
#import "DoIt.h"


@implementation FPGWrapper

- (BOOL) ProcessRequest:(FPGWRequest *)fprequest
			   Response:(FPGWResponse *)fpresponse {
	
	NSLog( @"FPGWrapper.ProcessRequest:Response" );
	BOOL	bRtn	= YES;
	DoIt	*doit	= [[DoIt alloc] init];
	
	if( nil != doit ) {
		[doit ProcessCardRequest:fprequest ResponsePtr:fpresponse];
		NSLog( @" => call to DoIt processing is complete." );
		bRtn	= [doit result];
	}
	else {
		NSLog( @"  => Failed to create 'DoIt' object instance" );
		bRtn	= NO;
	}
	
	NSLog( @"Exit - FPGWrapper.ProcessRequest:Response" );
	return bRtn;
}

@end
