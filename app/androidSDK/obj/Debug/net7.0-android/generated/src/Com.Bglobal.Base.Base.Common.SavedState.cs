using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SavedState']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/SavedState", DoNotGenerateAcw=true)]
	public sealed partial class SavedState : global::Android.Views.View.BaseSavedState {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/SavedState", typeof (SavedState));

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

		internal SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SavedState']/constructor[@name='SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
		public unsafe SavedState (global::Android.OS.IParcelable superState) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcelable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((superState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) superState).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (superState);
			}
		}

		public unsafe global::Android.Util.SparseArray? ChildrenStates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SavedState']/method[@name='getChildrenStates' and count(parameter)=0]"
			[Register ("getChildrenStates", "()Landroid/util/SparseArray;", "")]
			get {
				const string __id = "getChildrenStates.()Landroid/util/SparseArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='SavedState']/method[@name='setChildrenStates' and count(parameter)=1 and parameter[1][@type='android.util.SparseArray&lt;java.lang.Object&gt;']]"
			[Register ("setChildrenStates", "(Landroid/util/SparseArray;)V", "")]
			set {
				const string __id = "setChildrenStates.(Landroid/util/SparseArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
