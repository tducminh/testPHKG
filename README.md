# Android Encryption SDK
## I. Introduction to SDK
This library encryption E2EE

## II. Introduction to SDK
##### Change log 1.0.3:
1. Function `Update Permission`
2. Function `Backup`
3. Function `Restore`
4. Function `Logout`

##### Change log 1.0.2:
1. Function `Send File`
2. Function `Get File`

##### Change log 1.0.1:
1. Function `Login`
2. Function `Send Text`
3. Function `Get Text`

##### Change log 1.0.0:
- Function design
- Mock data

## III. SDK Setup
### 1. Resource
1. Add Dependencies:
   `android`: (SDK\android\net7.0-android\androidSDK.dll)

[![Image from Gyazo](https://i.gyazo.com/fe0211198d11bde8015e5ed74fc5c155.jpg)](https://gyazo.com/fe0211198d11bde8015e5ed74fc5c155)

2. Implemention library in xamarain
```cs
<PackageReference Include="Xamarin.AndroidX.Preference" Version="1.2.1.3" />
<PackageReference Include="Xamarin.Square.OkHttp3" Version="3.14.2" />
<PackageReference Include="Xamarin.Android.ReactiveX.RxAndroid" Version="2.1.1.8" />
<PackageReference Include="Xamarin.Android.ReactiveX.RxJava" Version="2.2.21.15" />
<PackageReference Include="Xamarin.Android.ReactiveX.RxKotlin" Version="2.4.0.8" />
<PackageReference Include="Xamarin.Protobuf.JavaLite" Version="3.24.4" />
```

### 2. Install the SDK

- Initial
  In  `MainApplication.cs`

```cs
using Com.Bglobal.Publish;

...
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
           : base(handle, ownership)
        {
            ...
            var context = Android.App.Application.Context;
            EncryptionManager.Init(context);
        }
    }
```

- Create instance
```cs
using Com.Bglobal.Publish;

...
namespace app
{
    public partial class MainPage : ContentPage
    {
        ...
        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiJ9......";
        private const String THIRD_SERVICE_ID = "1";
        private IEncryption sdk = EncryptionManager.Create();
    }
}

```


## IV. SDK Integration

After importing enough resources, configure we start coding:

### 1. Calling functions
- `Login`
```cs
private void Login()
{
    try
    {
        string s = sdk.Login(THIRD_PARTY_TOKEN, THIRD_SERVICE_ID, "my_user_name");
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- `Logout`
```cs
private void Logout()
{
    try
    {
        string s = sdk.Logout();
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- `Send Text`
```cs
private void SendText()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";
        
        // UUID generate
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
        
        // username list
        string[] array = { "user_name_1", "user_name_2" };
        
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

- `Get Text`
```cs
private void GetText()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";
        
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

- `Send File`
```cs
private void SendFile()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";
        
        // UUID generate
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
        
        // username list
        string[] array = { "user_name_1", "user_name_2" };
        
        // file convert to byte array
        byte[] bytes = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
        
        string s = sdk.SendFile(token, thirdPartyId, array, bytes);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- `Get File`
```cs
private void GetFile()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";
        
        // UUID generate when send file
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";

        string s = sdk.GetFile(token, thirdPartyId);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```


- `Update Permission`
```cs
private void UpdatePermimssion()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";

        // UUID generate when send text/file
        string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";

        // username list
        string[] array = { "user_name_1", "user_name_2" };

        string s = sdk.UpdatePermission(token, thirdPartyId, array);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- `Backup`
```cs
private void Backup()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";

        string s = sdk.Backup(token);

    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```

- `Restore`
```cs
private void Restore()
{
    try
    {
        // token response by sdk
        string token = "eyJhbGciOiJSUzI1NiJ9......";
        
        string s = sdk.Restore(token);
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }
}
```


## V. Licenses
All information is copyright of [Bglobalcorp](https://bglobalcorp.com/)
