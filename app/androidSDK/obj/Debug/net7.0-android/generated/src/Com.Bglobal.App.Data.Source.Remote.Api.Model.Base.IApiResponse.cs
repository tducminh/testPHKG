using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Api.Model.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/interface[@name='IApiResponse']"
	[Register ("com/bglobal/app/data/source/remote/api/model/base/IApiResponse", "", "Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.IApiResponseInvoker")]
	public partial interface IApiResponse : IJavaObject, IJavaPeerable {
		bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.api.model.base']/interface[@name='IApiResponse']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler:Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.IApiResponseInvoker, androidSDK")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/api/model/base/IApiResponse", DoNotGenerateAcw=true)]
	internal partial class IApiResponseInvoker : global::Java.Lang.Object, IApiResponse {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/api/model/base/IApiResponse", typeof (IApiResponseInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IApiResponse? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.data.source.remote.api.model.base.IApiResponse'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Remote.Api.Model.Base.IApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		IntPtr id_isSuccessful;
		public unsafe bool IsSuccessful {
			get {
				if (id_isSuccessful == IntPtr.Zero)
					id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccessful);
			}
		}

	}
}
