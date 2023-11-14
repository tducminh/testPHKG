


[assembly: Dependency(typeof(sdk.SdkImpl))]
namespace sdk
{
    // All the code in this file is only included on iOS.
    public class SdkImpl : Sdk
    {
       
        public SdkImpl()
        {
            
        }

        public void Init()
        {
            
        }

        string Sdk.Login()
        {
            throw new NotImplementedException();
        }
        string Sdk.UploadFile()
        {
            throw new NotImplementedException();
        }

        string Sdk.GetFile()
        {
            throw new NotImplementedException();
        }

        string Sdk.UpdatPermission()
        {
            throw new NotImplementedException();
        }

        string Sdk.BackUp()
        {
            throw new NotImplementedException();
        }

        string Sdk.Restore()
        {
            throw new NotImplementedException();
        }
    }
}
