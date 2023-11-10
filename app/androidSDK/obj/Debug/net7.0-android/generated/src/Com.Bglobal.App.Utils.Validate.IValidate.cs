using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Validate {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.utils.validate']/interface[@name='IValidate']"
	[Register ("com/bglobal/app/utils/validate/IValidate", "", "Com.Bglobal.App.Utils.Validate.IValidateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IValidate : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.validate']/interface[@name='IValidate']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("validate", "(Ljava/lang/Object;)Z", "GetValidate_Ljava_lang_Object_Handler:Com.Bglobal.App.Utils.Validate.IValidateInvoker, androidSDK")]
		bool Validate (global::Java.Lang.Object? data);

	}

	[global::Android.Runtime.Register ("com/bglobal/app/utils/validate/IValidate", DoNotGenerateAcw=true)]
	internal partial class IValidateInvoker : global::Java.Lang.Object, IValidate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/validate/IValidate", typeof (IValidateInvoker));

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

		public static IValidate? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IValidate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.utils.validate.IValidate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IValidateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_validate_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetValidate_Ljava_lang_Object_Handler ()
		{
			if (cb_validate_Ljava_lang_Object_ == null)
				cb_validate_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Validate_Ljava_lang_Object_);
			return cb_validate_Ljava_lang_Object_;
		}

		static bool n_Validate_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Validate.IValidate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (data);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_validate_Ljava_lang_Object_;
		public unsafe bool Validate (global::Java.Lang.Object? data)
		{
			if (id_validate_Ljava_lang_Object_ == IntPtr.Zero)
				id_validate_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "validate", "(Ljava/lang/Object;)Z");
			IntPtr native_data = JNIEnv.ToLocalJniHandle (data);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_data);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validate_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_data);
			return __ret;
		}

	}
}
