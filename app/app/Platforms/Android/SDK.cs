using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Response;

namespace sdk
{
    public partial class SDK
    {
        private IEncryption sdk;

        public SDK()
        {
            sdk = EncryptionManager.Create();
        }

        public partial string Login(string thirdPartyToken, string thirdServiceId, string userId)
        {
            return sdk.Login(thirdPartyToken, thirdServiceId, userId);
        }

        public partial string Logout()
        {
            return sdk.Logout();
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
            return sdk.SendFile(token, thirdPartyId, userIds, bytes);
        }

        public partial string GetFile(string token, string thirdPartyId)
        {
            DataResponse response = sdk.GetFile(token, thirdPartyId);

            int code = response.Code;
            string msg = response.Message;
            byte[] bytes = response.GetData();

            return Convert.ToBase64String(bytes);
        }

        public partial string DeleteFile(string token, string thirdPartyId)
        {
            return sdk.DeleteFile(token, thirdPartyId);
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
