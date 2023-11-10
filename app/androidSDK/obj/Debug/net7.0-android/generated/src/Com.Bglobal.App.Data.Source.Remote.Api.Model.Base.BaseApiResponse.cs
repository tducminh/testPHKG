using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Api.Model.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/api/model/base/BaseApiResponse", DoNotGenerateAcw=true)]
	public partial class BaseApiResponse : global::Java.Lang.Object, global::Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.IApiResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/api/model/base/BaseApiResponse", typeof (BaseApiResponse));

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

		protected BaseApiResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/constructor[@name='BaseApiResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseApiResponse () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe global::Java.Lang.Integer? Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getCode.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setCode", "(Ljava/lang/Integer;)V", "")]
			set {
				const string __id = "setCode.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_isSuccessful;
#pragma warning disable 0169
		static Delegate GetIsSuccessfulHandler ()
		{
			if (cb_isSuccessful == null)
				cb_isSuccessful = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccessful);
			return cb_isSuccessful;
		}

		static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.BaseApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				const string __id = "isSuccessful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string? Msg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/method[@name='getMsg' and count(parameter)=0]"
			[Register ("getMsg", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiResponse']/method[@name='setMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
