
using iosEncryption;
using Foundation;

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
            return sdk.Logout;
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
            var bytesData = NSData.FromArray(bytes);
            return sdk.SendFile(token, thirdPartyId, userIds, bytesData);
        }

        public partial string GetFile(string token, string thirdPartyId)
        {
            SDKDataResponse response = sdk.GetFile(token, thirdPartyId);

            int code = 0;
            Int32.TryParse(response.status, out code);
            string errorMsg = response.error;
            NSData data = response.data;

            byte[] dataBytes = new byte[data.Length];
            System.Runtime.InteropServices.Marshal.Copy(data.Bytes, dataBytes, 0, Convert.ToInt32(data.Length));

            return "";
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
