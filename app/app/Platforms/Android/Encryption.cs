using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;

namespace app
{
    public partial class Encryption
    {
        IEncryption encryption;

        public Encryption()
        {
            encryption = EncryptionManager.Create();
        }

        public partial void Init()
        {
            //EncryptionManager.Init();
        }

        public partial string Login()
        {
            string id = "user_id";
            string s = encryption.Login(id);

            return s;
        }

        public partial string UploadFile()
        {
            string[] arr = { "user_id_1", "user_id_2" };
            string id = "attachment_id";
            string url = "local_url";

            string s = encryption.UploadFile(id, arr, url);

            return s;
        }

        public partial string GetFile()
        {
            string id = "attachment_id";
            string s = encryption.GetFile(id);

            return s;
        }

        public partial string UpdatePermission()
        {
            string id = "user_id";
            string[] arr = { "user_id_1", "user_id_2" };

            string s = encryption.UpdatePermission(id, arr);

            return s;
        }

        public partial string BackUp()
        {
            string id = "attachment_id";
            string passcode = "passcode";
            string url = "local_url";

            string s = encryption.Backup(id, passcode, url);

            return s;
        }

        public partial string Restore()
        {
            string id = "attachment_id";
            string passcode = "passcode";

            string s = encryption.Restore(id, passcode);

            return s;
        }
    }
}
