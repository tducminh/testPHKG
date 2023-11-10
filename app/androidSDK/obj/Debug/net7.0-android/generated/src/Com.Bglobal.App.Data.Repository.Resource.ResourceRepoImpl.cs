using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Repository.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.repository.resource']/class[@name='ResourceRepoImpl']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/repository/resource/ResourceRepoImpl", DoNotGenerateAcw=true)]
	public sealed partial class ResourceRepoImpl : global::Com.Bglobal.App.Common.AppRepo, global::Com.Bglobal.App.Domain.Repo.IResourceRepo {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.repository.resource']/class[@name='ResourceRepoImpl.Companion']"
		[global::Android.Runtime.Register ("com/bglobal/app/data/repository/resource/ResourceRepoImpl$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/repository/resource/ResourceRepoImpl$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/repository/resource/ResourceRepoImpl", typeof (ResourceRepoImpl));

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

		internal ResourceRepoImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.repository.resource']/class[@name='ResourceRepoImpl']/constructor[@name='ResourceRepoImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceRepoImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.resource']/class[@name='ResourceRepoImpl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)V", "")]
		public unsafe void Get (string attachmentId)
		{
			const string __id = "get.(Ljava/lang/String;)V";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attachmentId);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.resource']/class[@name='ResourceRepoImpl']/method[@name='upload' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("upload", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe void Upload (string attachmentId, global::System.Collections.Generic.IList<string> userIdList, string localUrl)
		{
			const string __id = "upload.(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_userIdList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (userIdList);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_userIdList);
				__args [2] = new JniArgumentValue (native_localUrl);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_userIdList);
				JNIEnv.DeleteLocalRef (native_localUrl);
				global::System.GC.KeepAlive (userIdList);
			}
		}

	}
}
