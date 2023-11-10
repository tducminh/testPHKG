using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/logging/LogHelperKt", DoNotGenerateAcw=true)]
	public sealed partial class LogHelperKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/logging/LogHelperKt", typeof (LogHelperKt));

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

		internal LogHelperKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='logd' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.common.usecase.coroutines.FlowUseCase&lt;?, ?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("logd", "(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V", "")]
		public static unsafe void Logd (global::Com.Bglobal.Base.Base.Common.Usecase.Coroutines.FlowUseCase obj, string? msg)
		{
			const string __id = "logd.(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='logd' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.repo.BaseRepo'] and parameter[2][@type='java.lang.String']]"
		[Register ("logd", "(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V", "")]
		public static unsafe void Logd (global::Com.Bglobal.Base.Base.Repo.BaseRepo obj, string? msg)
		{
			const string __id = "logd.(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='loge' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.common.usecase.coroutines.FlowUseCase&lt;?, ?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("loge", "(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V", "")]
		public static unsafe void Loge (global::Com.Bglobal.Base.Base.Common.Usecase.Coroutines.FlowUseCase obj, string? msg)
		{
			const string __id = "loge.(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='loge' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.repo.BaseRepo'] and parameter[2][@type='java.lang.String']]"
		[Register ("loge", "(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V", "")]
		public static unsafe void Loge (global::Com.Bglobal.Base.Base.Repo.BaseRepo obj, string? msg)
		{
			const string __id = "loge.(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='logi' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.common.usecase.coroutines.FlowUseCase&lt;?, ?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("logi", "(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V", "")]
		public static unsafe void Logi (global::Com.Bglobal.Base.Base.Common.Usecase.Coroutines.FlowUseCase obj, string? msg)
		{
			const string __id = "logi.(Lcom/bglobal/base/base/common/usecase/coroutines/FlowUseCase;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.logging']/class[@name='LogHelperKt']/method[@name='logi' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.repo.BaseRepo'] and parameter[2][@type='java.lang.String']]"
		[Register ("logi", "(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V", "")]
		public static unsafe void Logi (global::Com.Bglobal.Base.Base.Repo.BaseRepo obj, string? msg)
		{
			const string __id = "logi.(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
