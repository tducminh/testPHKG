using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/exception/AppException", DoNotGenerateAcw=true)]
	public sealed partial class AppException : global::Java.Lang.Exception {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='ACCOUNT_INFO_NOT_FOUND_IN_PREFERENCES_ERROR']"
		[Register ("ACCOUNT_INFO_NOT_FOUND_IN_PREFERENCES_ERROR")]
		public const int AccountInfoNotFoundInPreferencesError = (int) -1009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='CONVERT_JSON_FROM_RESPONSE_ERROR']"
		[Register ("CONVERT_JSON_FROM_RESPONSE_ERROR")]
		public const int ConvertJsonFromResponseError = (int) -1008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='CREATE_INSTANCE_SERVICE_ERROR']"
		[Register ("CREATE_INSTANCE_SERVICE_ERROR")]
		public const int CreateInstanceServiceError = (int) -1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='DEV_DEBUG_LOCAL_ERROR']"
		[Register ("DEV_DEBUG_LOCAL_ERROR")]
		public const int DevDebugLocalError = (int) -1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='EXPIRE_SESSION_ERROR']"
		[Register ("EXPIRE_SESSION_ERROR")]
		public const int ExpireSessionError = (int) -1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='HTTP_CODE_BAD_REQUEST']"
		[Register ("HTTP_CODE_BAD_REQUEST")]
		public const int HttpCodeBadRequest = (int) 400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='HTTP_CODE_INTERNAL_SERVER']"
		[Register ("HTTP_CODE_INTERNAL_SERVER")]
		public const int HttpCodeInternalServer = (int) 500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='HTTP_CODE_NOT_FOUND']"
		[Register ("HTTP_CODE_NOT_FOUND")]
		public const int HttpCodeNotFound = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='HTTP_CODE_SUCCESS']"
		[Register ("HTTP_CODE_SUCCESS")]
		public const int HttpCodeSuccess = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) -1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='REFRESH_TOKEN_NOT_FOUND_IN_PREFERENCES_ERROR']"
		[Register ("REFRESH_TOKEN_NOT_FOUND_IN_PREFERENCES_ERROR")]
		public const int RefreshTokenNotFoundInPreferencesError = (int) -1010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='RESPONSE_BODY_ERROR']"
		[Register ("RESPONSE_BODY_ERROR")]
		public const int ResponseBodyError = (int) -1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='SERVER_ERROR_CODE_UNDEFINE']"
		[Register ("SERVER_ERROR_CODE_UNDEFINE")]
		public const int ServerErrorCodeUndefine = (int) -1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='TIME_OUT_ERROR']"
		[Register ("TIME_OUT_ERROR")]
		public const int TimeOutError = (int) -1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const int UnknownError = (int) -1001;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException.Companion']"
		[global::Android.Runtime.Register ("com/bglobal/app/utils/exception/AppException$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/exception/AppException$Companion", typeof (Companion));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException.Companion']/method[@name='newInstDevDebugLocal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("newInstDevDebugLocal", "(Ljava/lang/String;)Lcom/bglobal/app/utils/exception/AppException;", "")]
			public unsafe global::Com.Bglobal.App.Utils.Exception.AppException NewInstDevDebugLocal (string msg)
			{
				const string __id = "newInstDevDebugLocal.(Ljava/lang/String;)Lcom/bglobal/app/utils/exception/AppException;";
				IntPtr native_msg = JNIEnv.NewString ((string?)msg);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_msg);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Exception.AppException> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_msg);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/exception/AppException", typeof (AppException));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal AppException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AppException (int code) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe AppException (int code, string? message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe AppException (int code, string? message, global::Java.Lang.Throwable? throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/Throwable;Ljava/lang/Object;)V", "")]
		public unsafe AppException (int code, string? message, global::Java.Lang.Throwable? throwable, global::Java.Lang.Object? payload) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/Throwable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [3] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (payload);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/constructor[@name='AppException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AppException (string? message) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "")]
			get {
				const string __id = "getCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCode", "(I)V", "")]
			set {
				const string __id = "setCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string? Msg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='getMsg' and count(parameter)=0]"
			[Register ("getMsg", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='setMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsg", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setMsg.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::Java.Lang.Object? Payload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='getPayload' and count(parameter)=0]"
			[Register ("getPayload", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getPayload.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='AppException']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setPayload", "(Ljava/lang/Object;)V", "")]
			set {
				const string __id = "setPayload.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
