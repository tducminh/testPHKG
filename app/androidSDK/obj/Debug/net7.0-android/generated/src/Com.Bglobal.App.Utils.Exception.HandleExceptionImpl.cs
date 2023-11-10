using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='HandleExceptionImpl']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/exception/HandleExceptionImpl", DoNotGenerateAcw=true)]
	public sealed partial class HandleExceptionImpl : global::Java.Lang.Object, global::Com.Bglobal.App.Utils.Exception.IHandleException {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='HandleExceptionImpl']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Utils.Exception.HandleExceptionImpl Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/utils/exception/HandleExceptionImpl;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Exception.HandleExceptionImpl> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/exception/HandleExceptionImpl", typeof (HandleExceptionImpl));

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

		internal HandleExceptionImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.exception']/class[@name='HandleExceptionImpl']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getMessage", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public unsafe string? GetMessage (global::Java.Lang.Exception exception)
		{
			const string __id = "getMessage.(Ljava/lang/Exception;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (exception);
			}
		}

	}
}
