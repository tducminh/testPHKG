using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;




namespace sdk
{
    public partial class SDK
    {
        IEncryption encryption;

        public SDK()
        {
            encryption = EncryptionManager.Create();
        }

        public partial string Login()
        {
            //return "login by android";


            string id = "user_id";
            string s = encryption.Login(id);

            return s;
        }
    }
}
