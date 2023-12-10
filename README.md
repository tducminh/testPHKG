# Android Encryption SDK
## I. Introduction to SDK
##### Change log 1.0.1:
1. Function `Login`
2. Function `Send Text`
3. Function `Get Text`

##### Change log 1.0.0:
- Function design
- Mock data
  

## II. SDK Setup
### 1. Resource
1. Add Dependencies:
 `android`: (SDK\android\net7.0-android\androidSDK.dll)

[![Image from Gyazo](https://i.gyazo.com/fe0211198d11bde8015e5ed74fc5c155.jpg)](https://gyazo.com/fe0211198d11bde8015e5ed74fc5c155)


### 2. Install the SDK

- Initial
In  `MainApplication.cs`

```c#
using Com.Bglobal.Publish;

...
public MainApplication(IntPtr handle, JniHandleOwnership ownership) 
    : base(handle, ownership)
{
    var context = Android.App.Application.Context;
    EncryptionManager.Init(context);
}
```
  
- Create instance
```c#
using Com.Bglobal.Publish;

...
namespace app
{
    public partial class MainPage : ContentPage
    {

        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJkdWN0cmFuIiwicm9sZXMiOltdLCJpYXQiOjE3MDEyNDA0MTAsImV4cCI6MTcwMzgzMjQxMH0.yjuYx4TRBHx-_TYL9AB0FhGE0qhef_tBVDFlyktAYumkcQkBcep9MypZAd-aK1x2mIHX8EBMDk2JbISLeVIiJvZUPbmchoy1xlxlJlW5c8MAb4dF27TcYV5CEZT7fhowzRJlJ1XXzARpbI9cPWpqG1ck7Y-_Wil_BlFvj_dkEdW581qhwzdz8kbemK-x1R8EXYupbIIBZfPv6Z2DUoSnSAlcVnmIwKdzr6_H73BLM5t5j0PI0PY33kQDwDoWNMFzTI5AJcdxBh6iHuYzmJdw1k927yJFKvVIQ44ToJ-QSqIUFIG8yh5Au1xJrOc59rArbUmtCDKJ5YEXrVotv0J3AQ";

        private const String THIRD_SERVICE_ID = "1";

        private IEncryption sdk = EncryptionManager.Create();

...
    }
}

```
  

## III. SDK Integration

After importing enough resources, configure we start coding:

### 1. Calling functions

 - Login
```c#
private void Login()
{
    try
    {
        string s = sdk.Login(THIRD_PARTY_TOKEN, THIRD_SERVICE_ID, "user_name");
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- Send Text
```c#
private void SendText()
{
    try
    {
        // token response by sdk
        string token = "";
        
        // UUID generate
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
        
        // user_id array
        string[] array = {"user_id"};
        
        // content
        string content = "nội dung cần mã hoá";
        
        string s = sdk.SendText(token, thirdPartyId, array, content);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- Get Text
```c#
private void GetText()
{
    try
    {
        // token response by sdk
        string token = "";
        
        // UUID generate when send text
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
        string s = sdk.GetText(token, thirdPartyId);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```


### 3. Licenses


All information is copyright of [Bglobalcorp](https://bglobalcorp.com/)
