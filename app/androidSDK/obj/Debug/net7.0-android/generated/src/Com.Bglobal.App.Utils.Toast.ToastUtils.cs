using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Toast {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.toast']/class[@name='ToastUtils']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/toast/ToastUtils", DoNotGenerateAcw=true)]
	public sealed partial class ToastUtils : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.toast']/class[@name='ToastUtils']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Utils.Toast.ToastUtils Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/utils/toast/ToastUtils;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Toast.ToastUtils> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/toast/ToastUtils", typeof (ToastUtils));

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

		internal ToastUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.toast']/class[@name='ToastUtils']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "")]
		public unsafe void Hide ()
		{
			const string __id = "hide.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.toast']/class[@name='ToastUtils']/method[@name='show' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("show", "(Landroid/content/Context;II)V", "")]
		public unsafe void Show (global::Android.Content.Context context, int resId, int time)
		{
			const string __id = "show.(Landroid/content/Context;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (resId);
				__args [2] = new JniArgumentValue (time);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.toast']/class[@name='ToastUtils']/method[@name='show' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("show", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public unsafe void Show (global::Android.Content.Context context, string? msg, int time)
		{
			const string __id = "show.(Landroid/content/Context;Ljava/lang/String;I)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (time);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
