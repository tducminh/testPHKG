using Com.Bglobal.Publish;
using Com.Bglobal.Publish.Encryption;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private string tag = "anhnd";
        //private Encryption encryption = new Encryption();

        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pbmh0dXllbiIsIm5iZiI6MTcwMjQzNjcwOSwiZXhwIjoxNzAyNTIzMTA5LCJpYXQiOjE3MDI0MzY3MDksImlzcyI6ImlvaXQiLCJhdWQiOiJiZ2xvYmFsIn0.xAn5pBKt930ozYRa47-qTTfeXmKDlCKtsNvk423nR7Zk_WwoWzqp9gjO6X_wr3u06jKx4JyPMKYtDLmVObQ-mdxAt8azIeWE9peR4S8vr8C9Mcp-0WObj7BDnfozkKsMce5WmyAAgiTAxxWQ_hWfNX_hIPhX9G0V_IZO2IKwQzgH8bSUjSk_nkHtfvzpWbaupL_CSdVj6nQJ5IiVZahNrSmv4CIgZz_5XfhE3UFjaELPS013bOKrBbYp3cadbj5nvcpgP8DQP2kpEY-9iMYqgRuLrOkSNbYyd2b0hInj6zp3a6mVi7KUsD9aS6A-DWU3i1spul89ZoWvbU-M_1PvnQ";
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
