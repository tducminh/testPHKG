using CoreData;
using Foundation;
using ObjCRuntime;

namespace iosSDK
{
	// @interface AccountGroupMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface AccountGroupMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_316 (AccountGroupMO)
	[Category]
	[BaseType (typeof(AccountGroupMO))]
	interface AccountGroupMO_Encryption_Swift_316
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable invite_by;
		[NullAllowed, Export ("invite_by")]
		string Invite_by { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }
	}

	// @interface AccountKeyMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface AccountKeyMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_339 (AccountKeyMO)
	[Category]
	[BaseType (typeof(AccountKeyMO))]
	interface AccountKeyMO_Encryption_Swift_339
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (nonatomic) int32_t last_resort;
		[Export ("last_resort")]
		int Last_resort { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_key;
		[NullAllowed, Export ("public_key")]
		string Public_key { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable signature;
		[NullAllowed, Export ("signature")]
		string Signature { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable uuid;
		[NullAllowed, Export ("uuid")]
		string Uuid { get; set; }
	}

	// @interface AccountMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface AccountMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_362 (AccountMO)
	[Category]
	[BaseType (typeof(AccountMO))]
	interface AccountMO_Encryption_Swift_362
	{
		// @property (copy, nonatomic) NSString * _Nullable address;
		[NullAllowed, Export ("address")]
		string Address { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable avatarId;
		[NullAllowed, Export ("avatarId")]
		string AvatarId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable background_id;
		[NullAllowed, Export ("background_id")]
		string Background_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable birthday;
		[NullAllowed, Export ("birthday")]
		string Birthday { get; set; }

		// @property (nonatomic) int64_t block_time;
		[Export ("block_time")]
		long Block_time { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable first_name;
		[NullAllowed, Export ("first_name")]
		string First_name { get; set; }

		// @property (nonatomic) int16_t gender;
		[Export ("gender")]
		short Gender { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable last_name;
		[NullAllowed, Export ("last_name")]
		string Last_name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mail;
		[NullAllowed, Export ("mail")]
		string Mail { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pin;
		[NullAllowed, Export ("pin")]
		string Pin { get; set; }

		// @property (nonatomic) int32_t region_code;
		[Export ("region_code")]
		int Region_code { get; set; }

		// @property (nonatomic) int32_t resendTimes;
		[Export ("resendTimes")]
		int ResendTimes { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }

		// @property (nonatomic) int32_t verifyTimes;
		[Export ("verifyTimes")]
		int VerifyTimes { get; set; }
	}

	// @interface ApiCallMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface ApiCallMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_397 (ApiCallMO)
	[Category]
	[BaseType (typeof(ApiCallMO))]
	interface ApiCallMO_Encryption_Swift_397
	{
		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable content;
		[NullAllowed, Export ("content")]
		string Content { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable original_content;
		[NullAllowed, Export ("original_content")]
		string Original_content { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable original_uid;
		[NullAllowed, Export ("original_uid")]
		string Original_uid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable query;
		[NullAllowed, Export ("query")]
		string Query { get; set; }

		// @property (nonatomic) int64_t retry;
		[Export ("retry")]
		long Retry { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable task;
		[NullAllowed, Export ("task")]
		string Task { get; set; }
	}

	// @interface BranchAccountMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface BranchAccountMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_420 (BranchAccountMO)
	[Category]
	[BaseType (typeof(BranchAccountMO))]
	interface BranchAccountMO_Encryption_Swift_420
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }
	}

	// @interface BranchMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface BranchMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_440 (BranchMO)
	[Category]
	[BaseType (typeof(BranchMO))]
	interface BranchMO_Encryption_Swift_440
	{
		// @property (copy, nonatomic) NSString * _Nullable attachment_id;
		[NullAllowed, Export ("attachment_id")]
		string Attachment_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_ip;
		[NullAllowed, Export ("public_ip")]
		string Public_ip { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }
	}

	// @interface CallHistoryMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface CallHistoryMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_463 (CallHistoryMO)
	[Category]
	[BaseType (typeof(CallHistoryMO))]
	interface CallHistoryMO_Encryption_Swift_463
	{
		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable calling_members;
		[NullAllowed, Export ("calling_members")]
		string Calling_members { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (nonatomic) int16_t group_type;
		[Export ("group_type")]
		short Group_type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable joined_members;
		[NullAllowed, Export ("joined_members")]
		string Joined_members { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable parent_id;
		[NullAllowed, Export ("parent_id")]
		string Parent_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable room_id;
		[NullAllowed, Export ("room_id")]
		string Room_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sender_id;
		[NullAllowed, Export ("sender_id")]
		string Sender_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source_id;
		[NullAllowed, Export ("source_id")]
		string Source_id { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }
	}

	// @interface ContactMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface ContactMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_492 (ContactMO)
	[Category]
	[BaseType (typeof(ContactMO))]
	interface ContactMO_Encryption_Swift_492
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable contact_id;
		[NullAllowed, Export ("contact_id")]
		string Contact_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable contact_name;
		[NullAllowed, Export ("contact_name")]
		string Contact_name { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }
	}

	// @interface DeviceMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface DeviceMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_515 (DeviceMO)
	[Category]
	[BaseType (typeof(DeviceMO))]
	interface DeviceMO_Encryption_Swift_515
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int16_t key_f;
		[Export ("key_f")]
		short Key_f { get; set; }

		// @property (nonatomic) int64_t last_seen;
		[Export ("last_seen")]
		long Last_seen { get; set; }

		// @property (nonatomic) int16_t master_f;
		[Export ("master_f")]
		short Master_f { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable model_number;
		[NullAllowed, Export ("model_number")]
		string Model_number { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_key;
		[NullAllowed, Export ("public_key")]
		string Public_key { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }

		// @property (nonatomic) int64_t version;
		[Export ("version")]
		long Version { get; set; }
	}

	// @interface EmojiMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface EmojiMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_541 (EmojiMO)
	[Category]
	[BaseType (typeof(EmojiMO))]
	interface EmojiMO_Encryption_Swift_541
	{
		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable decode;
		[NullAllowed, Export ("decode")]
		string Decode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable emoji_group;
		[NullAllowed, Export ("emoji_group")]
		string Emoji_group { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable hex_code;
		[NullAllowed, Export ("hex_code")]
		string Hex_code { get; set; }

		// @property (nonatomic) int16_t id;
		[Export ("id")]
		short Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable version;
		[NullAllowed, Export ("version")]
		string Version { get; set; }
	}

	// @interface Encryption : NSObject
	[BaseType (typeof(NSObject))]
	interface Encryption
	{
		// -(NSString * _Nonnull)loginWithThirdPartyToken:(NSString * _Nonnull)thirdPartyToken thirdServiceId:(NSString * _Nonnull)thirdServiceId userId:(NSString * _Nonnull)userId __attribute__((warn_unused_result("")));
		[Export ("loginWithThirdPartyToken:thirdServiceId:userId:")]
		string LoginWithThirdPartyToken (string thirdPartyToken, string thirdServiceId, string userId);

		// -(NSString * _Nonnull)sendTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds text:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
		[Export ("sendTextWithToken:thirdPartyId:userIds:text:")]
		string SendTextWithToken (string token, string thirdPartyId, string[] userIds, string text);

		// -(NSString * _Nonnull)getTextWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
		[Export ("getTextWithToken:thirdPartyId:")]
		string GetTextWithToken (string token, string thirdPartyId);

		// -(NSString * _Nonnull)sendFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds buffer:(NSString * _Nonnull)buffer __attribute__((warn_unused_result("")));
		[Export ("sendFileWithToken:thirdPartyId:userIds:buffer:")]
		string SendFileWithToken (string token, string thirdPartyId, string[] userIds, string buffer);

		// -(NSString * _Nonnull)getFileWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId __attribute__((warn_unused_result("")));
		[Export ("getFileWithToken:thirdPartyId:")]
		string GetFileWithToken (string token, string thirdPartyId);

		// -(NSString * _Nonnull)updatePermissionWithToken:(NSString * _Nonnull)token thirdPartyId:(NSString * _Nonnull)thirdPartyId userIds:(NSArray<NSString *> * _Nonnull)userIds __attribute__((warn_unused_result("")));
		[Export ("updatePermissionWithToken:thirdPartyId:userIds:")]
		string UpdatePermissionWithToken (string token, string thirdPartyId, string[] userIds);

		// -(NSString * _Nonnull)backupWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
		[Export ("backupWithToken:")]
		string BackupWithToken (string token);

		// -(NSString * _Nonnull)restoreWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
		[Export ("restoreWithToken:")]
		string RestoreWithToken (string token);

		// -(NSString * _Nonnull)logoutWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
		[Export ("logoutWithToken:")]
		string LogoutWithToken (string token);
	}

	// @interface ErrorMessageRetryMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface ErrorMessageRetryMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_579 (ErrorMessageRetryMO)
	[Category]
	[BaseType (typeof(ErrorMessageRetryMO))]
	interface ErrorMessageRetryMO_Encryption_Swift_579
	{
		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t retry;
		[Export ("retry")]
		short Retry { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source_id;
		[NullAllowed, Export ("source_id")]
		string Source_id { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }
	}

	// @interface ErrorMessageSendNullMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface ErrorMessageSendNullMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_603 (ErrorMessageSendNullMO)
	[Category]
	[BaseType (typeof(ErrorMessageSendNullMO))]
	interface ErrorMessageSendNullMO_Encryption_Swift_603
	{
		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t retry;
		[Export ("retry")]
		short Retry { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }
	}

	// @interface GroupMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface GroupMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_627 (GroupMO)
	[Category]
	[BaseType (typeof(GroupMO))]
	interface GroupMO_Encryption_Swift_627
	{
		// @property (copy, nonatomic) NSString * _Nullable avatar_id;
		[NullAllowed, Export ("avatar_id")]
		string Avatar_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable created_by;
		[NullAllowed, Export ("created_by")]
		string Created_by { get; set; }

		// @property (nonatomic) int16_t display_state;
		[Export ("display_state")]
		short Display_state { get; set; }

		// @property (nonatomic) int16_t encryption_f;
		[Export ("encryption_f")]
		short Encryption_f { get; set; }

		// @property (nonatomic) int16_t group_type;
		[Export ("group_type")]
		short Group_type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t private_f;
		[Export ("private_f")]
		short Private_f { get; set; }

		// @property (nonatomic) int64_t seen_time;
		[Export ("seen_time")]
		long Seen_time { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }
	}

	// @interface GroupSettingMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface GroupSettingMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_654 (GroupSettingMO)
	[Category]
	[BaseType (typeof(GroupSettingMO))]
	interface GroupSettingMO_Encryption_Swift_654
	{
		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable setting_id;
		[NullAllowed, Export ("setting_id")]
		string Setting_id { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }
	}

	// @interface IdentityKeyMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface IdentityKeyMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_677 (IdentityKeyMO)
	[Category]
	[BaseType (typeof(IdentityKeyMO))]
	interface IdentityKeyMO_Encryption_Swift_677
	{
		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (nonatomic) int32_t id;
		[Export ("id")]
		int Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_key;
		[NullAllowed, Export ("public_key")]
		string Public_key { get; set; }
	}

	// @interface MessageMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface MessageMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_693 (MessageMO)
	[Category]
	[BaseType (typeof(MessageMO))]
	interface MessageMO_Encryption_Swift_693
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (nonatomic) int16_t call_status;
		[Export ("call_status")]
		short Call_status { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable content;
		[NullAllowed, Export ("content")]
		string Content { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable content_decode;
		[NullAllowed, Export ("content_decode")]
		string Content_decode { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mentions;
		[NullAllowed, Export ("mentions")]
		string Mentions { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable parent_id;
		[NullAllowed, Export ("parent_id")]
		string Parent_id { get; set; }

		// @property (nonatomic) int16_t send_type;
		[Export ("send_type")]
		short Send_type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sender_device_id;
		[NullAllowed, Export ("sender_device_id")]
		string Sender_device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sender_id;
		[NullAllowed, Export ("sender_id")]
		string Sender_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source_id;
		[NullAllowed, Export ("source_id")]
		string Source_id { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable third_party_id;
		[NullAllowed, Export ("third_party_id")]
		string Third_party_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable thread_id;
		[NullAllowed, Export ("thread_id")]
		string Thread_id { get; set; }
	}

	// @interface NotificationMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface NotificationMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_729 (NotificationMO)
	[Category]
	[BaseType (typeof(NotificationMO))]
	interface NotificationMO_Encryption_Swift_729
	{
		// @property (copy, nonatomic) NSString * _Nullable branch_id;
		[NullAllowed, Export ("branch_id")]
		string Branch_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable content;
		[NullAllowed, Export ("content")]
		string Content { get; set; }

		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable from_account_id;
		[NullAllowed, Export ("from_account_id")]
		string From_account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable from_device_id;
		[NullAllowed, Export ("from_device_id")]
		string From_device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable from_group_id;
		[NullAllowed, Export ("from_group_id")]
		string From_group_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mentions;
		[NullAllowed, Export ("mentions")]
		string Mentions { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable notice_to_account_id;
		[NullAllowed, Export ("notice_to_account_id")]
		string Notice_to_account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable notice_to_device_id;
		[NullAllowed, Export ("notice_to_device_id")]
		string Notice_to_device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable parent;
		[NullAllowed, Export ("parent")]
		string Parent { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }

		// @property (nonatomic) int16_t status;
		[Export ("status")]
		short Status { get; set; }

		// @property (nonatomic) int16_t type;
		[Export ("type")]
		short Type { get; set; }
	}

	// @interface OneTimePreKeysMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface OneTimePreKeysMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_759 (OneTimePreKeysMO)
	[Category]
	[BaseType (typeof(OneTimePreKeysMO))]
	interface OneTimePreKeysMO_Encryption_Swift_759
	{
		// @property (nonatomic) int64_t id;
		[Export ("id")]
		long Id { get; set; }

		// @property (nonatomic) int64_t key_id;
		[Export ("key_id")]
		long Key_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable private_key;
		[NullAllowed, Export ("private_key")]
		string Private_key { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_key;
		[NullAllowed, Export ("public_key")]
		string Public_key { get; set; }
	}

	// @interface SenderKeySharedMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface SenderKeySharedMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_777 (SenderKeySharedMO)
	[Category]
	[BaseType (typeof(SenderKeySharedMO))]
	interface SenderKeySharedMO_Encryption_Swift_777
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (nonatomic) int64_t id;
		[Export ("id")]
		long Id { get; set; }
	}

	// @interface SenderKeysMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface SenderKeysMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_795 (SenderKeysMO)
	[Category]
	[BaseType (typeof(SenderKeysMO))]
	interface SenderKeysMO_Encryption_Swift_795
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (nonatomic) int64_t created_at;
		[Export ("created_at")]
		long Created_at { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (nonatomic) int64_t id;
		[Export ("id")]
		long Id { get; set; }

		// @property (nonatomic) int64_t index_send_number;
		[Export ("index_send_number")]
		long Index_send_number { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable record;
		[NullAllowed, Export ("record")]
		string Record { get; set; }
	}

	// @interface SessionsMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface SessionsMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_816 (SessionsMO)
	[Category]
	[BaseType (typeof(SessionsMO))]
	interface SessionsMO_Encryption_Swift_816
	{
		// @property (copy, nonatomic) NSString * _Nullable account_id;
		[NullAllowed, Export ("account_id")]
		string Account_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device_id;
		[NullAllowed, Export ("device_id")]
		string Device_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group_id;
		[NullAllowed, Export ("group_id")]
		string Group_id { get; set; }

		// @property (nonatomic) int64_t id;
		[Export ("id")]
		long Id { get; set; }

		// @property (nonatomic) int64_t index_send_number;
		[Export ("index_send_number")]
		long Index_send_number { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable record;
		[NullAllowed, Export ("record")]
		string Record { get; set; }
	}

	// @interface SettingMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface SettingMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_833 (SettingMO)
	[Category]
	[BaseType (typeof(SettingMO))]
	interface SettingMO_Encryption_Swift_833
	{
		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable descriptions;
		[NullAllowed, Export ("descriptions")]
		string Descriptions { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (nonatomic) int16_t object_type;
		[Export ("object_type")]
		short Object_type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable options;
		[NullAllowed, Export ("options")]
		string Options { get; set; }

		// @property (nonatomic) int16_t setting_type;
		[Export ("setting_type")]
		short Setting_type { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }
	}

	// @interface SignedPreKeysMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface SignedPreKeysMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_856 (SignedPreKeysMO)
	[Category]
	[BaseType (typeof(SignedPreKeysMO))]
	interface SignedPreKeysMO_Encryption_Swift_856
	{
		// @property (nonatomic) int64_t id;
		[Export ("id")]
		long Id { get; set; }

		// @property (nonatomic) int64_t key_id;
		[Export ("key_id")]
		long Key_id { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable private_key;
		[NullAllowed, Export ("private_key")]
		string Private_key { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable public_key;
		[NullAllowed, Export ("public_key")]
		string Public_key { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable signature;
		[NullAllowed, Export ("signature")]
		string Signature { get; set; }

		// @property (nonatomic) int64_t timestamp;
		[Export ("timestamp")]
		long Timestamp { get; set; }
	}

	// @interface TextSearchMO : NSManagedObject
	[BaseType (typeof(NSManagedObject))]
	interface TextSearchMO
	{
		// -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
	}

	// @interface Encryption_Swift_874 (TextSearchMO)
	[Category]
	[BaseType (typeof(TextSearchMO))]
	interface TextSearchMO_Encryption_Swift_874
	{
		// @property (nonatomic) int64_t created;
		[Export ("created")]
		long Created { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) int64_t modified;
		[Export ("modified")]
		long Modified { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable search_history;
		[NullAllowed, Export ("search_history")]
		string Search_history { get; set; }

		// @property (nonatomic) int16_t state;
		[Export ("state")]
		short State { get; set; }
	}
}
