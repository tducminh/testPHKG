using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.common']/class[@name='AppRepo']"
	[global::Android.Runtime.Register ("com/bglobal/app/common/AppRepo", DoNotGenerateAcw=true)]
	public abstract partial class AppRepo : global::Com.Bglobal.Base.Base.Repo.BaseRepo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/common/AppRepo", typeof (AppRepo));

		internal static new IntPtr class_ref {
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

		protected AppRepo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.common']/class[@name='AppRepo']/constructor[@name='AppRepo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppRepo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.common']/class[@name='AppRepo']/method[@name='buildFieldMapRequest' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("buildFieldMapRequest", "(Lcom/bglobal/app/data/source/remote/api/model/base/BaseApiRequest;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.bglobal.app.data.source.remote.api.model.base.BaseApiRequest"})]
		protected unsafe global::System.Collections.Generic.IDictionary<string, string> BuildFieldMapRequest (global::Java.Lang.Object t)
		{
			const string __id = "buildFieldMapRequest.(Lcom/bglobal/app/data/source/remote/api/model/base/BaseApiRequest;)Ljava/util/Map;";
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_t);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
				global::System.GC.KeepAlive (t);
			}
		}

	}

	[global::Android.Runtime.Register ("com/bglobal/app/common/AppRepo", DoNotGenerateAcw=true)]
	internal partial class AppRepoInvoker : AppRepo {
		public AppRepoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/common/AppRepo", typeof (AppRepoInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
