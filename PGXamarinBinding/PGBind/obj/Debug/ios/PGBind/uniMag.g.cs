//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace PGBind {
	[Register("uniMag", true)]
	public unsafe partial class uniMag : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("uniMag");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public uniMag () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected uniMag (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal uniMag (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("autoDetect:")]
		[CompilerGenerated]
		public virtual void AutoDetect (bool autoDetect)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("autoDetect:"), autoDetect);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("autoDetect:"), autoDetect);
			}
		}
		
		[Export ("cancelSwipe")]
		[CompilerGenerated]
		public virtual void CancelSwipe ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelSwipe"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelSwipe"));
			}
		}
		
		[Export ("cancelTask")]
		[CompilerGenerated]
		public virtual void CancelTask ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelTask"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelTask"));
			}
		}
		
		[Export ("closeConnection")]
		[CompilerGenerated]
		public virtual void CloseConnection ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("closeConnection"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("closeConnection"));
			}
		}
		
		[Export ("enableLogging:")]
		[CompilerGenerated]
		public static void EnableLogging (bool enable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("enableLogging:"), enable);
		}
		
		[Export ("proceedPoweringUp:")]
		[CompilerGenerated]
		public virtual UmRet ProceedPoweringUp (bool proceedPowerUp)
		{
			if (IsDirectBinding) {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_bool (this.Handle, Selector.GetHandle ("proceedPoweringUp:"), proceedPowerUp);
			} else {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("proceedPoweringUp:"), proceedPowerUp);
			}
		}
		
		[Export ("promptForConnection:")]
		[CompilerGenerated]
		public virtual void PromptForConnection (bool prompt)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("promptForConnection:"), prompt);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("promptForConnection:"), prompt);
			}
		}
		
		[Export ("sendCommandCustom:")]
		[CompilerGenerated]
		public virtual UmRet SendCommandCustom (NSData cmd)
		{
			if (cmd == null)
				throw new ArgumentNullException ("cmd");
			if (IsDirectBinding) {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendCommandCustom:"), cmd.Handle);
			} else {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendCommandCustom:"), cmd.Handle);
			}
		}
		
		[Export ("sendCommandSetPrePAN:")]
		[CompilerGenerated]
		public virtual UmRet SendCommandSetPrePAN (global::System.nint prePAN)
		{
			if (IsDirectBinding) {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_nint (this.Handle, Selector.GetHandle ("sendCommandSetPrePAN:"), prePAN);
			} else {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("sendCommandSetPrePAN:"), prePAN);
			}
		}
		
		[Export ("setAutoAdjustVolume:")]
		[CompilerGenerated]
		public virtual void SetAutoAdjustVolume (bool b)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoAdjustVolume:"), b);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoAdjustVolume:"), b);
			}
		}
		
		[Export ("setAutoConnect:")]
		[CompilerGenerated]
		public virtual void SetAutoConnect (bool autoConnect)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoConnect:"), autoConnect);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoConnect:"), autoConnect);
			}
		}
		
		[Export ("setCmdTimeoutDuration:")]
		[CompilerGenerated]
		public virtual bool SetCmdTimeoutDuration (global::System.nint seconds)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setCmdTimeoutDuration:"), seconds);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setCmdTimeoutDuration:"), seconds);
			}
		}
		
		[Export ("setDeferredActivateAudioSession:")]
		[CompilerGenerated]
		public virtual void SetDeferredActivateAudioSession (bool b)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDeferredActivateAudioSession:"), b);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDeferredActivateAudioSession:"), b);
			}
		}
		
		[Export ("setFirmwareFile:")]
		[CompilerGenerated]
		public virtual bool SetFirmwareFile (string location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			var nslocation = NSString.CreateNative (location);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFirmwareFile:"), nslocation);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFirmwareFile:"), nslocation);
			}
			NSString.ReleaseNative (nslocation);
			
			return ret;
		}
		
		[Export ("setSwipeTimeoutDuration:")]
		[CompilerGenerated]
		public virtual bool SetSwipeTimeoutDuration (global::System.nint seconds)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setSwipeTimeoutDuration:"), seconds);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setSwipeTimeoutDuration:"), seconds);
			}
		}
		
		[Export ("setWavePath:")]
		[CompilerGenerated]
		public virtual bool SetWavePath (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWavePath:"), nspath);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWavePath:"), nspath);
			}
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("startUniMag:")]
		[CompilerGenerated]
		public virtual UmRet StartUniMag (bool start)
		{
			if (IsDirectBinding) {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_bool (this.Handle, Selector.GetHandle ("startUniMag:"), start);
			} else {
				return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("startUniMag:"), start);
			}
		}
		
		[Export ("updateFirmware:")]
		[CompilerGenerated]
		public virtual UmRet UpdateFirmware (string encrytedBytes)
		{
			if (encrytedBytes == null)
				throw new ArgumentNullException ("encrytedBytes");
			var nsencrytedBytes = NSString.CreateNative (encrytedBytes);
			
			UmRet ret;
			if (IsDirectBinding) {
				ret = (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateFirmware:"), nsencrytedBytes);
			} else {
				ret = (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateFirmware:"), nsencrytedBytes);
			}
			NSString.ReleaseNative (nsencrytedBytes);
			
			return ret;
		}
		
		[Export ("updateFirmware2:withFile:")]
		[CompilerGenerated]
		public virtual UmRet UpdateFirmware2 (string @string, string path)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			if (path == null)
				throw new ArgumentNullException ("path");
			var nsstring = NSString.CreateNative (@string);
			var nspath = NSString.CreateNative (path);
			
			UmRet ret;
			if (IsDirectBinding) {
				ret = (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateFirmware2:withFile:"), nsstring, nspath);
			} else {
				ret = (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateFirmware2:withFile:"), nsstring, nspath);
			}
			NSString.ReleaseNative (nsstring);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual UmRet Authentication {
			[Export ("getAuthentication")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getAuthentication"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAuthentication"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ConnectionStatus {
			[Export ("getConnectionStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getConnectionStatus"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getConnectionStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData FlagByte {
			[Export ("getFlagByte")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getFlagByte")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getFlagByte")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsReaderAttached {
			[Export ("isReaderAttached")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReaderAttached"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isReaderAttached"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmReader ReaderType {
			[Export ("readerType", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (UmReader) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("readerType"));
				} else {
					return (UmReader) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readerType"));
				}
			}
			
			[Export ("setReaderType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setReaderType:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setReaderType:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual UmRet RequestSwipe {
			[Export ("requestSwipe")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("requestSwipe"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestSwipe"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmTask RunningTask {
			[Export ("getRunningTask")]
			get {
				if (IsDirectBinding) {
					return (UmTask) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getRunningTask"));
				} else {
					return (UmTask) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getRunningTask"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static string SDK_version {
			[Export ("SDK_version")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("SDK_version")));
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandClearBuffer {
			[Export ("sendCommandClearBuffer")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandClearBuffer"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandClearBuffer"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandDefaultGeneralSettings {
			[Export ("sendCommandDefaultGeneralSettings")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandDefaultGeneralSettings"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandDefaultGeneralSettings"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandDisableErrNotification {
			[Export ("sendCommandDisableErrNotification")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandDisableErrNotification"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandDisableErrNotification"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandDisableExpDate {
			[Export ("sendCommandDisableExpDate")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandDisableExpDate"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandDisableExpDate"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandDisableForceEncryption {
			[Export ("sendCommandDisableForceEncryption")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandDisableForceEncryption"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandDisableForceEncryption"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandEnableAES {
			[Export ("sendCommandEnableAES")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandEnableAES"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandEnableAES"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandEnableErrNotification {
			[Export ("sendCommandEnableErrNotification")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandEnableErrNotification"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandEnableErrNotification"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandEnableExpDate {
			[Export ("sendCommandEnableExpDate")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandEnableExpDate"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandEnableExpDate"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandEnableForceEncryption {
			[Export ("sendCommandEnableForceEncryption")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandEnableForceEncryption"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandEnableForceEncryption"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandEnableTDES {
			[Export ("sendCommandEnableTDES")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandEnableTDES"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandEnableTDES"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandGetNextKSN {
			[Export ("sendCommandGetNextKSN")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandGetNextKSN"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandGetNextKSN"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandGetSerialNumber {
			[Export ("sendCommandGetSerialNumber")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandGetSerialNumber"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandGetSerialNumber"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandGetSettings {
			[Export ("sendCommandGetSettings")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandGetSettings"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandGetSettings"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandGetVersion {
			[Export ("sendCommandGetVersion")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandGetVersion"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandGetVersion"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual UmRet SendCommandResetBaudRate {
			[Export ("sendCommandResetBaudRate")]
			get {
				if (IsDirectBinding) {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sendCommandResetBaudRate"));
				} else {
					return (UmRet) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendCommandResetBaudRate"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float VolumeLevel {
			[Export ("getVolumeLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("getVolumeLevel"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getVolumeLevel"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData Wave {
			[Export ("getWave")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getWave")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWave")));
				}
				return ret;
			}
			
		}
		
	} /* class uniMag */
}
