//using Com.Bglobal.Publish;
//using Com.Bglobal.Publish.Encryption;



//[assembly: Dependency(typeof(sdk.SdkImpl))]
//namespace sdk
//{
//    // All the code in this file is only included on Android.
//    public class SdkImpl : Sdk
//    {
//        IEncryption encryption;

//        public SdkImpl()
//        {
//            encryption = EncryptionManager.Create();
//        }

//        public void Init()
//        {
//            //EncryptionManager.Init();
//        }

//        string Sdk.Login()
//        {
//            string id = "user_id";
//            string s = encryption.Login(id);

//            return s;
//        }
//        string Sdk.UploadFile()
//        {
//            string[] arr = { "user_id_1", "user_id_2" };
//            string id = "attachment_id";
//            string url = "local_url";

//            string s = encryption.UploadFile(id, arr, url);

//            return s;
//        }

//        string Sdk.GetFile()
//        {
//            string id = "attachment_id";
//            string s = encryption.GetFile(id);

//            return s;
//        }

//        string Sdk.UpdatPermission()
//        {
//            string id = "user_id";
//            string[] arr = { "user_id_1", "user_id_2" };

//            string s = encryption.UpdatePermission(id, arr);

//            return s;
//        }

//        string Sdk.BackUp()
//        {
//            string id = "attachment_id";
//            string passcode = "passcode";
//            string url = "local_url";

//            string s = encryption.Backup(id, passcode, url);

//            return s;
//        }

//        string Sdk.Restore()
//        {
//            string id = "attachment_id";
//            string passcode = "passcode";

//            string s = encryption.Restore(id, passcode);

//            return s;
//        }
//    }
//}
