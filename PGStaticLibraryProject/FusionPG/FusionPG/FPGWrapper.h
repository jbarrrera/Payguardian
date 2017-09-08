//
//  FPGWrapper.h
//
//  Created by Alberto Aguilar on 17/08/17.
//  Copyright © 2017 Fusion Software. All rights reserved.
//

#import <Foundation/Foundation.h>

#include "FPGWrequest.h"
#include "FPGWResponse.h"



@interface FPGWrapper : NSObject

@property (weak) FPGWRequest *_request;
@property (weak) FPGWResponse *_response;


- (BOOL) ProcessRequest:(FPGWRequest *) fprequest
			   Response:(FPGWResponse *) fpresponse;
@end
