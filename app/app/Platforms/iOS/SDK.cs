
using iosEncryption;

namespace sdk
{
    public partial class SDK
    {
        private Encryption sdk;

        public SDK()
        {
            sdk = new Encryption(); 
        }

        public partial string Login(string thirdPartyToken, string thirdServiceId, string userId)
        {
            return sdk.Login(thirdPartyToken, thirdServiceId, userId);
        }

        public partial string Logout()
        {
            var accessToken = "jwt";
            return sdk.Logout(accessToken);
        }

        public partial string SendText(string token, string thirdPartyId, string[] userIds, string content)
        {
            return sdk.SendText(token, thirdPartyId, userIds, content);
        }

        public partial string GetText(string token, string thirdPartyId)
        {
            return sdk.GetText(token, thirdPartyId);
        }

        public partial string SendFile(string token, string thirdPartyId, string[] userIds, byte[] bytes)
        {
            var strBase64 = "data_to_str_base64";
            return sdk.SendFile(token, thirdPartyId, userIds, strBase64);
        }

        public partial string GetFile(string token, string thirdPartyId)
        {
            return sdk.GetFile(token, thirdPartyId);
        }

        public partial string DeleteFile(string token, string thirdPartyId)
        {
            return "";
        }

        public partial string UpdatePermission(string token, string thirdPartyId, string[] userIds)
        {
            return sdk.UpdatePermission(token, thirdPartyId, userIds);
        }

        public partial string Backup(string token)
        {
            return sdk.Backup(token);
        }

        public partial string Restore(string token)
        {
            return sdk.Restore(token);
        }
    }
}
