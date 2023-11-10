using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common.Usecase.Executor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskPool']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/executor/TaskPool", DoNotGenerateAcw=true)]
	public sealed partial class TaskPool : global::Java.Util.Concurrent.ThreadPoolExecutor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/executor/TaskPool", typeof (TaskPool));

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

		internal TaskPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskPool']/constructor[@name='TaskPool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaskPool () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskPool']/constructor[@name='TaskPool' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIJI)V", "")]
		public unsafe TaskPool (int mediaCorePoolSize, int mediaMaxPoolSize, long mediaKeepAliveTime, int mediaCapacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIJI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (mediaCorePoolSize);
				__args [1] = new JniArgumentValue (mediaMaxPoolSize);
				__args [2] = new JniArgumentValue (mediaKeepAliveTime);
				__args [3] = new JniArgumentValue (mediaCapacity);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
