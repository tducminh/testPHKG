using Foundation;

namespace iosEncryption
{
    [Protocol]
    interface IEncryptionProtocol
    {
        // @required -(NSString * _Nonnull)loginWithThirdPartyToken:(NSString * _Nonnull)thirdPartyToken thirdServiceId:(NSString * _Nonnull)thirdServiceId userId:(NSString * _Nonnull)userId __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("loginWithThirdPartyToken:thirdServiceId:userId:")]
        string Login(string thirdPartyToken, string thirdServiceId, string userId);

        // @required -(NSString * _Nonnull)sendTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds text:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("sendTextWithToken:thirdPartyId:userIds:text:")]
        string SendText(string token, string thirdPartyId, string[] userIds, string text);

        // @required -(NSString * _Nonnull)getTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getTextWithToken:thirdPartyId:")]
        string GetText(string token, string thirdPartyId);

        // @required -(NSString * _Nonnull)sendFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds buffer:(NSData * _Nonnull)buffer __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("sendFileWithToken:thirdPartyId:userIds:buffer:")]
        string SendFile(string token, string thirdPartyId, string[] userIds, NSData buffer);

        // @required -(SDKDataResponse * _Nonnull)getFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getFileWithToken:thirdPartyId:")]
        SDKDataResponse GetFile(string token, string thirdPartyId);

        // @required -(NSString * _Nonnull)deleteFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("deleteFileWithToken:thirdPartyId:")]
        string DeleteFile(string token, string thirdPartyId);

        // @required -(NSString * _Nonnull)updatePermissionWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("updatePermissionWithToken:thirdPartyId:userIds:")]
        string UpdatePermission(string token, string thirdPartyId, string[] userIds);

        // @required -(NSString * _Nonnull)restoreWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("restoreWithToken:")]
        string Restore(string token);

        // @required -(NSString * _Nonnull)logoutWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("logout")]
        string Logout { get; }
    }

    // @interface Encryption : NSObject <EncryptionProtocol>
    [BaseType(typeof(NSObject))]
    interface Encryption : IEncryptionProtocol
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

        // -(NSString * _Nonnull)sendFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds buffer:(NSData * _Nonnull)buffer __attribute__((warn_unused_result("")));
        [Export("sendFileWithToken:thirdPartyId:userIds:buffer:")]
        string SendFile(string token, string thirdPartyId, string[] userIds, NSData buffer);

        // -(SDKDataResponse * _Nonnull)getFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Export("getFileWithToken:thirdPartyId:")]
        SDKDataResponse GetFile(string token, string thirdPartyId);

        // -(NSString * _Nonnull)deleteFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
        [Export("deleteFileWithToken:thirdPartyId:")]
        string DeleteFile(string token, string thirdPartyId);

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
        [Export("logout")]
        string Logout { get; }
    }

    // @interface SDKDataResponse : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10Encryption15SDKDataResponse")]
    interface SDKDataResponse
    {
        [NullAllowed, Export("data")]
        NSData data { get; set; }

        [NullAllowed, Export("token")]
        string token { get; set; }

        [NullAllowed, Export("status")]
        string status { get; set; }

        [NullAllowed, Export("error")]
        string error { get; set; }
    }
}