using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Local.Prefs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.local.prefs']/class[@name='AppPreferences']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/local/prefs/AppPreferences", DoNotGenerateAcw=true)]
	public sealed partial class AppPreferences : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.data.source.local.prefs']/class[@name='AppPreferences']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Data.Source.Local.Prefs.AppPreferences Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/data/source/local/prefs/AppPreferences;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Local.Prefs.AppPreferences> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/local/prefs/AppPreferences", typeof (AppPreferences));

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

		internal AppPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Bglobal.App.Domain.Model.Auth.AccountInfo? AccountInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.local.prefs']/class[@name='AppPreferences']/method[@name='getAccountInfo' and count(parameter)=0]"
			[Register ("getAccountInfo", "()Lcom/bglobal/app/domain/model/auth/AccountInfo;", "")]
			get {
				const string __id = "getAccountInfo.()Lcom/bglobal/app/domain/model/auth/AccountInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Model.Auth.AccountInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.local.prefs']/class[@name='AppPreferences']/method[@name='setAccountInfo' and count(parameter)=1 and parameter[1][@type='com.bglobal.app.domain.model.auth.AccountInfo']]"
			[Register ("setAccountInfo", "(Lcom/bglobal/app/domain/model/auth/AccountInfo;)V", "")]
			set {
				const string __id = "setAccountInfo.(Lcom/bglobal/app/domain/model/auth/AccountInfo;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.local.prefs']/class[@name='AppPreferences']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
