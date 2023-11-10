using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='SSLSocketClient']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/network/SSLSocketClient", DoNotGenerateAcw=true)]
	public sealed partial class SSLSocketClient : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='SSLSocketClient']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Data.Source.Remote.Network.SSLSocketClient Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/data/source/remote/network/SSLSocketClient;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Data.Source.Remote.Network.SSLSocketClient> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/network/SSLSocketClient", typeof (SSLSocketClient));

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

		internal SSLSocketClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='SSLSocketClient']/method[@name='getHostnameVerifier' and count(parameter)=0]"
			[Register ("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "")]
			get {
				const string __id = "getHostnameVerifier.()Ljavax/net/ssl/HostnameVerifier;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='SSLSocketClient']/method[@name='getSSLSocketFactory' and count(parameter)=0]"
			[Register ("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "")]
			get {
				const string __id = "getSSLSocketFactory.()Ljavax/net/ssl/SSLSocketFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='SSLSocketClient']/method[@name='getTrustManager' and count(parameter)=0]"
		[Register ("getTrustManager", "()[Ljavax/net/ssl/TrustManager;", "")]
		public unsafe global::Javax.Net.Ssl.ITrustManager[] GetTrustManager ()
		{
			const string __id = "getTrustManager.()[Ljavax/net/ssl/TrustManager;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (global::Javax.Net.Ssl.ITrustManager[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Javax.Net.Ssl.ITrustManager))!;
			} finally {
			}
		}

	}
}
