[assembly: Dependency(typeof(app.EncryptionImpl))]
namespace app
{
    internal class EncryptionImpl : Encryption
    {
        public string Login()
        {
            return "Login by Tizen";
        }
    }
}
