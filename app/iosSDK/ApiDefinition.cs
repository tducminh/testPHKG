using Foundation;
using ObjCRuntime;

namespace iosEncryption {
    // @interface Encryption : NSObject
    [BaseType(typeof(NSObject))]
    interface Encryption
    {
        // -(NSString * _Nonnull)loginWithThirdPartyToken:(NSString * _Nonnull)thirdPartyToken thirdServiceId:(NSString * _Nonnull)thirdServiceId userId:(NSString * _Nonnull)userId __attribute__((warn_unused_result("")));
        [Export("loginWithThirdPartyToken:thirdServiceId:userId:")]
        string Login(string thirdPartyToken, string thirdServiceId, string userId);

        // -(NSString * _Nonnull)sendTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds text:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
        [Export("sendTextWithToken:thirdPartyId:userIds:text:")]
        string SendText(string token, string thirdPartyId, string[] userIds, string text);

        // -(NSString * _Nonnull)getTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Export("getTextWithToken:thirdPartyId:")]
        string GetText(string token, string thirdPartyId);

        // -(NSString * _Nonnull)sendFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds buffer:(NSString * _Nonnull)buffer __attribute__((warn_unused_result("")));
        [Export("sendFileWithToken:thirdPartyId:userIds:buffer:")]
        string SendFile(string token, string thirdPartyId, string[] userIds, string buffer);

        // -(NSString * _Nonnull)getFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Export("getFileWithToken:thirdPartyId:")]
        string GetFile(string token, string thirdPartyId);

        // -(NSString * _Nonnull)updatePermissionWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds __attribute__((warn_unused_result("")));
        [Export("updatePermissionWithToken:thirdPartyId:userIds:")]
        string UpdatePermission(string token, string thirdPartyId, string[] userIds);

        // -(NSString * _Nonnull)backupWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
        [Export("backupWithToken:")]
        string Backup(string token);

        // -(NSString * _Nonnull)restoreWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
        [Export("restoreWithToken:")]
        string Restore(string token);

        // -(NSString * _Nonnull)logoutWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
        [Export("logoutWithToken:")]
        string Logout(string token);
    }
}


