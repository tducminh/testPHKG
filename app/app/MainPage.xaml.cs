using Com.Bglobal.Publish;

namespace app
{
    public partial class MainPage : ContentPage
    {
        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pbmh0dXllbiIsIm5iZiI6MTcwMjQ1NjkyNiwiZXhwIjoxNzAyNTQzOTI2LCJpYXQiOjE3MDI0NTY5MjYsImlzcyI6ImlvaXQiLCJhdWQiOiJiZ2xvYmFsIn0.EF2z3IuCsQX0G3ew3S-3WOTYVn1CnXHdd5iUJRpuZiWdL8A91oCIcuTBwF3m5RVkTQM56KtJGH-vIaUH8cZEDTBG0cag-wGpN77gg5ltEVEmPkfZazbLqfrHN98uX0pjEwQqpAjwlmqRk6WmDqVYRoLzdOjM03cigmlpcqjAixnuvm2pEJjsxmaEIq-n8gpHikGQROkJr_kiFZTez8ZSHOu1Qea7x5vC9ftYrMI1Iarhjbl3bWkt1oSkteZEhQ3lRt2NL26a67C27nrB6NgKGXoO-il_upegqCCt7u2QBSpAthCOicMCQNNt3EjYn8s1sREcBXVIYiPrmxRPwSNN1w";
        private const String THIRD_SERVICE_ID = "1";

        private IEncryption sdk = EncryptionManager.Create();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Login(THIRD_PARTY_TOKEN, THIRD_SERVICE_ID, "my_user_name");

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Logout();

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
                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = { "user_1", "user_2" };
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
                string token = "eyJhbGciOiJSUzI1NiJ9......";
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
                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = { "user_1", "user_2" };
                byte[] bytes = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                string s = sdk.SendFile(token, thirdPartyId, array, bytes);

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
                string token = "eyJhbGciOiJSUzI1NiJ9......";
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
            try
            {
                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = { "user_1", "user_2" };
                string s = sdk.UpdatePermission(token, thirdPartyId, array);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void BackUp(object sender, EventArgs e)
        {
            try
            {
                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string s = sdk.Backup(token);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void Restore(object sender, EventArgs e)
        {
            try
            {
                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string s = sdk.Restore(token);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }


        private void FunctionSDKTest(object sender, EventArgs e)
        {
            string s = sdk.FunctionSDKTest("test response data");

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }


        private void Clear(object sender, EventArgs e)
        {
            LabelContent.Text = "this is logcat !!";
            SemanticScreenReader.Announce(LabelContent.Text);
        }
    }
}
