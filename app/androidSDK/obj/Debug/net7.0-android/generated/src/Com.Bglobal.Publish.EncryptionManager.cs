using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Publish {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.publish']/class[@name='EncryptionManager']"
	[global::Android.Runtime.Register ("com/bglobal/publish/EncryptionManager", DoNotGenerateAcw=true)]
	public sealed partial class EncryptionManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/publish/EncryptionManager", typeof (EncryptionManager));

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

		internal EncryptionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.publish']/class[@name='EncryptionManager']/constructor[@name='EncryptionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EncryptionManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish']/class[@name='EncryptionManager']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/bglobal/publish/encryption/Encryption;", "")]
		public static unsafe global::Com.Bglobal.Publish.Encryption.IEncryption? Create ()
		{
			const string __id = "create.()Lcom/bglobal/publish/encryption/Encryption;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.Publish.Encryption.IEncryption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.publish']/class[@name='EncryptionManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "")]
		public static unsafe void Init (global::Android.App.Application? application)
		{
			const string __id = "init.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (application);
			}
		}

	}
}
