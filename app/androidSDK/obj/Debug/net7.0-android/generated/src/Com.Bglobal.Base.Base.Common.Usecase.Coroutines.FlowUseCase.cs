using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common.Usecase.Coroutines {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.coroutines']/class[@name='FlowUseCase']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/coroutines/FlowUseCase", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends com.bglobal.base.base.common.usecase.RequestValue", "RESPONSE"})]
	public abstract partial class FlowUseCase : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/coroutines/FlowUseCase", typeof (FlowUseCase));

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

		protected FlowUseCase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.coroutines']/class[@name='FlowUseCase']/constructor[@name='FlowUseCase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlowUseCase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe string TAG {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.coroutines']/class[@name='FlowUseCase']/method[@name='getTAG' and count(parameter)=0]"
			[Register ("getTAG", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTAG.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/coroutines/FlowUseCase", DoNotGenerateAcw=true)]
	internal partial class FlowUseCaseInvoker : FlowUseCase {
		public FlowUseCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/coroutines/FlowUseCase", typeof (FlowUseCaseInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
