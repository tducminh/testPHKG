using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig']"
	[global::Android.Runtime.Register ("com/bglobal/app/AppConfig", DoNotGenerateAcw=true)]
	public sealed partial class AppConfig : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.AppConfig Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer']"
		[global::Android.Runtime.Register ("com/bglobal/app/AppConfig$DataLayer", DoNotGenerateAcw=true)]
		public sealed partial class DataLayer : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer']/field[@name='BASE_DOMAIN']"
			[Register ("BASE_DOMAIN")]
			public const string BaseDomain = (string) "https://api.zzz.com.vn";


			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Bglobal.App.AppConfig.DataLayer Instance {
				get {
					const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig$DataLayer;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig.DataLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderName']"
			[global::Android.Runtime.Register ("com/bglobal/app/AppConfig$DataLayer$HeaderName", DoNotGenerateAcw=true)]
			public sealed partial class HeaderName : global::Java.Lang.Object {
				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderName']/field[@name='ACCEPT_LANGUAGE']"
				[Register ("ACCEPT_LANGUAGE")]
				public const string AcceptLanguage = (string) "Accept-Language";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderName']/field[@name='AUTHORIZATION']"
				[Register ("AUTHORIZATION")]
				public const string Authorization = (string) "Authorization";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderName']/field[@name='CONTENT_TYPE']"
				[Register ("CONTENT_TYPE")]
				public const string ContentType = (string) "Content-Type";


				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderName']/field[@name='INSTANCE']"
				[Register ("INSTANCE")]
				public static global::Com.Bglobal.App.AppConfig.DataLayer.HeaderName Instance {
					get {
						const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig$DataLayer$HeaderName;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig.DataLayer.HeaderName> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig$DataLayer$HeaderName", typeof (HeaderName));

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

				internal HeaderName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderValue']"
			[global::Android.Runtime.Register ("com/bglobal/app/AppConfig$DataLayer$HeaderValue", DoNotGenerateAcw=true)]
			public sealed partial class HeaderValue : global::Java.Lang.Object {
				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderValue']/field[@name='APPLICATION_JSON']"
				[Register ("APPLICATION_JSON")]
				public const string ApplicationJson = (string) "application/json";

				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderValue']/field[@name='APPLICATION_X_WWW_FORM_URLENCODED']"
				[Register ("APPLICATION_X_WWW_FORM_URLENCODED")]
				public const string ApplicationXWwwFormUrlencoded = (string) "application/x-www-form-urlencoded";


				// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DataLayer.HeaderValue']/field[@name='INSTANCE']"
				[Register ("INSTANCE")]
				public static global::Com.Bglobal.App.AppConfig.DataLayer.HeaderValue Instance {
					get {
						const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig$DataLayer$HeaderValue;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig.DataLayer.HeaderValue> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
					}
				}

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig$DataLayer$HeaderValue", typeof (HeaderValue));

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

				internal HeaderValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig$DataLayer", typeof (DataLayer));

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

			internal DataLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DomainLayer']"
		[global::Android.Runtime.Register ("com/bglobal/app/AppConfig$DomainLayer", DoNotGenerateAcw=true)]
		public sealed partial class DomainLayer : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DomainLayer']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Bglobal.App.AppConfig.DomainLayer Instance {
				get {
					const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig$DomainLayer;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig.DomainLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.DomainLayer']/field[@name='PAGE_LIMIT_DEFAULT']"
			[Register ("PAGE_LIMIT_DEFAULT")]
			public const int PageLimitDefault = (int) 10;

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig$DomainLayer", typeof (DomainLayer));

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

			internal DomainLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.PresentationLayer']"
		[global::Android.Runtime.Register ("com/bglobal/app/AppConfig$PresentationLayer", DoNotGenerateAcw=true)]
		public sealed partial class PresentationLayer : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.PresentationLayer']/field[@name='DURATION_NAVIGATE_SCREEN_DEFAULT']"
			[Register ("DURATION_NAVIGATE_SCREEN_DEFAULT")]
			public const long DurationNavigateScreenDefault = (long) 250;


			// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app']/class[@name='AppConfig.PresentationLayer']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Bglobal.App.AppConfig.PresentationLayer Instance {
				get {
					const string __id = "INSTANCE.Lcom/bglobal/app/AppConfig$PresentationLayer;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.AppConfig.PresentationLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig$PresentationLayer", typeof (PresentationLayer));

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

			internal PresentationLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/AppConfig", typeof (AppConfig));

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

		internal AppConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
