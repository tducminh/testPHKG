using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bglobal.App.DI.Factory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bglobal.app.di.factory']/class[@name='RepositoryFactory']"
	[global::Android.Runtime.Register ("com/bglobal/app/di/factory/RepositoryFactory", DoNotGenerateAcw=true)]
	public sealed partial class RepositoryFactory : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bglobal.app.di.factory']/class[@name='RepositoryFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Bglobal.App.DI.Factory.RepositoryFactory Instance {
			get {
				const string __id = "INSTANCE.Lcom/bglobal/app/di/factory/RepositoryFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.DI.Factory.RepositoryFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/bglobal/app/di/factory/RepositoryFactory", typeof (RepositoryFactory));

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

		internal RepositoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Bglobal.App.Domain.Repo.IAuthRepo AuthRepo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.di.factory']/class[@name='RepositoryFactory']/method[@name='getAuthRepo' and count(parameter)=0]"
			[Register ("getAuthRepo", "()Lcom/bglobal/app/domain/repo/AuthRepo;", "")]
			get {
				const string __id = "getAuthRepo.()Lcom/bglobal/app/domain/repo/AuthRepo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IAuthRepo> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Bglobal.App.Domain.Repo.IDataRepo DataRepo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.di.factory']/class[@name='RepositoryFactory']/method[@name='getDataRepo' and count(parameter)=0]"
			[Register ("getDataRepo", "()Lcom/bglobal/app/domain/repo/DataRepo;", "")]
			get {
				const string __id = "getDataRepo.()Lcom/bglobal/app/domain/repo/DataRepo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IDataRepo> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Bglobal.App.Domain.Repo.IResourceRepo ResourceRepo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bglobal.app.di.factory']/class[@name='RepositoryFactory']/method[@name='getResourceRepo' and count(parameter)=0]"
			[Register ("getResourceRepo", "()Lcom/bglobal/app/domain/repo/ResourceRepo;", "")]
			get {
				const string __id = "getResourceRepo.()Lcom/bglobal/app/domain/repo/ResourceRepo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Bglobal.App.Domain.Repo.IResourceRepo> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

	}
}
