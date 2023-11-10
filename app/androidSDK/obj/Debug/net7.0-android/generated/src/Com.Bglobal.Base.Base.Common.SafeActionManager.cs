using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SafeActionManager']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/SafeActionManager", DoNotGenerateAcw=true)]
	public sealed partial class SafeActionManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/SafeActionManager", typeof (SafeActionManager));

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

		internal SafeActionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SafeActionManager']/constructor[@name='SafeActionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SafeActionManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SafeActionManager']/method[@name='doWaitingAction' and count(parameter)=0]"
		[Register ("doWaitingAction", "()V", "")]
		public unsafe void DoWaitingAction ()
		{
			const string __id = "doWaitingAction.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SafeActionManager']/method[@name='resetWaitingActionList' and count(parameter)=0]"
		[Register ("resetWaitingActionList", "()V", "")]
		public unsafe void ResetWaitingActionList ()
		{
			const string __id = "resetWaitingActionList.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SafeActionManager']/method[@name='setSafeActionState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSafeActionState", "(Z)V", "")]
		public unsafe void SetSafeActionState (bool isSafeAction)
		{
			const string __id = "setSafeActionState.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isSafeAction);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
