using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Domain.Repo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='DataRepo']"
	[Register ("com/bglobal/app/domain/repo/DataRepo", "", "Com.Bglobal.App.Domain.Repo.IDataRepoInvoker")]
	public partial interface IDataRepo : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='DataRepo']/method[@name='backup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetBackup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Bglobal.App.Domain.Repo.IDataRepoInvoker, androidSDK")]
		void Backup (string attachmentId, string passcode, string localUrl);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='DataRepo']/method[@name='restore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("restore", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetRestore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Bglobal.App.Domain.Repo.IDataRepoInvoker, androidSDK")]
		void Restore (string attachmentId, string passcode, string localUrl);

	}

	[global::Android.Runtime.Register ("com/bglobal/app/domain/repo/DataRepo", DoNotGenerateAcw=true)]
	internal partial class IDataRepoInvoker : global::Java.Lang.Object, IDataRepo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/domain/repo/DataRepo", typeof (IDataRepoInvoker));

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

		public static IDataRepo? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataRepo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.domain.repo.DataRepo'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataRepoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_passcode, IntPtr native_localUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IDataRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var passcode = JNIEnv.GetString (native_passcode, JniHandleOwnership.DoNotTransfer);
			var localUrl = JNIEnv.GetString (native_localUrl, JniHandleOwnership.DoNotTransfer);
			__this.Backup (attachmentId!, passcode!, localUrl!);
		}
#pragma warning restore 0169

		IntPtr id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Backup (string attachmentId, string passcode, string localUrl)
		{
			if (id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_attachmentId);
			__args [1] = new JValue (native_passcode);
			__args [2] = new JValue (native_localUrl);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_backup_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_attachmentId);
			JNIEnv.DeleteLocalRef (native_passcode);
			JNIEnv.DeleteLocalRef (native_localUrl);
		}

		static Delegate? cb_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRestore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_passcode, IntPtr native_localUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IDataRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var passcode = JNIEnv.GetString (native_passcode, JniHandleOwnership.DoNotTransfer);
			var localUrl = JNIEnv.GetString (native_localUrl, JniHandleOwnership.DoNotTransfer);
			__this.Restore (attachmentId!, passcode!, localUrl!);
		}
#pragma warning restore 0169

		IntPtr id_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Restore (string attachmentId, string passcode, string localUrl)
		{
			if (id_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "restore", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_attachmentId);
			__args [1] = new JValue (native_passcode);
			__args [2] = new JValue (native_localUrl);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restore_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_attachmentId);
			JNIEnv.DeleteLocalRef (native_passcode);
			JNIEnv.DeleteLocalRef (native_localUrl);
		}

	}
}
