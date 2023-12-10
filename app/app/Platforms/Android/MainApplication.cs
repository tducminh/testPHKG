using Android.App;
using Android.Runtime;
using Com.Bglobal.Publish;

namespace app
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            var context = Android.App.Application.Context;
            EncryptionManager.Init(context);
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}