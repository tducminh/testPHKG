
// xamarin
//using sdk;

// ios
using Binding;

// android
using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private string tag = "anhnd";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
            
            //CounterBtn.Text = LoginBySdkWrapper();
            CounterBtn.Text = LoginBySdkNative();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private string LoginBySdkWrapper()
        {
            //Sdk sdk = DependencyService.Get<Sdk>();
            //string s;

            //if (sdk != null)
            //{
            //    s = sdk.Login();
            //}
            //else
            //{
            //    s = "sdk is null";
            //}

            //return s;

            return "";
        }

        private string LoginBySdkNative()
        {
            try
            {
                //IEncryption encryption = EncryptionManager.Create();
                //string s = encryption.Login("user_id");

                var proxy = new TriosProxy();
                string s = "";
                s = proxy.InitFor;

                return s;

                //return "";
            }
            catch (Exception e)
            {
                return "proxy null";
            }
        }
    }
}
