using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/common/BaseSharePreferenceKt", DoNotGenerateAcw=true)]
	public sealed partial class BaseSharePreferenceKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/common/BaseSharePreferenceKt", typeof (BaseSharePreferenceKt));

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

		internal BaseSharePreferenceKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Java.Lang.Class BooleanClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getBooleanClass' and count(parameter)=0]"
			[Register ("getBooleanClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getBooleanClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class ByteClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getByteClass' and count(parameter)=0]"
			[Register ("getByteClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getByteClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class CharClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getCharClass' and count(parameter)=0]"
			[Register ("getCharClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getCharClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class DoubleClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getDoubleClass' and count(parameter)=0]"
			[Register ("getDoubleClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getDoubleClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class FloatClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getFloatClass' and count(parameter)=0]"
			[Register ("getFloatClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getFloatClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class IntClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getIntClass' and count(parameter)=0]"
			[Register ("getIntClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getIntClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class LongClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getLongClass' and count(parameter)=0]"
			[Register ("getLongClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getLongClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class ShortClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getShortClass' and count(parameter)=0]"
			[Register ("getShortClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getShortClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class StringClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.common']/class[@name='BaseSharePreferenceKt']/method[@name='getStringClass' and count(parameter)=0]"
			[Register ("getStringClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getStringClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

	}
}
