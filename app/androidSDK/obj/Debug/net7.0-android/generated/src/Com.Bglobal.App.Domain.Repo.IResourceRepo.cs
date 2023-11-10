using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Domain.Repo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='ResourceRepo']"
	[Register ("com/bglobal/app/domain/repo/ResourceRepo", "", "Com.Bglobal.App.Domain.Repo.IResourceRepoInvoker")]
	public partial interface IResourceRepo : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='ResourceRepo']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)V", "GetGet_Ljava_lang_String_Handler:Com.Bglobal.App.Domain.Repo.IResourceRepoInvoker, androidSDK")]
		void Get (string attachmentId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.domain.repo']/interface[@name='ResourceRepo']/method[@name='upload' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("upload", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V", "GetUpload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_Handler:Com.Bglobal.App.Domain.Repo.IResourceRepoInvoker, androidSDK")]
		void Upload (string attachmentId, global::System.Collections.Generic.IList<string> userIdList, string localUrl);

	}

	[global::Android.Runtime.Register ("com/bglobal/app/domain/repo/ResourceRepo", DoNotGenerateAcw=true)]
	internal partial class IResourceRepoInvoker : global::Java.Lang.Object, IResourceRepo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/domain/repo/ResourceRepo", typeof (IResourceRepoInvoker));

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

		public static IResourceRepo? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceRepo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.app.domain.repo.ResourceRepo'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceRepoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static void n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IResourceRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			__this.Get (attachmentId!);
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe void Get (string attachmentId)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)V");
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_attachmentId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_attachmentId);
		}

		static Delegate? cb_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ == null)
				cb_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_);
			return cb_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_Upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachmentId, IntPtr native_userIdList, IntPtr native_localUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IResourceRepo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var attachmentId = JNIEnv.GetString (native_attachmentId, JniHandleOwnership.DoNotTransfer);
			var userIdList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_userIdList, JniHandleOwnership.DoNotTransfer);
			var localUrl = JNIEnv.GetString (native_localUrl, JniHandleOwnership.DoNotTransfer);
			__this.Upload (attachmentId!, userIdList!, localUrl!);
		}
#pragma warning restore 0169

		IntPtr id_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_;
		public unsafe void Upload (string attachmentId, global::System.Collections.Generic.IList<string> userIdList, string localUrl)
		{
			if (id_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "upload", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V");
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (userIdList);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_attachmentId);
			__args [1] = new JValue (native_userIdList);
			__args [2] = new JValue (native_localUrl);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upload_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_attachmentId);
			JNIEnv.DeleteLocalRef (native_userIdList);
			JNIEnv.DeleteLocalRef (native_localUrl);
		}

	}
}
