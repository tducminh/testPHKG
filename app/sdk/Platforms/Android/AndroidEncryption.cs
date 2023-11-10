using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;

namespace sdk
{
    // All the code in this file is only included on Android.
    public class AndroidEncryption
    {
        public AndroidEncryption()
        {
        }

        public string Login()
        {
            IEncryption encryption = EncryptionManager.Create();
            string s = encryption.Login("user_id");

            return s;
        }
    }
}
