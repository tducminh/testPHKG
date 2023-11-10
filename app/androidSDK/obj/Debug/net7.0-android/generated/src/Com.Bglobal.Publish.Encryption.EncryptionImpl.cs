using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Publish.Encryption {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']"
	[global::Android.Runtime.Register ("com/bglobal/publish/encryption/EncryptionImpl", DoNotGenerateAcw=true)]
	public partial class EncryptionImpl : global::Java.Lang.Object, global::Com.Bglobal.Publish.Encryption.IEncryption {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/publish/encryption/EncryptionImpl", typeof (EncryptionImpl));

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

		protected EncryptionImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/constructor[@name='EncryptionImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EncryptionImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBackup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_passcode, IntPtr native_localUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var passcode = JNIEnv.GetString (native_passcode, JniHandleOwnership.DoNotTransfer);
			var localUrl = JNIEnv.GetString (native_localUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Backup (attachmentId, passcode, localUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='backup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetBackup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string? Backup (string? attachmentId, string? passcode, string? localUrl)
		{
			const string __id = "backup.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_passcode);
				__args [2] = new JniArgumentValue (native_localUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_passcode);
				JNIEnv.DeleteLocalRef (native_localUrl);
			}
		}

		static Delegate? cb_getFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFile_Ljava_lang_String_Handler ()
		{
			if (cb_getFile_Ljava_lang_String_ == null)
				cb_getFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFile_Ljava_lang_String_);
			return cb_getFile_Ljava_lang_String_;
		}

		static IntPtr n_GetFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFile (attachmentId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='getFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFile", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFile_Ljava_lang_String_Handler")]
		public virtual unsafe string? GetFile (string? attachmentId)
		{
			const string __id = "getFile.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attachmentId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
			}
		}

		static Delegate? cb_login_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Ljava_lang_String_Handler ()
		{
			if (cb_login_Ljava_lang_String_ == null)
				cb_login_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Login_Ljava_lang_String_);
			return cb_login_Ljava_lang_String_;
		}

		static IntPtr n_Login_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var userId = JNIEnv.GetString (native_userId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Login (userId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Ljava/lang/String;", "GetLogin_Ljava_lang_String_Handler")]
		public virtual unsafe string? Login (string? userId)
		{
			const string __id = "login.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_userId = JNIEnv.NewString ((string?)userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		static Delegate? cb_restore_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRestore_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_restore_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_restore_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Restore_Ljava_lang_String_Ljava_lang_String_);
			return cb_restore_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Restore_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_passcode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var passcode = JNIEnv.GetString (native_passcode, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Restore (attachmentId, passcode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='restore' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("restore", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetRestore_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string? Restore (string? attachmentId, string? passcode)
		{
			const string __id = "restore.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_passcode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_passcode);
			}
		}

		static Delegate? cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePermission_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_UpdatePermission_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_updatePermission_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_UpdatePermission_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_userIdList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var userIdList = (string[]?) JNIEnv.GetArray (native_userIdList, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.UpdatePermission (attachmentId, userIdList));
			if (userIdList != null)
				JNIEnv.CopyArray (userIdList, native_userIdList);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='updatePermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("updatePermission", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "GetUpdatePermission_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe string? UpdatePermission (string? attachmentId, string[]? userIdList)
		{
			const string __id = "updatePermission.(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = JNIEnv.NewArray (userIdList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_userIdList);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				if (userIdList != null) {
					JNIEnv.CopyArray (native_userIdList, userIdList);
					JNIEnv.DeleteLocalRef (native_userIdList);
				}
				global::System.GC.KeepAlive (userIdList);
			}
		}

		static Delegate? cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_UploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_uploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_userIdList, IntPtr native_localUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.EncryptionImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var userIdList = (string[]?) JNIEnv.GetArray (native_userIdList, JniHandleOwnership.DoNotTransfer, typeof (string));
			var localUrl = JNIEnv.GetString (native_localUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadFile (attachmentId, userIdList, localUrl));
			if (userIdList != null)
				JNIEnv.CopyArray (userIdList, native_userIdList);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish.encryption']/class[@name='EncryptionImpl']/method[@name='uploadFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("uploadFile", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetUploadFile_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string? UploadFile (string? attachmentId, string[]? userIdList, string? localUrl)
		{
			const string __id = "uploadFile.(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = JNIEnv.NewArray (userIdList);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_userIdList);
				__args [2] = new JniArgumentValue (native_localUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				if (userIdList != null) {
					JNIEnv.CopyArray (native_userIdList, userIdList);
					JNIEnv.DeleteLocalRef (native_userIdList);
				}
				JNIEnv.DeleteLocalRef (native_localUrl);
				global::System.GC.KeepAlive (userIdList);
			}
		}

	}
}
