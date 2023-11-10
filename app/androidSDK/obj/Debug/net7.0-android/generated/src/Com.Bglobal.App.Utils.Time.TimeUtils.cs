using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.Utils.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']"
	[global::Android.Runtime.Register ("com/bglobal/app/utils/time/TimeUtils", DoNotGenerateAcw=true)]
	public sealed partial class TimeUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='DATE_FORMAT']"
		[Register ("DATE_FORMAT")]
		public const string DateFormat = (string) "dd/MM/yyyy";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='DATE_FORMAT_V2']"
		[Register ("DATE_FORMAT_V2")]
		public const string DateFormatV2 = (string) "dd-MM-yyyy";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='DATE_FORMAT_V3']"
		[Register ("DATE_FORMAT_V3")]
		public const string DateFormatV3 = (string) "yyyy-MM-dd";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.Utils.Time.TimeUtils Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/utils/time/TimeUtils;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Utils.Time.TimeUtils> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='ISO_FORMAT']"
		[Register ("ISO_FORMAT")]
		public const string IsoFormat = (string) "yyyy-MM-dd'T'HH:mm:ss.SSS'Z'";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='ISO_FORMAT_V1']"
		[Register ("ISO_FORMAT_V1")]
		public const string IsoFormatV1 = (string) "yyyy-MM-dd'T'HH:mm:ss.SSSZ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='STRING_ISO_T']"
		[Register ("STRING_ISO_T")]
		public const string StringIsoT = (string) "yyyy-MM-dd'T'HH:mm:ss";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='STRING_ISO_T_Z']"
		[Register ("STRING_ISO_T_Z")]
		public const string StringIsoTZ = (string) "yyyy-MM-dd'T'HH:mm:ss.SSS+HH:mm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/field[@name='STRING_ISO_YYYY_MM_DD']"
		[Register ("STRING_ISO_YYYY_MM_DD")]
		public const string StringIsoYyyyMmDd = (string) "yyyy-MM-dd";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/utils/time/TimeUtils", typeof (TimeUtils));

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

		internal TimeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='calculatorTimeAgo' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("calculatorTimeAgo", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public unsafe string CalculatorTimeAgo (global::Java.Lang.Long? value)
		{
			const string __id = "calculatorTimeAgo.(Ljava/lang/Long;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='calculatorTimeAgoNotification' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("calculatorTimeAgoNotification", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string CalculatorTimeAgoNotification (string? value)
		{
			const string __id = "calculatorTimeAgoNotification.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertDateToMillis' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertDateToMillis", "(Ljava/lang/String;)J", "")]
		public unsafe long ConvertDateToMillis (string time)
		{
			const string __id = "convertDateToMillis.(Ljava/lang/String;)J";
			IntPtr native_time = JNIEnv.NewString ((string?)time);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_time);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertLongToString' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertLongToString", "(JLjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ConvertLongToString (long input, string output)
		{
			const string __id = "convertLongToString.(JLjava/lang/String;)Ljava/lang/String;";
			IntPtr native_output = JNIEnv.NewString ((string?)output);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (input);
				__args [1] = new JniArgumentValue (native_output);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertStringToLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertStringToLong", "(Ljava/lang/String;)J", "")]
		public unsafe long ConvertStringToLong (string input)
		{
			const string __id = "convertStringToLong.(Ljava/lang/String;)J";
			IntPtr native_input = JNIEnv.NewString ((string?)input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertStringToLongFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertStringToLongFormat", "(Ljava/lang/String;Ljava/lang/String;)J", "")]
		public unsafe long ConvertStringToLongFormat (string input, string formatPattern)
		{
			const string __id = "convertStringToLongFormat.(Ljava/lang/String;Ljava/lang/String;)J";
			IntPtr native_input = JNIEnv.NewString ((string?)input);
			IntPtr native_formatPattern = JNIEnv.NewString ((string?)formatPattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (native_formatPattern);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_formatPattern);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertStringToStringDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertStringToStringDate", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ConvertStringToStringDate (string inputStr, string format)
		{
			const string __id = "convertStringToStringDate.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_inputStr = JNIEnv.NewString ((string?)inputStr);
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputStr);
				__args [1] = new JniArgumentValue (native_format);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStr);
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertTimezoneToMillis' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertTimezoneToMillis", "(Ljava/lang/String;)J", "")]
		public unsafe long ConvertTimezoneToMillis (string time)
		{
			const string __id = "convertTimezoneToMillis.(Ljava/lang/String;)J";
			IntPtr native_time = JNIEnv.NewString ((string?)time);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_time);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertTimezoneToMillis' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertTimezoneToMillis", "(Ljava/lang/String;Ljava/lang/String;)J", "")]
		public unsafe long ConvertTimezoneToMillis (string format, string time)
		{
			const string __id = "convertTimezoneToMillis.(Ljava/lang/String;Ljava/lang/String;)J";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_time = JNIEnv.NewString ((string?)time);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				JNIEnv.DeleteLocalRef (native_time);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertTimezoneToMillisByString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertTimezoneToMillisByString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ConvertTimezoneToMillisByString (string format, string time)
		{
			const string __id = "convertTimezoneToMillisByString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_time = JNIEnv.NewString ((string?)time);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				JNIEnv.DeleteLocalRef (native_time);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='convertToHHmm' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertToHHmm", "(J)Ljava/lang/String;", "")]
		public unsafe string ConvertToHHmm (long time)
		{
			const string __id = "convertToHHmm.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='formatDate' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.lang.String']]"
		[Register ("formatDate", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string? FormatDate (global::Java.Util.Date date, string formatPattern)
		{
			const string __id = "formatDate.(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_formatPattern = JNIEnv.NewString ((string?)formatPattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				__args [1] = new JniArgumentValue (native_formatPattern);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_formatPattern);
				global::System.GC.KeepAlive (date);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.utils.time']/class[@name='TimeUtils']/method[@name='getTimeAgoNotification' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTimeAgoNotification", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetTimeAgoNotification (string time)
		{
			const string __id = "getTimeAgoNotification.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_time = JNIEnv.NewString ((string?)time);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_time);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_time);
			}
		}

	}
}
