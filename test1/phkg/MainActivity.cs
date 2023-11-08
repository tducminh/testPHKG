using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Com.Zzz.Publish;
using Com.Zzz.Publish.Vptw;
using Com.Zzz.Publish.Common;
using Android.Util;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private string tag = "anhnd";
        private IVptw vptw = EncryptionManager.Vptw();
        public static Android.Content.Context CurrentContext { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            var btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += (sender, e) =>
            {
                login();
            };

            var btnUploadFile = FindViewById<Button>(Resource.Id.btnUploadFile);
            btnUploadFile.Click += (sender, e) =>
            {
                uploadFile();
            };

            var btnGetFile = FindViewById<Button>(Resource.Id.btnGetFile);
            btnGetFile.Click += (sender, e) =>
            {
                getFile();
            };

            var btnUpdatePermission = FindViewById<Button>(Resource.Id.btnUpdatePermission);
            btnUpdatePermission.Click += (sender, e) =>
            {
                updatePermission();
            };

            var btnBackup = FindViewById<Button>(Resource.Id.btnBackup);
            btnBackup.Click += (sender, e) =>
            {
                backup();
            };

            var btnRestore = FindViewById<Button>(Resource.Id.btnRestore);
            btnRestore.Click += (sender, e) =>
            {
                restore();
            };

            var ivClearLog = FindViewById<ImageView>(Resource.Id.ivClearLog);
            ivClearLog.Click += (sender, e) =>
            {
                bind("");
            };
        }

        private void login()
        {
            string id = "user_id";

            VptwAuthInfo info = vptw.Login(id);
            int code = info.Code;
            string msg = info.Message;
            string token = info.Token;

            Log.Error(tag, "login:   " + info.ToString());
            bind(info.ToString());
        }

        private void uploadFile()
        {
            string id = "attachment_d";
            string[] arr = { "user_id_1", "user_id_2" };
            string url = "local_url";

            EncryptionInfo info = vptw.UploadFile(id, arr, url);
            int code = info.Code;
            string msg = info.Message;

            Log.Error(tag, "uploadFile:   " + info.ToString());
            bind(info.ToString());
        }

        private void getFile()
        {
            string id = "attachment_id";

            VptwFileInfo info = vptw.GetFile(id);
            int code = info.Code;
            string msg = info.Message;
            string url = info.Url;

            Log.Error(tag, "getFile:   " + info.ToString());
            bind(info.ToString());
        }

        private void updatePermission()
        {
            string id = "user_id";
            string[] arr = { "a", "b" };

            EncryptionInfo info = vptw.UpdatePermission(id, arr);
            int code = info.Code;
            string msg = info.Message;

            Log.Error(tag, "updatePermission:   " + info.ToString());
            bind(info.ToString());
        }

        private void backup()
        {
            string id = "attachment_id";
            string passcode = "passcode";
            string url = "local_url";

            EncryptionInfo info = vptw.Backup(id, passcode, url);
            int code = info.Code;
            string msg = info.Message;

            Log.Error(tag, "backup:   " + info.ToString());
            bind(info.ToString());
        }

        private void restore()
        {
            string id = "attachment_id";
            string passcode = "passcode";

            VptwFileInfo info = vptw.Restore(id, passcode);
            int code = info.Code;
            string msg = info.Message;
            string url = info.Url;

            Log.Error(tag, "restore:    " + info.ToString());
            bind(info.ToString());
        }

        private void bind(string s)
        {
            var tvLogcat = FindViewById<TextView>(Resource.Id.tvLogcat);
            tvLogcat.Text = s;
        }
    }
}