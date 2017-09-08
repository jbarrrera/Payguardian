using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace PGBind
{
    // @interface AppDelegate : UIResponder <UIApplicationDelegate>
    //[BaseType(typeof(UIResponder))]
    //interface AppDelegate : IUIApplicationDelegate
    //{
    //    // @property (nonatomic, strong) UIWindow * window;
    //    [Export("window", ArgumentSemantic.Strong)]
    //    UIWindow Window { get; set; }
    //}

    // @interface DoIt : NSObject
    [BaseType(typeof(NSObject))]
    interface DoIt
    {
        // @property (weak) int * frsRequest;
        [Export("frsRequest", ArgumentSemantic.Weak)]
        unsafe int FrsRequest { get; set; }

        // @property (weak) int * frsResponse;
        [Export("frsResponse", ArgumentSemantic.Weak)]
        unsafe int FrsResponse { get; set; }

        // @property BOOL result;
        [Export("result")]
        bool Result { get; set; }

        // -(void)ProcessCardRequest:(id)rq ResponsePtr:(id)rp;
        [Export("ProcessCardRequest:ResponsePtr:")]
        void ProcessCardRequest(NSObject rq, NSObject rp);

        // -(void)ProcessCardRequest;
        [Export("ProcessCardRequest")]
        void ProcessCardRequest();
    }

    // @interface FPGWResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface FPGWResponse
    {
        // @property int resultCode;
        [Export("resultCode")]
        int ResultCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable resultText;
        [NullAllowed, Export("resultText")]
        string ResultText { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable authCode;
        [NullAllowed, Export("authCode")]
        string AuthCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable maskedCardNo;
        [NullAllowed, Export("maskedCardNo")]
        string MaskedCardNo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cardType;
        [NullAllowed, Export("cardType")]
        string CardType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expireDate;
        [NullAllowed, Export("expireDate")]
        string ExpireDate { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable isCommercialCard;
        [NullAllowed, Export("isCommercialCard")]
        string IsCommercialCard { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable refNo;
        [NullAllowed, Export("refNo")]
        string RefNo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable approvedAmount;
        [NullAllowed, Export("approvedAmount")]
        string ApprovedAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable requestedAmt;
        [NullAllowed, Export("requestedAmt")]
        string RequestedAmt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable remainingAmt;
        [NullAllowed, Export("remainingAmt")]
        string RemainingAmt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable submittedAmt;
        [NullAllowed, Export("submittedAmt")]
        string SubmittedAmt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tipAmt;
        [NullAllowed, Export("tipAmt")]
        string TipAmt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable remainingBalance;
        [NullAllowed, Export("remainingBalance")]
        string RemainingBalance { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable appLabel;
        [NullAllowed, Export("appLabel")]
        string AppLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable chipCardAID;
        [NullAllowed, Export("chipCardAID")]
        string ChipCardAID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable entryMethod;
        [NullAllowed, Export("entryMethod")]
        string EntryMethod { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable invoiceNo;
        [NullAllowed, Export("invoiceNo")]
        string InvoiceNo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable gatewayMessage;
        [NullAllowed, Export("gatewayMessage")]
        string GatewayMessage { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable internalMessage;
        [NullAllowed, Export("internalMessage")]
        string InternalMessage { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable responseTypeDesc;
        [NullAllowed, Export("responseTypeDesc")]
        string ResponseTypeDesc { get; set; }

        // -(void)fromPGResponseCode:(int)nResponseCode ResponseText:(NSString * _Nullable)responseText AuthorizationCode:(NSString * _Nullable)AuthCode MaskedPAN:(NSString * _Nullable)MaskedPAN CardType:(NSString * _Nullable)CardType ExpirationDate:(NSString * _Nullable)ExpireDate IsCommercialCard:(NSString * _Nullable)IsCommCard ReferenceNum:(NSString * _Nullable)RefNum AuthorizedAmount:(NSDecimalNumber * _Nullable)AuthorizedAmt RequestedAmount:(NSDecimalNumber * _Nullable)RequestedAmt RemainingAmount:(NSDecimalNumber * _Nullable)RemainAmt SubmittedAmount:(NSString * _Nullable)SubmittedAmt TipAmount:(NSString * _Nullable)TipAmt RemaingBalance:(NSString * _Nullable)RemainBal AppLabel:(NSString * _Nullable)AppLbl ChipCardAID:(NSString * _Nullable)AID EntryMethod:(NSString * _Nullable)EntryMeth InvoiceNum:(NSString * _Nullable)InvoiceNum GatewayMessage:(NSString * _Nullable)GatewayMsg InternalMessage:(NSString * _Nullable)InternalMsg Message:(NSString * _Nullable)msg ResponseTypeDesc:(NSString * _Nullable)RespTypeDesc;
        [Export("fromPGResponseCode:ResponseText:AuthorizationCode:MaskedPAN:CardType:ExpirationDate:IsCommercialCard:ReferenceNum:AuthorizedAmount:RequestedAmount:RemainingAmount:SubmittedAmount:TipAmount:RemaingBalance:AppLabel:ChipCardAID:EntryMethod:InvoiceNum:GatewayMessage:InternalMessage:Message:ResponseTypeDesc:")]
        void FromPGResponseCode(int nResponseCode, [NullAllowed] string responseText, [NullAllowed] string AuthCode, [NullAllowed] string MaskedPAN, [NullAllowed] string CardType, [NullAllowed] string ExpireDate, [NullAllowed] string IsCommCard, [NullAllowed] string RefNum, [NullAllowed] NSDecimalNumber AuthorizedAmt, [NullAllowed] NSDecimalNumber RequestedAmt, [NullAllowed] NSDecimalNumber RemainAmt, [NullAllowed] string SubmittedAmt, [NullAllowed] string TipAmt, [NullAllowed] string RemainBal, [NullAllowed] string AppLbl, [NullAllowed] string AID, [NullAllowed] string EntryMeth, [NullAllowed] string InvoiceNum, [NullAllowed] string GatewayMsg, [NullAllowed] string InternalMsg, [NullAllowed] string msg, [NullAllowed] string RespTypeDesc);
    }

    // @interface FPGWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface FPGWrapper
    {
        // @property (weak) int * _request;
        [Export("_request", ArgumentSemantic.Weak)]
        unsafe int _request { get; set; }

        // @property (weak) FPGWResponse * _response;
        [Export("_response", ArgumentSemantic.Weak)]
        FPGWResponse _response { get; set; }

        // -(BOOL)ProcessRequest:(id)fprequest Response:(FPGWResponse *)fpresponse;
        [Export("ProcessRequest:Response:")]
        bool ProcessRequest(NSObject fprequest, FPGWResponse fpresponse);
    }

    // @interface FPGWRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface FPGWRequest
    {
        // @property (copy, nonatomic) NSString * _Nullable tendType;
        [NullAllowed, Export("tendType")]
        string TendType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tranType;
        [NullAllowed, Export("tranType")]
        string TranType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable amount;
        [NullAllowed, Export("amount")]
        string Amount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tipAmount;
        [NullAllowed, Export("tipAmount")]
        string TipAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable invcNo;
        [NullAllowed, Export("invcNo")]
        string InvcNo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable user;
        [NullAllowed, Export("user")]
        string User { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable pwd;
        [NullAllowed, Export("pwd")]
        string Pwd { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable merchCode;
        [NullAllowed, Export("merchCode")]
        string MerchCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable merchAcctCode;
        [NullAllowed, Export("merchAcctCode")]
        string MerchAcctCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable refNo;
        [NullAllowed, Export("refNo")]
        string RefNo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cashBackAmt;
        [NullAllowed, Export("cashBackAmt")]
        string CashBackAmt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable deviceType;
        [NullAllowed, Export("deviceType")]
        string DeviceType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable testMode;
        [NullAllowed, Export("testMode")]
        string TestMode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable clerkID;
        [NullAllowed, Export("clerkID")]
        string ClerkID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable registerID;
        [NullAllowed, Export("registerID")]
        string RegisterID { get; set; }

        // -(void)initWithTenderType:(NSString * _Nullable)tt transactionType:(NSString * _Nullable)xt invoiceNumber:(NSString * _Nullable)invno clerkId:(NSString * _Nullable)ck regiserId:(NSString * _Nullable)regId amount:(NSString * _Nullable)amt tipAmount:(NSString * _Nullable)tipamt cashBackAmount:(NSString * _Nullable)cashbkamt originalReferenceNumber:(NSString * _Nullable)refno username:(NSString * _Nullable)usr password:(NSString * _Nullable)password merchantCode:(NSString * _Nullable)merchant merchantAccountCode:(NSString * _Nullable)merchacct deviceType:(NSString * _Nullable)devtype testMode:(NSString * _Nullable)test;
        [Export("initWithTenderType:transactionType:invoiceNumber:clerkId:regiserId:amount:tipAmount:cashBackAmount:originalReferenceNumber:username:password:merchantCode:merchantAccountCode:deviceType:testMode:")]
        void InitWithTenderType([NullAllowed] string tt, [NullAllowed] string xt, [NullAllowed] string invno, [NullAllowed] string ck, [NullAllowed] string regId, [NullAllowed] string amt, [NullAllowed] string tipamt, [NullAllowed] string cashbkamt, [NullAllowed] string refno, [NullAllowed] string usr, [NullAllowed] string password, [NullAllowed] string merchant, [NullAllowed] string merchacct, [NullAllowed] string devtype, [NullAllowed] string test);
    }

    // @interface uniMag : NSObject
    [BaseType(typeof(NSObject))]
    interface uniMag
    {
        // +(NSString *)SDK_version;
        [Static]
        [Export("SDK_version")]

        string SDK_version { get; }

        // -(BOOL)isReaderAttached;
        [Export("isReaderAttached")]

        bool IsReaderAttached { get; }

        // -(BOOL)getConnectionStatus;
        [Export("getConnectionStatus")]

        bool ConnectionStatus { get; }

        // -(UmTask)getRunningTask;
        [Export("getRunningTask")]

        UmTask RunningTask { get; }

        // -(float)getVolumeLevel;
        [Export("getVolumeLevel")]

        float VolumeLevel { get; }

        // @property (nonatomic) UmReader readerType;
        [Export("readerType", ArgumentSemantic.Assign)]
        UmReader ReaderType { get; set; }

        // -(void)setAutoConnect:(BOOL)autoConnect;
        [Export("setAutoConnect:")]
        void SetAutoConnect(bool autoConnect);

        // -(BOOL)setSwipeTimeoutDuration:(NSInteger)seconds;
        [Export("setSwipeTimeoutDuration:")]
        bool SetSwipeTimeoutDuration(nint seconds);

        // -(void)setAutoAdjustVolume:(BOOL)b;
        [Export("setAutoAdjustVolume:")]
        void SetAutoAdjustVolume(bool b);

        // -(void)setDeferredActivateAudioSession:(BOOL)b;
        [Export("setDeferredActivateAudioSession:")]
        void SetDeferredActivateAudioSession(bool b);

        // -(void)cancelTask;
        [Export("cancelTask")]
        void CancelTask();

        // -(UmRet)startUniMag:(BOOL)start;
        [Export("startUniMag:")]
        UmRet StartUniMag(bool start);

        // -(UmRet)requestSwipe;
        [Export("requestSwipe")]

        UmRet RequestSwipe { get; }

        // -(NSData *)getFlagByte;
        [Export("getFlagByte")]

        NSData FlagByte { get; }

        // -(UmRet)sendCommandGetVersion;
        [Export("sendCommandGetVersion")]

        UmRet SendCommandGetVersion { get; }

        // -(UmRet)sendCommandGetSettings;
        [Export("sendCommandGetSettings")]

        UmRet SendCommandGetSettings { get; }

        // -(UmRet)sendCommandEnableTDES;
        [Export("sendCommandEnableTDES")]

        UmRet SendCommandEnableTDES { get; }

        // -(UmRet)sendCommandEnableAES;
        [Export("sendCommandEnableAES")]

        UmRet SendCommandEnableAES { get; }

        // -(UmRet)sendCommandDefaultGeneralSettings;
        [Export("sendCommandDefaultGeneralSettings")]

        UmRet SendCommandDefaultGeneralSettings { get; }

        // -(UmRet)sendCommandGetSerialNumber;
        [Export("sendCommandGetSerialNumber")]

        UmRet SendCommandGetSerialNumber { get; }

        // -(UmRet)sendCommandGetNextKSN;
        [Export("sendCommandGetNextKSN")]

        UmRet SendCommandGetNextKSN { get; }

        // -(UmRet)sendCommandEnableErrNotification;
        [Export("sendCommandEnableErrNotification")]

        UmRet SendCommandEnableErrNotification { get; }

        // -(UmRet)sendCommandDisableErrNotification;
        [Export("sendCommandDisableErrNotification")]

        UmRet SendCommandDisableErrNotification { get; }

        // -(UmRet)sendCommandEnableExpDate;
        [Export("sendCommandEnableExpDate")]

        UmRet SendCommandEnableExpDate { get; }

        // -(UmRet)sendCommandDisableExpDate;
        [Export("sendCommandDisableExpDate")]

        UmRet SendCommandDisableExpDate { get; }

        // -(UmRet)sendCommandEnableForceEncryption;
        [Export("sendCommandEnableForceEncryption")]

        UmRet SendCommandEnableForceEncryption { get; }

        // -(UmRet)sendCommandDisableForceEncryption;
        [Export("sendCommandDisableForceEncryption")]

        UmRet SendCommandDisableForceEncryption { get; }

        // -(UmRet)sendCommandSetPrePAN:(NSInteger)prePAN;
        [Export("sendCommandSetPrePAN:")]
        UmRet SendCommandSetPrePAN(nint prePAN);

        // -(UmRet)sendCommandClearBuffer;
        [Export("sendCommandClearBuffer")]

        UmRet SendCommandClearBuffer { get; }

        // -(UmRet)sendCommandResetBaudRate;
        [Export("sendCommandResetBaudRate")]

        UmRet SendCommandResetBaudRate { get; }


        // -(UmRet)sendCommandCustom:(NSData *)cmd;
        [Export("sendCommandCustom:")]
        UmRet SendCommandCustom(NSData cmd);

        // -(UmRet)getAuthentication;
        [Export("getAuthentication")]

        UmRet Authentication { get; }

        // -(BOOL)setFirmwareFile:(NSString *)location;
        [Export("setFirmwareFile:")]
        bool SetFirmwareFile(string location);

        // -(UmRet)updateFirmware:(NSString *)encrytedBytes;
        [Export("updateFirmware:")]
        UmRet UpdateFirmware(string encrytedBytes);

        // -(UmRet)updateFirmware2:(NSString *)string withFile:(NSString *)path;
        [Export("updateFirmware2:withFile:")]
        UmRet UpdateFirmware2(string @string, string path);

        // +(void)enableLogging:(BOOL)enable;
        [Static]
        [Export("enableLogging:")]
        void EnableLogging(bool enable);

        // -(NSData *)getWave;
        [Export("getWave")]

        NSData Wave { get; }

        // -(BOOL)setWavePath:(NSString *)path;
        [Export("setWavePath:")]
        bool SetWavePath(string path);

        // -(void)autoDetect:(BOOL)autoDetect;
        [Export("autoDetect:")]
        void AutoDetect(bool autoDetect);

        // -(void)promptForConnection:(BOOL)prompt;
        [Export("promptForConnection:")]
        void PromptForConnection(bool prompt);

        // -(UmRet)proceedPoweringUp:(BOOL)proceedPowerUp;
        [Export("proceedPoweringUp:")]
        UmRet ProceedPoweringUp(bool proceedPowerUp);

        // -(void)closeConnection;
        [Export("closeConnection")]
        void CloseConnection();

        // -(void)cancelSwipe;
        [Export("cancelSwipe")]
        void CancelSwipe();

        // -(BOOL)setCmdTimeoutDuration:(NSInteger)seconds;
        [Export("setCmdTimeoutDuration:")]
        bool SetCmdTimeoutDuration(nint seconds);
    }
}

