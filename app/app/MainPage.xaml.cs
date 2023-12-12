using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private string tag = "anhnd";
        //private Encryption encryption = new Encryption();

        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiJ9.eyJzdWIiOiJkdWN0cmFuIiwicm9sZXMiOltdLCJpYXQiOjE3MDEyNDA0MTAsImV4cCI6MTcwMzgzMjQxMH0.yjuYx4TRBHx-_TYL9AB0FhGE0qhef_tBVDFlyktAYumkcQkBcep9MypZAd-aK1x2mIHX8EBMDk2JbISLeVIiJvZUPbmchoy1xlxlJlW5c8MAb4dF27TcYV5CEZT7fhowzRJlJ1XXzARpbI9cPWpqG1ck7Y-_Wil_BlFvj_dkEdW581qhwzdz8kbemK-x1R8EXYupbIIBZfPv6Z2DUoSnSAlcVnmIwKdzr6_H73BLM5t5j0PI0PY33kQDwDoWNMFzTI5AJcdxBh6iHuYzmJdw1k927yJFKvVIQ44ToJ-QSqIUFIG8yh5Au1xJrOc59rArbUmtCDKJ5YEXrVotv0J3AQ";
        private const String THIRD_SERVICE_ID = "1";

        private IEncryption sdk = EncryptionManager.Create();

        public MainPage()
        {
            InitializeComponent();
        }


        private void FunctionSDKTest(object sender, EventArgs e)
        {
            string s = sdk.FunctionSDKTest("test response data");

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }


        private void Login(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Login(THIRD_PARTY_TOKEN, THIRD_SERVICE_ID, "anhnd12");

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void SendText(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = {"anhnd11"};
                string content = "nội dung cần mã hoá";

                string s = sdk.SendText(token, thirdPartyId, array, content);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void GetText(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string s = sdk.GetText(token, thirdPartyId);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void SendFile(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = { "anhnd11" };
                string localPath = "đường dẫn tuyệt đối file cần mã trong mobile app";
                string s = sdk.SendFile(token, thirdPartyId, array, localPath);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void GetFile(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string s = sdk.GetFile(token, thirdPartyId);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void UpdatePermission(object sender, EventArgs e)
        {

        }

        private void BackUp(object sender, EventArgs e)
        {
            
        }

        private void Restore(object sender, EventArgs e)
        {
            
        }

        private void Clear(object sender, EventArgs e)
        {
            LabelContent.Text = "this is logcat !!";
            SemanticScreenReader.Announce(LabelContent.Text);
        }
    }
}
