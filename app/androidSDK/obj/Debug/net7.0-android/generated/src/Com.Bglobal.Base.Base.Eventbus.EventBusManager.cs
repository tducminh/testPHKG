using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.Base.Base.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']"
	[global::Android.Runtime.Register ("com/bglobal/base/base/eventbus/EventBusManager", DoNotGenerateAcw=true)]
	public sealed partial class EventBusManager : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.Base.Base.Eventbus.EventBusManager Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/base/base/eventbus/EventBusManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.Base.Base.Eventbus.EventBusManager> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/base/base/eventbus/EventBusManager", typeof (EventBusManager));

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

		internal EventBusManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/method[@name='post' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEvent']]"
		[Register ("post", "(Lcom/bglobal/base/base/eventbus/IEvent;)V", "")]
		public unsafe void Post (global::Com.Bglobal.Base.Base.Eventbus.IEvent e)
		{
			const string __id = "post.(Lcom/bglobal/base/base/eventbus/IEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/method[@name='postPending' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEvent']]"
		[Register ("postPending", "(Lcom/bglobal/base/base/eventbus/IEvent;)V", "")]
		public unsafe void PostPending (global::Com.Bglobal.Base.Base.Eventbus.IEvent e)
		{
			const string __id = "postPending.(Lcom/bglobal/base/base/eventbus/IEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEventHandler']]"
		[Register ("register", "(Lcom/bglobal/base/base/eventbus/IEventHandler;)V", "")]
		public unsafe void Register (global::Com.Bglobal.Base.Base.Eventbus.IEventHandler eventHandler)
		{
			const string __id = "register.(Lcom/bglobal/base/base/eventbus/IEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/method[@name='removeSticky' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEvent']]"
		[Register ("removeSticky", "(Lcom/bglobal/base/base/eventbus/IEvent;)V", "")]
		public unsafe void RemoveSticky (global::Com.Bglobal.Base.Base.Eventbus.IEvent e)
		{
			const string __id = "removeSticky.(Lcom/bglobal/base/base/eventbus/IEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.base.base.eventbus']/class[@name='EventBusManager']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='com.bglobal.base.base.eventbus.IEventHandler']]"
		[Register ("unregister", "(Lcom/bglobal/base/base/eventbus/IEventHandler;)V", "")]
		public unsafe void Unregister (global::Com.Bglobal.Base.Base.Eventbus.IEventHandler eventHandler)
		{
			const string __id = "unregister.(Lcom/bglobal/base/base/eventbus/IEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventHandler);
			}
		}

	}
}
