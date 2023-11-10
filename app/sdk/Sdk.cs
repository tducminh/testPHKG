using Microsoft.Maui;
using androidSDK;
using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;

namespace sdk
{
	// All the code in this file is included in all platforms.
	public class Sdk
	{

        public Sdk() { }

		public void Init()
		{
			Console.WriteLine("init");
		}

		public string Login()
		{

            //todo: chưa gọi đc class trong sdk/Platforms/Android/.....

            //AndroidEncryption encryption = new AndroidEncryption();

            //         string s =  encryption.Login();



            //IEncryption encryption = EncryptionManager.Create();
            //string s = encryption.Login("user_id");

            //return s;


            return "Login";
        }

        public string UploadFile()
        {
            return "uploadFile";
        }

        public string GetFile()
        {
            return "GetFile";
        }

        public string UpdatPermission()
        {
            return "UpdatPermission";
        }

        public string BackUp()
        {
            return "BackUp";
        }

        public string Restore()
        {
            return "Restore";
        }
    }
}
