namespace sdk
{
    public partial class SDK
    {
        public partial string Login(string thirdPartyToken, string thirdServiceId, string userId);
        public partial string Logout();
        public partial string SendText(string token, string  thirdPartyId, string[] userIds, string content);
        public partial string GetText(string token, string thirdPartyId);
        public partial string SendFile(string token, string thirdPartyId, string[] userIds, byte[] bytes);
        public partial string GetFile(string token, string thirdPartyId);
        public partial string DeleteFile(string token, string thirdPartyId);
        public partial string UpdatePermission(string token, string thirdPartyId, string[] userIds);
        public partial string Backup(string token);
        public partial string Restore(string token);
    }
}
