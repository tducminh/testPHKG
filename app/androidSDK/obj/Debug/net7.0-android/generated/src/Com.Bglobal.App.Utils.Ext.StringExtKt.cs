using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='StringExtKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/ext/StringExtKt", DoNotGenerateAcw=true)]
	public sealed partial class StringExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/ext/StringExtKt", typeof (StringExtKt));

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

		internal StringExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='StringExtKt']/method[@name='isNullOrEmptyOrBlank' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNullOrEmptyOrBlank", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNullOrEmptyOrBlank (string? obj)
		{
			const string __id = "isNullOrEmptyOrBlank.(Ljava/lang/String;)Z";
			IntPtr native_obj = JNIEnv.NewString ((string?)obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='StringExtKt']/method[@name='takeFirstChar' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("takeFirstChar", "(Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string TakeFirstChar (string obj, bool isUpperCase)
		{
			const string __id = "takeFirstChar.(Ljava/lang/String;Z)Ljava/lang/String;";
			IntPtr native_obj = JNIEnv.NewString ((string?)obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (isUpperCase);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

	}
}
