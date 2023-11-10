using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Validate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.validate']/class[@name='PasswordValidate']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/validate/PasswordValidate", DoNotGenerateAcw=true)]
	public sealed partial class PasswordValidate : global::Java.Lang.Object, global::Com.Bglobal.App.Utils.Validate.IValidate {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.validate']/class[@name='PasswordValidate.Companion']"
		[global::Android.Runtime.Register ("com/bglobal/app/utils/validate/PasswordValidate$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/validate/PasswordValidate$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/validate/PasswordValidate", typeof (PasswordValidate));

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

		internal PasswordValidate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bglobal.app.utils.validate']/class[@name='PasswordValidate']/constructor[@name='PasswordValidate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PasswordValidate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.validate']/class[@name='PasswordValidate']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validate", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Validate (string data)
		{
			const string __id = "validate.(Ljava/lang/String;)Z";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.validate']/class[@name='PasswordValidate']/method[@name='validateLength' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateLength", "(Ljava/lang/String;)Z", "")]
		public unsafe bool ValidateLength (string data)
		{
			const string __id = "validateLength.(Ljava/lang/String;)Z";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Bglobal.App.Utils.Validate.IValidate
		bool global::Com.Bglobal.App.Utils.Validate.IValidate.Validate (global::Java.Lang.Object? data)
		{
			return Validate (data?.ToString ());
		}

	}
}
