using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/network/RetrofitFactory", DoNotGenerateAcw=true)]
	public sealed partial class RetrofitFactory : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Data.Source.Remote.Network.RetrofitFactory Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/data/source/remote/network/RetrofitFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Remote.Network.RetrofitFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory.RetrofitBuilderInfo']"
		[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/network/RetrofitFactory$RetrofitBuilderInfo", DoNotGenerateAcw=true)]
		public sealed partial class RetrofitBuilderInfo : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/network/RetrofitFactory$RetrofitBuilderInfo", typeof (RetrofitBuilderInfo));

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

			internal RetrofitBuilderInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory.RetrofitBuilderInfo']/constructor[@name='RetrofitFactory.RetrofitBuilderInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RetrofitBuilderInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe string? AccessToken {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory.RetrofitBuilderInfo']/method[@name='getAccessToken' and count(parameter)=0]"
				[Register ("getAccessToken", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getAccessToken.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory.RetrofitBuilderInfo']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAccessToken", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setAccessToken.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString ((string?)value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory.RetrofitBuilderInfo']/method[@name='valid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valid", "(Ljava/lang/String;)Z", "")]
			public unsafe bool Valid (string? accessToken)
			{
				const string __id = "valid.(Ljava/lang/String;)Z";
				IntPtr native_accessToken = JNIEnv.NewString ((string?)accessToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_accessToken);
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_accessToken);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/network/RetrofitFactory", typeof (RetrofitFactory));

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

		internal RetrofitFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='RetrofitFactory']/method[@name='createBglobalService' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("createBglobalService", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object? CreateBglobalService (global::Java.Lang.Class service)
		{
			const string __id = "createBglobalService.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (service);
			}
		}

	}
}
