

namespace sdk
{
    public partial class SDK
    {
       

        public SDK()
        {

        }

        public partial string Login(string thirdPartyToken, string thirdServiceId, string userId)
        {
            return "";
        }

        public partial string Logout()
        {
            return "";
        }

        public partial string SendText(string token, string thirdPartyId, string[] userIds, string content)
        {
            return "";
        }

        public partial string GetText(string token, string thirdPartyId)
        {
            return "";
        }

        public partial string SendFile(string token, string thirdPartyId, string[] userIds, byte[] bytes)
        {
            return "";
        }

        public partial string GetFile(string token, string thirdPartyId)
        {
            return "";
        }

        public partial string DeleteFile(string token, string thirdPartyId)
        {
            return "";
        }

        public partial string UpdatePermission(string token, string thirdPartyId, string[] userIds)
        {
            return "";
        }

        public partial string Backup(string token)
        {
            return "";
        }

        public partial string Restore(string token)
        {
            return "";
        }
    }
}
