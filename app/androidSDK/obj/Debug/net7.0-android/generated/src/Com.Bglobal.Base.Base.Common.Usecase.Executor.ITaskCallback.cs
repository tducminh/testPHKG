using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common.Usecase.Executor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/interface[@name='TaskCallback']"
	[Register ("com/bglobal/base/base/common/usecase/executor/TaskCallback", "", "Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITaskCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/interface[@name='TaskCallback']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onCompleted", "(Ljava/lang/Object;)V", "GetOnCompleted_Ljava_lang_Object_Handler:Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallbackInvoker, androidSDK")]
		void OnCompleted (global::Java.Lang.Object? it);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/interface[@name='TaskCallback']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onException", "(Ljava/lang/Exception;)V", "GetOnException_Ljava_lang_Exception_Handler:Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallbackInvoker, androidSDK")]
		void OnException (global::Java.Lang.Exception ex);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/interface[@name='TaskCallback']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler:Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallbackInvoker, androidSDK")]
		void OnStart ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskCallback.DefaultImpls']"
		[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/executor/TaskCallback$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/executor/TaskCallback$DefaultImpls", typeof (DefaultImpls));

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

			internal DefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskCallback.DefaultImpls']/method[@name='onException' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.common.usecase.executor.TaskCallback&lt;T&gt;'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onException", "(Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;Ljava/lang/Exception;)V", "")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			public static unsafe void OnException (global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback _this, global::Java.Lang.Exception ex)
			{
				const string __id = "onException.(Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;Ljava/lang/Exception;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
					__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (_this);
					global::System.GC.KeepAlive (ex);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common.usecase.executor']/class[@name='TaskCallback.DefaultImpls']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.common.usecase.executor.TaskCallback&lt;T&gt;']]"
			[Register ("onStart", "(Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;)V", "")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			public static unsafe void OnStart (global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback _this)
			{
				const string __id = "onStart.(Lcom/bglobal/base/base/common/usecase/executor/TaskCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (_this);
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/bglobal/base/base/common/usecase/executor/TaskCallback", DoNotGenerateAcw=true)]
	internal partial class ITaskCallbackInvoker : global::Java.Lang.Object, ITaskCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/usecase/executor/TaskCallback", typeof (ITaskCallbackInvoker));

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

		public static ITaskCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITaskCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.base.base.common.usecase.executor.TaskCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITaskCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCompleted_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Object_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Object_ == null)
				cb_onCompleted_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCompleted_Ljava_lang_Object_);
			return cb_onCompleted_Ljava_lang_Object_;
		}

		static void n_OnCompleted_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_it)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var it = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_it, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (it);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_Object_;
		public unsafe void OnCompleted (global::Java.Lang.Object? it)
		{
			if (id_onCompleted_Ljava_lang_Object_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Object;)V");
			IntPtr native_it = JNIEnv.ToLocalJniHandle (it);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_it);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_it);
		}

		static Delegate? cb_onException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_Exception_Handler ()
		{
			if (cb_onException_Ljava_lang_Exception_ == null)
				cb_onException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnException_Ljava_lang_Exception_);
			return cb_onException_Ljava_lang_Exception_;
		}

		static void n_OnException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.OnException (ex!);
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_Exception_;
		public unsafe void OnException (global::Java.Lang.Exception ex)
		{
			if (id_onException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onException_Ljava_lang_Exception_, __args);
		}

		static Delegate? cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnStart ();
		}
#pragma warning restore 0169

		IntPtr id_onStart;
		public unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
		}

	}
}
