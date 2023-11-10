using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.common']/class[@name='AppUseCase']"
	[global::Android.Runtime.Register ("com/bglobal/app/common/AppUseCase", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends com.bglobal.base.base.common.usecase.RequestValue", "RESPONSE"})]
	public abstract partial class AppUseCase : global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ExecutorUseCasekt {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/common/AppUseCase", typeof (AppUseCase));

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

		protected AppUseCase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.common']/class[@name='AppUseCase']/constructor[@name='AppUseCase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppUseCase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}

	[global::Android.Runtime.Register ("com/bglobal/app/common/AppUseCase", DoNotGenerateAcw=true)]
	internal partial class AppUseCaseInvoker : AppUseCase {
		public AppUseCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/common/AppUseCase", typeof (AppUseCaseInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='ExecutorUseCasekt']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("execute", "(Lcom/bglobal/base/base/common/usecase/RequestValue;)Ljava/lang/Object;", "GetExecute_Lcom_bglobal_base_base_common_usecase_RequestValue_Handler")]
		protected override unsafe global::Java.Lang.Object? Execute (global::Java.Lang.Object rv)
		{
			const string __id = "execute.(Lcom/bglobal/base/base/common/usecase/RequestValue;)Ljava/lang/Object;";
			IntPtr native_rv = JNIEnv.ToLocalJniHandle (rv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rv);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rv);
				global::System.GC.KeepAlive (rv);
			}
		}

	}
}
