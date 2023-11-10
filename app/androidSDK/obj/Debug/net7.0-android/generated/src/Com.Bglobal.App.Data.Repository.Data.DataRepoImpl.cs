using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Repository.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.repository.data']/class[@name='DataRepoImpl']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/repository/data/DataRepoImpl", DoNotGenerateAcw=true)]
	public sealed partial class DataRepoImpl : global::Com.Bglobal.App.Common.AppRepo, global::Com.Bglobal.App.Domain.Repo.IDataRepo {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.repository.data']/class[@name='DataRepoImpl.Companion']"
		[global::Android.Runtime.Register ("com/bglobal/app/data/repository/data/DataRepoImpl$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/repository/data/DataRepoImpl$Companion", typeof (Companion));

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/repository/data/DataRepoImpl", typeof (DataRepoImpl));

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

		internal DataRepoImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.repository.data']/class[@name='DataRepoImpl']/constructor[@name='DataRepoImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataRepoImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.data']/class[@name='DataRepoImpl']/method[@name='backup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("backup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Backup (string attachmentId, string passcode, string localUrl)
		{
			const string __id = "backup.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_passcode);
				__args [2] = new JniArgumentValue (native_localUrl);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_passcode);
				JNIEnv.DeleteLocalRef (native_localUrl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.repository.data']/class[@name='DataRepoImpl']/method[@name='restore' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("restore", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Restore (string attachmentId, string passcode, string localUrl)
		{
			const string __id = "restore.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_attachmentId = JNIEnv.NewString ((string?)attachmentId);
			IntPtr native_passcode = JNIEnv.NewString ((string?)passcode);
			IntPtr native_localUrl = JNIEnv.NewString ((string?)localUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_attachmentId);
				__args [1] = new JniArgumentValue (native_passcode);
				__args [2] = new JniArgumentValue (native_localUrl);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attachmentId);
				JNIEnv.DeleteLocalRef (native_passcode);
				JNIEnv.DeleteLocalRef (native_localUrl);
			}
		}

	}
}
