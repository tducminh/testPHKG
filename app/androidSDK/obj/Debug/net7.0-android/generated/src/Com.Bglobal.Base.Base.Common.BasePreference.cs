using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/BasePreference", DoNotGenerateAcw=true)]
	public sealed partial class BasePreference : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/BasePreference", typeof (BasePreference));

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

		internal BasePreference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']/constructor[@name='BasePreference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.app.Application']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/app/Application;)V", "")]
		public unsafe BasePreference (string PREF_NAME, global::Android.App.Application application) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/app/Application;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_PREF_NAME = JNIEnv.NewString ((string?)PREF_NAME);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_PREF_NAME);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_PREF_NAME);
				global::System.GC.KeepAlive (application);
			}
		}

		public unsafe global::Android.Content.ISharedPreferences? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Landroid/content/SharedPreferences;", "")]
			get {
				const string __id = "getInstance.()Landroid/content/SharedPreferences;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object? Get (string key, global::Java.Lang.Class clz)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((clz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clz).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (clz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object? Get (string key, global::Java.Lang.Object? defaultValue, global::Java.Lang.Class clz)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_defaultValue);
				__args [2] = new JniArgumentValue ((clz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clz).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
				global::System.GC.KeepAlive (defaultValue);
				global::System.GC.KeepAlive (clz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BasePreference']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe void Put (string key, global::Java.Lang.Object? data)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_data = JNIEnv.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
