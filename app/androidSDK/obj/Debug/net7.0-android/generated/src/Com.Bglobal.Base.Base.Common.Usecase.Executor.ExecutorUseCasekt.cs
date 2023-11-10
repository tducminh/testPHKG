using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common.Usecase.Executor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='ExecutorUseCasekt']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/executor/ExecutorUseCasekt", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends com.bglobal.base.base.common.usecase.RequestValue", "RESPONSE"})]
	public abstract partial class ExecutorUseCasekt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/executor/ExecutorUseCasekt", typeof (ExecutorUseCasekt));

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

		protected ExecutorUseCasekt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='ExecutorUseCasekt']/constructor[@name='ExecutorUseCasekt' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExecutorUseCasekt () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_execute_Lcom_bglobal_base_base_common_usecase_RequestValue_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_bglobal_base_base_common_usecase_RequestValue_Handler ()
		{
			if (cb_execute_Lcom_bglobal_base_base_common_usecase_RequestValue_ == null)
				cb_execute_Lcom_bglobal_base_base_common_usecase_RequestValue_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Execute_Lcom_bglobal_base_base_common_usecase_RequestValue_);
			return cb_execute_Lcom_bglobal_base_base_common_usecase_RequestValue_;
		}

		static IntPtr n_Execute_Lcom_bglobal_base_base_common_usecase_RequestValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rv)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ExecutorUseCasekt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var rv = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_rv, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (rv!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='ExecutorUseCasekt']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("execute", "(Lcom/bglobal/base/base/common/usecase/RequestValue;)Ljava/lang/Object;", "GetExecute_Lcom_bglobal_base_base_common_usecase_RequestValue_Handler")]
		protected abstract global::Java.Lang.Object? Execute (global::Java.Lang.Object rv);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='ExecutorUseCasekt']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='REQUEST'] and parameter[2][@type='com.bglobal.base.base.common.usecase.executor.TaskCallback&lt;RESPONSE&gt;']]"
		[Register ("invoke", "(Lcom/bglobal/base/base/common/usecase/RequestValue;Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;)V", "")]
		public unsafe void Invoke (global::Java.Lang.Object requestValue, global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback? @callback)
		{
			const string __id = "invoke.(Lcom/bglobal/base/base/common/usecase/RequestValue;Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;)V";
			IntPtr native_requestValue = JNIEnv.ToLocalJniHandle (requestValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_requestValue);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestValue);
				global::System.GC.KeepAlive (requestValue);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}

	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/executor/ExecutorUseCasekt", DoNotGenerateAcw=true)]
	internal partial class ExecutorUseCasektInvoker : ExecutorUseCasekt {
		public ExecutorUseCasektInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/executor/ExecutorUseCasekt", typeof (ExecutorUseCasektInvoker));

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
