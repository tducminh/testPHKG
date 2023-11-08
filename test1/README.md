
  

# Android Encryption SDK

  

## I. Introduction to SDK

  

### Change log 1.0.0:
- Function design
- Mock data
  

## II. SDK Setup

  

### 1. Install the SDK

- Initial
In  `Application class`

```c#
public override void OnCreate()
{
    // ...
    EncryptionManager.Init(this); // <- initial
}
```
  
- Create instance
```c#
private IVptw vptw = EncryptionManager.Vptw();
```
  

## III. SDK Integration

After importing enough resources, configure we start coding:

### 1. Calling functions

 - Login
```c#
private void Login()
{
    string id = "user_id";
	
    VptwAuthInfo info = vptw.Login(id);
    int code = info.Code;
    string msg = info.Message;
    string token = info.Token;
}
```

- Upload File
```c#
private void UploadFile()
{
    string[] arr = { "user_id_1", "user_id_2" };
    string id = "attachment_d";
    string url = "local_url";
    
    EncryptionInfo info = vptw.UploadFile(id, arr, url);
    int code = info.Code;
    string msg = info.Message;
}
```

- Get File
```c#
private void GetFile()
{
    string id = "attachmentId";

    VptwFileInfo info = vptw.GetFile(id);
    int code = info.Code;
    string msg = info.Message;
    string url = info.Url;
}
```

- Update Permimssion
```c#
private void UpdatePermimssion()
{
    string id = "user_id";
    string[] arr = { "user_id_1", "user_id_2" };

    EncryptionInfo info = vptw.UpdatePermission(id, arr);
    int code = info.Code;
    string msg = info.Message;
}
```

- Backup
```c#
private void Backup()
{
    string id = "attachment_id";
    string passcode = "passcode";
    string url = "local_url";

    EncryptionInfo info = vptw.Backup(id, passcode, url);
    int code = info.Code;
    string msg = info.Message;
}
```

- Restore
```c#
private void Restore()
{
    string id = "attachment_id";
    string passcode = "passcode";

    VptwFileInfo info = vptw.Restore(id, passcode);
    int code = info.Code;
    string msg = info.Message;
    string url = info.Url;
}
```


### 3. Licenses


All information is copyright of [Bglobalcorp](https://bglobalcorp.com/)