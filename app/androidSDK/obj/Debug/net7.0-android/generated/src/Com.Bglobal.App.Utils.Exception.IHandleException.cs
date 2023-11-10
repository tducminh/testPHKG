using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Exception {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.utils.exception']/interface[@name='IHandleException']"
	[Register ("com/bglobal/app/utils/exception/IHandleException", "", "Com.Bglobal.App.Utils.Exception.IHandleExceptionInvoker")]
	public partial interface IHandleException : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/interface[@name='IHandleException']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getMessage", "(Ljava/lang/Exception;)Ljava/lang/String;", "GetGetMessage_Ljava_lang_Exception_Handler:Com.Bglobal.App.Utils.Exception.IHandleExceptionInvoker, androidSDK")]
		string? GetMessage (global::Java.Lang.Exception exception);

	}

	[global::Android.Runtime.Register ("com/bglobal/app/utils/exception/IHandleException", DoNotGenerateAcw=true)]
	internal partial class IHandleExceptionInvoker : global::Java.Lang.Object, IHandleException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/exception/IHandleException", typeof (IHandleExceptionInvoker));

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

		public static IHandleException? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHandleException> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.utils.exception.IHandleException'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHandleExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getMessage_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetGetMessage_Ljava_lang_Exception_Handler ()
		{
			if (cb_getMessage_Ljava_lang_Exception_ == null)
				cb_getMessage_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMessage_Ljava_lang_Exception_);
			return cb_getMessage_Ljava_lang_Exception_;
		}

		static IntPtr n_GetMessage_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Exception.IHandleException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessage (exception!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMessage_Ljava_lang_Exception_;
		public unsafe string? GetMessage (global::Java.Lang.Exception exception)
		{
			if (id_getMessage_Ljava_lang_Exception_ == IntPtr.Zero)
				id_getMessage_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "getMessage", "(Ljava/lang/Exception;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
