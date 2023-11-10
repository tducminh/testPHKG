using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Data.Source.Remote.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='ResponseExtentionKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/data/source/remote/network/ResponseExtentionKt", DoNotGenerateAcw=true)]
	public sealed partial class ResponseExtentionKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/data/source/remote/network/ResponseExtentionKt", typeof (ResponseExtentionKt));

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

		internal ResponseExtentionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.data.source.remote.network']/class[@name='ResponseExtentionKt']/method[@name='invokeBglobalService' and count(parameter)=2 and parameter[1][@type='com.bglobal.base.base.repo.BaseRepo'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("invokeBglobalService", "(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/Class;)Lcom/bglobal/app/data/source/remote/network/IApiService;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.bglobal.app.data.source.remote.network.IApiService"})]
		public static unsafe global::Java.Lang.Object InvokeBglobalService (global::Com.Bglobal.Base.Base.Repo.BaseRepo obj, global::Java.Lang.Class service)
		{
			const string __id = "invokeBglobalService.(Lcom/bglobal/base/base/repo/BaseRepo;Ljava/lang/Class;)Lcom/bglobal/app/data/source/remote/network/IApiService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (service);
			}
		}

	}
}
