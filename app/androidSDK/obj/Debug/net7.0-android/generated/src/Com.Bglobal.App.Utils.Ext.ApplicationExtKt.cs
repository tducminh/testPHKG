using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/ext/ApplicationExtKt", DoNotGenerateAcw=true)]
	public sealed partial class ApplicationExtKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='BOOLEAN_DEFAULT']"
		[Register ("BOOLEAN_DEFAULT")]
		public const bool BooleanDefault = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='DOUBLE_DEFAULT']"
		[Register ("DOUBLE_DEFAULT")]
		public const double DoubleDefault = (double) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='FLOAT_DEFAULT']"
		[Register ("FLOAT_DEFAULT")]
		public const float FloatDefault = (float) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='INT_DEFAULT']"
		[Register ("INT_DEFAULT")]
		public const int IntDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='LONG_DEFAULT']"
		[Register ("LONG_DEFAULT")]
		public const long LongDefault = (long) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/field[@name='STRING_DEFAULT']"
		[Register ("STRING_DEFAULT")]
		public const string StringDefault = (string) "";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/ext/ApplicationExtKt", typeof (ApplicationExtKt));

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

		internal ApplicationExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/method[@name='getPrefData' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='T']]"
		[Register ("getPrefData", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object? GetPrefData (global::Java.Lang.Class obj, string key, global::Java.Lang.Object? defaultValue)
		{
			const string __id = "getPrefData.(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/method[@name='initPrefData' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("initPrefData", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
		public static unsafe void InitPrefData (global::Android.App.Application obj, string preferenceName)
		{
			const string __id = "initPrefData.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_preferenceName = JNIEnv.NewString ((string?)preferenceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_preferenceName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_preferenceName);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ApplicationExtKt']/method[@name='putPrefData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("putPrefData", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void PutPrefData (string key, global::Java.Lang.Object? value)
		{
			const string __id = "putPrefData.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
