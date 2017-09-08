//
//  DoIt.h
//
//  Created by Manuel Acosta on 2017/08/17.
//  Copyright © 2017. All rights reserved.
//

#import <Foundation/Foundation.h>
#include "FPGWrequest.h"
#include "FPGWResponse.h"


@interface DoIt : NSObject
{
	NSOperationQueue *opQueue;
}

@property (weak) FPGWRequest *frsRequest;
@property (weak) FPGWResponse *frsResponse;
@property BOOL result;


- (void) ProcessCardRequest:(FPGWRequest *) rq
				ResponsePtr:(FPGWResponse *) rp;
- (void) ProcessCardRequest;




@end

