using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/ext/CommonExtKt", DoNotGenerateAcw=true)]
	public sealed partial class CommonExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/ext/CommonExtKt", typeof (CommonExtKt));

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

		internal CommonExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppColor", "(ILandroid/content/Context;)I", "")]
		public static unsafe int GetAppColor (int colorRes, global::Android.Content.Context? context)
		{
			const string __id = "getAppColor.(ILandroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (colorRes);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppDimension", "(ILandroid/content/Context;)F", "")]
		public static unsafe float GetAppDimension (int dimenId, global::Android.Content.Context? context)
		{
			const string __id = "getAppDimension.(ILandroid/content/Context;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dimenId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppDimensionPixel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppDimensionPixel", "(ILandroid/content/Context;)I", "")]
		public static unsafe int GetAppDimensionPixel (int dimenId, global::Android.Content.Context? context)
		{
			const string __id = "getAppDimensionPixel.(ILandroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dimenId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppDrawable", "(ILandroid/content/Context;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable? GetAppDrawable (int drawableId, global::Android.Content.Context? context)
		{
			const string __id = "getAppDrawable.(ILandroid/content/Context;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (drawableId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppFont' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppFont", "(ILandroid/content/Context;)Landroid/graphics/Typeface;", "")]
		public static unsafe global::Android.Graphics.Typeface? GetAppFont (int fontId, global::Android.Content.Context? context)
		{
			const string __id = "getAppFont.(ILandroid/content/Context;)Landroid/graphics/Typeface;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fontId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppSpannableString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppSpannableString", "(ILandroid/content/Context;)Landroid/text/SpannableString;", "")]
		public static unsafe global::Android.Text.SpannableString GetAppSpannableString (int stringId, global::Android.Content.Context? context)
		{
			const string __id = "getAppSpannableString.(ILandroid/content/Context;)Landroid/text/SpannableString;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (stringId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Text.SpannableString> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppString", "(ILandroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppString (int stringId, global::Android.Content.Context? context)
		{
			const string __id = "getAppString.(ILandroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (stringId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppString' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='android.content.Context']]"
		[Register ("getAppString", "(I[Ljava/lang/Object;Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppString (int stringId, global::Java.Lang.Object[] @params, global::Android.Content.Context? context)
		{
			const string __id = "getAppString.(I[Ljava/lang/Object;Landroid/content/Context;)Ljava/lang/String;";
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (stringId);
				__args [1] = new JniArgumentValue (native__params);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
				global::System.GC.KeepAlive (@params);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.ext']/class[@name='CommonExtKt']/method[@name='getAppTextSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppTextSize", "(ILandroid/content/Context;)F", "")]
		public static unsafe float GetAppTextSize (int dimenId, global::Android.Content.Context? context)
		{
			const string __id = "getAppTextSize.(ILandroid/content/Context;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dimenId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
