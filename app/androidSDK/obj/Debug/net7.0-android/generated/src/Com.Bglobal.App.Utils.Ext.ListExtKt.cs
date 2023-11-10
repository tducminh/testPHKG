using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ListExtKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/ext/ListExtKt", DoNotGenerateAcw=true)]
	public sealed partial class ListExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/ext/ListExtKt", typeof (ListExtKt));

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

		internal ListExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ListExtKt']/method[@name='addFirst' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='T']]"
		[Register ("addFirst", "(Ljava/util/List;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void AddFirst (global::System.Collections.IList obj, global::Java.Lang.Object? t)
		{
			const string __id = "addFirst.(Ljava/util/List;Ljava/lang/Object;)V";
			IntPtr native_obj = global::Android.Runtime.JavaList.ToLocalJniHandle (obj);
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (native_t);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				JNIEnv.DeleteLocalRef (native_t);
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ListExtKt']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends T&gt;']]"
		[Register ("copy", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList Copy (global::System.Collections.IList? obj)
		{
			const string __id = "copy.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_obj = global::Android.Runtime.JavaList.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ListExtKt']/method[@name='replace' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;? extends T&gt;']]"
		[Register ("replace", "(Ljava/util/List;Ljava/util/List;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void Replace (global::System.Collections.IList obj, global::System.Collections.IList list)
		{
			const string __id = "replace.(Ljava/util/List;Ljava/util/List;)V";
			IntPtr native_obj = global::Android.Runtime.JavaList.ToLocalJniHandle (obj);
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (native_list);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='ListExtKt']/method[@name='subListIgnoreFirst' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("subListIgnoreFirst", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList SubListIgnoreFirst (global::System.Collections.IList obj)
		{
			const string __id = "subListIgnoreFirst.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_obj = global::Android.Runtime.JavaList.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
