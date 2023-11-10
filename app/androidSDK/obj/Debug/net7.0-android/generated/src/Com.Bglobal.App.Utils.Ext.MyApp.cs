using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='MyApp']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/ext/MyApp", DoNotGenerateAcw=true)]
	public sealed partial class MyApp : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='MyApp']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Utils.Ext.MyApp Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/utils/ext/MyApp;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Ext.MyApp> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/ext/MyApp", typeof (MyApp));

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

		internal MyApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Android.App.Application Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='MyApp']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Landroid/app/Application;", "")]
			get {
				const string __id = "getApplication.()Landroid/app/Application;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='MyApp']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
			[Register ("setApplication", "(Landroid/app/Application;)V", "")]
			set {
				const string __id = "setApplication.(Landroid/app/Application;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
