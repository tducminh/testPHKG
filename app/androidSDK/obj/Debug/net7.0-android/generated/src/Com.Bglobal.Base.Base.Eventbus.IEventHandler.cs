using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Eventbus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/interface[@name='IEventHandler']"
	[Register ("com/bglobal/base/base/eventbus/IEventHandler", "", "Com.Bglobal.Base.Base.Eventbus.IEventHandlerInvoker")]
	public partial interface IEventHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/interface[@name='IEventHandler']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEvent']]"
		[Register ("onEvent", "(Lcom/bglobal/base/base/eventbus/IEvent;)V", "GetOnEvent_Lcom_bglobal_base_base_eventbus_IEvent_Handler:Com.Bglobal.Base.Base.Eventbus.IEventHandlerInvoker, androidSDK")]
		void OnEvent (global::Com.Bglobal.Base.Base.Eventbus.IEvent e);

	}

	[global::Android.Runtime.Register ("com/bglobal/base/base/eventbus/IEventHandler", DoNotGenerateAcw=true)]
	internal partial class IEventHandlerInvoker : global::Java.Lang.Object, IEventHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/eventbus/IEventHandler", typeof (IEventHandlerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IEventHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.bglobal.base.base.eventbus.IEventHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lcom_bglobal_base_base_eventbus_IEvent_Handler ()
		{
			if (cb_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_ == null)
				cb_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEvent_Lcom_bglobal_base_base_eventbus_IEvent_);
			return cb_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_;
		}

		static void n_OnEvent_Lcom_bglobal_base_base_eventbus_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Eventbus.IEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var e = (global::Com.Bglobal.Base.Base.Eventbus.IEvent?)global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Eventbus.IEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (e!);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_;
		public unsafe void OnEvent (global::Com.Bglobal.Base.Base.Eventbus.IEvent e)
		{
			if (id_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_ == IntPtr.Zero)
				id_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lcom/bglobal/base/base/eventbus/IEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Lcom_bglobal_base_base_eventbus_IEvent_, __args);
		}

	}
}
