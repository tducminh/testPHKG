using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Publish.Encryption {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']"
	[Register ("com/bglobal/publish/encryption/Encryption", "", "Com.Bglobal.Publish.Encryption.IEncryptionInvoker")]
	public partial interface IEncryption : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='backup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetBackup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? Backup (string? p0, string? p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='getFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFile", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFile_Ljava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? GetFile (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Ljava/lang/String;", "GetLogin_Ljava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? Login (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='restore' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("restore", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetRestore_Ljava_lang_String_Ljava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? Restore (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='updatePermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("updatePermission", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "GetUpdatePermission_Ljava_lang_String_arrayLjava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? UpdatePermission (string? p0, string[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/interface[@name='Encryption']/method[@name='uploadFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("uploadFile", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetUploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler:Com.Bglobal.Publish.Encryption.IEncryptionInvoker, androidSDK")]
		string? UploadFile (string? p0, string[]? p1, string? p2);

	}

	[global::Android.Runtime.Register ("com/bglobal/publish/encryption/Encryption", DoNotGenerateAcw=true)]
	internal partial class IEncryptionInvoker : global::Java.Lang.Object, IEncryption {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/publish/encryption/Encryption", typeof (IEncryptionInvoker));

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

		public static IEncryption? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEncryption> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.publish.encryption.Encryption'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEncryptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBackup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Backup (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string? Backup (string? p0, string? p1, string? p2)
		{
			if (id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate? cb_getFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFile_Ljava_lang_String_Handler ()
		{
			if (cb_getFile_Ljava_lang_String_ == null)
				cb_getFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFile_Ljava_lang_String_);
			return cb_getFile_Ljava_lang_String_;
		}

		static IntPtr n_GetFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFile_Ljava_lang_String_;
		public unsafe string? GetFile (string? p0)
		{
			if (id_getFile_Ljava_lang_String_ == IntPtr.Zero)
				id_getFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFile", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_login_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Ljava_lang_String_Handler ()
		{
			if (cb_login_Ljava_lang_String_ == null)
				cb_login_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Login_Ljava_lang_String_);
			return cb_login_Ljava_lang_String_;
		}

		static IntPtr n_Login_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Login (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_login_Ljava_lang_String_;
		public unsafe string? Login (string? p0)
		{
			if (id_login_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_login_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_restore_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRestore_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_restore_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_restore_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Restore_Ljava_lang_String_Ljava_lang_String_);
			return cb_restore_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Restore_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Restore (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_restore_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string? Restore (string? p0, string? p1)
		{
			if (id_restore_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_restore_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "restore", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_restore_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePermission_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_UpdatePermission_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_UpdatePermission_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.UpdatePermission (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updatePermission_Ljava_lang_String_arrayLjava_lang_String_;
		public unsafe string? UpdatePermission (string? p0, string[]? p1)
		{
			if (id_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updatePermission", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updatePermission_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_UploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadFile (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		public unsafe string? UploadFile (string? p0, string[]? p1, string? p2)
		{
			if (id_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "uploadFile", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}
}
