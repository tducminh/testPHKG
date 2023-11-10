using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Repository.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.repository.auth']/class[@name='AuthRepoImpl']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/repository/auth/AuthRepoImpl", DoNotGenerateAcw=true)]
	public sealed partial class AuthRepoImpl : global::Com.Bglobal.App.Common.AppRepo, global::Com.Bglobal.App.Domain.Repo.IAuthRepo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/repository/auth/AuthRepoImpl", typeof (AuthRepoImpl));

		internal static new IntPtr class_ref {
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

		internal AuthRepoImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.repository.auth']/class[@name='AuthRepoImpl']/constructor[@name='AuthRepoImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthRepoImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.auth']/class[@name='AuthRepoImpl']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Lcom/bglobal/app/domain/model/auth/LoginInfo;", "")]
		public unsafe global::Com.Bglobal.App.Domain.Model.Auth.LoginInfo Login (string userId)
		{
			const string __id = "login.(Ljava/lang/String;)Lcom/bglobal/app/domain/model/auth/LoginInfo;";
			IntPtr native_userId = JNIEnv.NewString ((string?)userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Model.Auth.LoginInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.auth']/class[@name='AuthRepoImpl']/method[@name='updatePermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("updatePermission", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe void UpdatePermission (string attachmentId, global::System.Collections.Generic.IList<string> userIdList)
		{
			const string __id = "updatePermission.(Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (userIdList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_userIdList);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_userIdList);
				global::System.GC.KeepAlive (userIdList);
			}
		}

	}
}
