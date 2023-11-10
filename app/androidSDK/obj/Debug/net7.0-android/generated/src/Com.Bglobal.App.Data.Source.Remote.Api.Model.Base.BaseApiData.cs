using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Api.Model.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiData']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/api/model/base/BaseApiData", DoNotGenerateAcw=true)]
	public partial class BaseApiData : global::Java.Lang.Object, global::Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.IApiResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/api/model/base/BaseApiData", typeof (BaseApiData));

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

		protected BaseApiData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiData']/constructor[@name='BaseApiData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseApiData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.BaseApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/class[@name='BaseApiData']/method[@name='isSuccessful' and count(parameter)=0]"
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

	}
}
