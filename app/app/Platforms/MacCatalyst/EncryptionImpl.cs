[assembly: Dependency(typeof(app.EncryptionImpl))]
namespace app
{
    public partial class EncryptionImpl : Encryption
    {
        public string Login()
        {
            return "Login by MacCatalyst";
        }
    }
}
