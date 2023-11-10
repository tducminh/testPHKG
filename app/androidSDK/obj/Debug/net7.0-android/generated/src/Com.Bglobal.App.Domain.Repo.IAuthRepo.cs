using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Domain.Repo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='AuthRepo']"
	[Register ("com/bglobal/app/domain/repo/AuthRepo", "", "Com.Bglobal.App.Domain.Repo.IAuthRepoInvoker")]
	public partial interface IAuthRepo : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='AuthRepo']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Lcom/bglobal/app/domain/model/auth/LoginInfo;", "GetLogin_Ljava_lang_String_Handler:Com.Bglobal.App.Domain.Repo.IAuthRepoInvoker, androidSDK")]
		global::Com.Bglobal.App.Domain.Model.Auth.LoginInfo Login (string userId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='AuthRepo']/method[@name='updatePermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("updatePermission", "(Ljava/lang/String;Ljava/util/List;)V", "GetUpdatePermission_Ljava_lang_String_Ljava_util_List_Handler:Com.Bglobal.App.Domain.Repo.IAuthRepoInvoker, androidSDK")]
		void UpdatePermission (string attachmentId, global::System.Collections.Generic.IList<string> userIdList);

	}

	[global::Android.Runtime.Register ("com/bglobal/app/domain/repo/AuthRepo", DoNotGenerateAcw=true)]
	internal partial class IAuthRepoInvoker : global::Java.Lang.Object, IAuthRepo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/domain/repo/AuthRepo", typeof (IAuthRepoInvoker));

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

		public static IAuthRepo? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthRepo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.domain.repo.AuthRepo'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthRepoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IAuthRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var userId = JNIEnv.GetString (native_userId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Login (userId!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_login_Ljava_lang_String_;
		public unsafe global::Com.Bglobal.App.Domain.Model.Auth.LoginInfo Login (string userId)
		{
			if (id_login_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Ljava/lang/String;)Lcom/bglobal/app/domain/model/auth/LoginInfo;");
			IntPtr native_userId = JNIEnv.NewString ((string?)userId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_userId);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Model.Auth.LoginInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_login_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef)!;
			JNIEnv.DeleteLocalRef (native_userId);
			return __ret;
		}

		static Delegate? cb_updatePermission_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetUpdatePermission_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_updatePermission_Ljava_lang_String_Ljava_util_List_ == null)
				cb_updatePermission_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UpdatePermission_Ljava_lang_String_Ljava_util_List_);
			return cb_updatePermission_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_UpdatePermission_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_userIdList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IAuthRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var userIdList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_userIdList, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePermission (attachmentId!, userIdList!);
		}
#pragma warning restore 0169

		IntPtr id_updatePermission_Ljava_lang_String_Ljava_util_List_;
		public unsafe void UpdatePermission (string attachmentId, global::System.Collections.Generic.IList<string> userIdList)
		{
			if (id_updatePermission_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_updatePermission_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "updatePermission", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (userIdList);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_attachmentId);
			__args [1] = new JValue (native_userIdList);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePermission_Ljava_lang_String_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_attachmentId);
			JNIEnv.DeleteLocalRef (native_userIdList);
		}

	}
}
