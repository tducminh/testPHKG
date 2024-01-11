using sdk;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFuaG5kMjUiLCJuYmYiOjE3MDIzOTc1NzMsImV4cCI6MTgwMjY1ODM5OCwiaWF0IjoxNzAyMzk3NTczLCJpc3MiOiJpb2l0IiwiYXVkIjoiYmdsb2JhbCJ9.KCE-gLcgdmE1VTdIwtNca23YU5ujH1CBD1jv3AvxaGp5c36d4up5gmK7rGKi4qQOhgIBDpcwwvJ1tuD8c4deCQrBNA0h6ANHJkJxqqRoE8G2HAH_rI2foRnloxC7GscaOV4uoZPe5KNBwag8VTkSW3qZbsSxxtL-y7AiLyq7ZtCLPmnId_hc2q0eyqs_q3dr-3qmq9fhrIy3sB3RGOrcnM43u-PWgtf5i8FdPt6hjSJ_Hpihkz2_DXEzWzZZiN3eiRJA0l5mW9BTYBa-yGi10zUKDSSGAxF9xf0xUzHh26JbfAe6T9l_M0nhB_GRnZvbkFjixcHSpEo36Cjn3cN9sQ";
        private const String THIRD_SERVICE_ID = "1";

        private SDK sdk = new SDK();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Login(THIRD_PARTY_TOKEN, THIRD_SERVICE_ID, "anhnd25");

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
                string content = "content to be encrypted";

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
                String s = sdk.GetFile(token, thirdPartyId);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            try
            {
                // token response by sdk
                string token = "eyJhbGciOiJSUzI1NiJ9......";

                // UUID generate when send text/file
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";

                string s = sdk.DeleteFile(token, thirdPartyId);
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
            try
            {
                string s = "data test......!";

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick file Please"
            });

            if (result == null)
                return;
            try
            {
                var stream = await result.OpenReadAsync();

                byte[] ret = ConvertStreamToByteArray(stream);
                filename.Text = result.FileName;
                string fileId = Guid.NewGuid().ToString();

                string token = "eyJhbGciOiJSUzI1NiJ9......";
                string thirdPartyId = "978f6e2a12b4406fbbab4def8c2f9100";
                string[] array = { "user_1", "user_2" };

                string s = sdk.SendFile(token, thirdPartyId, array, ret);

                LabelContent.Text = s;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");

            }
        }
        public static byte[] ConvertStreamToByteArray(this Stream stream)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }

            //string base64 = Convert.ToBase64String(bytes);
            return bytes;
        }
    }
}
