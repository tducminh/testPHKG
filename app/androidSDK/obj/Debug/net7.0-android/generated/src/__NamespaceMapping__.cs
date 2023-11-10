using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app", Managed="Com.Bglobal.App")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.common", Managed="Com.Bglobal.App.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.repository.auth", Managed="Com.Bglobal.App.Data.Repository.Auth")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.repository.data", Managed="Com.Bglobal.App.Data.Repository.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.repository.resource", Managed="Com.Bglobal.App.Data.Repository.Resource")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.source.local", Managed="Com.Bglobal.App.Data.Source.Local")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.source.local.prefs", Managed="Com.Bglobal.App.Data.Source.Local.Prefs")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.source.remote.api.model.base", Managed="Com.Bglobal.App.Data.Source.Remote.Api.Model.Base")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.source.remote.api.service", Managed="Com.Bglobal.App.Data.Source.Remote.Api.Service")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.data.source.remote.network", Managed="Com.Bglobal.App.Data.Source.Remote.Network")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.di.factory", Managed="Com.Bglobal.App.DI.Factory")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.domain.event", Managed="Com.Bglobal.App.Domain.Event")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.domain.model", Managed="Com.Bglobal.App.Domain.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.domain.model.auth", Managed="Com.Bglobal.App.Domain.Model.Auth")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.domain.model.resource", Managed="Com.Bglobal.App.Domain.Model.Resource")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.domain.repo", Managed="Com.Bglobal.App.Domain.Repo")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.exception", Managed="Com.Bglobal.App.Utils.Exception")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.ext", Managed="Com.Bglobal.App.Utils.Ext")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.file", Managed="Com.Bglobal.App.Utils.File")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.logging", Managed="Com.Bglobal.App.Utils.Logging")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.time", Managed="Com.Bglobal.App.Utils.Time")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.toast", Managed="Com.Bglobal.App.Utils.Toast")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.app.utils.validate", Managed="Com.Bglobal.App.Utils.Validate")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.common", Managed="Com.Bglobal.Base.Base.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.common.usecase", Managed="Com.Bglobal.Base.Base.Common.Usecase")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.common.usecase.coroutines", Managed="Com.Bglobal.Base.Base.Common.Usecase.Coroutines")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.common.usecase.executor", Managed="Com.Bglobal.Base.Base.Common.Usecase.Executor")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.eventbus", Managed="Com.Bglobal.Base.Base.Eventbus")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.base.base.repo", Managed="Com.Bglobal.Base.Base.Repo")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.encryption", Managed="Com.Bglobal.Encryption")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.publish", Managed="Com.Bglobal.Publish")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.bglobal.publish.encryption", Managed="Com.Bglobal.Publish.Encryption")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

