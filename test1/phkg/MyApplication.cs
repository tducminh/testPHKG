using System;
using Android.App;
using Com.Zzz.Publish;

namespace App1
{
    [Application(Theme = "@style/MyMaterialTheme")]
    public class MyApplication : Application
    {

        public MyApplication()
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            EncryptionManager.Init(this);
        }
    }
}

