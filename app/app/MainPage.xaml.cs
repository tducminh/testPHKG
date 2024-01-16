using sdk;
using System;
using Newtonsoft.Json;

namespace app
{
    public partial class MainPage : ContentPage
    {
        private string SDKToken
        {
            get { return Preferences.Get(nameof(SDKToken), ""); }
            set { Preferences.Set(nameof(SDKToken), value); }
        }

        private string SDKAccount
        {
            get { return Preferences.Get(nameof(SDKAccount), ""); }
            set { Preferences.Set(nameof(SDKAccount), value); }
        }

        private const String THIRD_SERVICE_ID = "1";
        private static readonly Dictionary<string, string> accounts = new Dictionary<string, string> { { "vietduc110", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InZpZXRkdWMxMTAiLCJuYmYiOjE3MDI0NTY5MjYsImV4cCI6MTgwMjU0MzkyNiwiaWF0IjoxNzAyNDU2OTI2LCJpc3MiOiJpb2l0IiwiYXVkIjoiYmdsb2JhbCJ9.K72E_b2k78pIUzNjK_V-RDxoBq0iHSWlC8Bs_ANckDqFraDbqj-IEcRBx3WJO0BfOB62fIx9rs_21GrAEIsbvP6J32ieRscT3uCwBFH6gMvOkL6t9fLh-Rrq5iwoc3nfVen79YI2Apr3y172RrcHdiFZLblmfy3lljg6EZPUoQuk0-vidX7cwJJZARFI9uEOZl7gBYT8iQKvPRJTP0L4rbkLhAWKOlxxTPGzPr_guvMZkQu7ASr2z7YIKygTXBq1EXM3qpIg5o5r8r006M0ima-tibHujLz50KZz6PeXnPXIcTLrq0_UnIWj0XGuA1Yv9tVnFEsmPhfYTUdjzSK2Ew" }, { "vietduc111", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InZpZXRkdWMxMTEiLCJuYmYiOjE3MDI0NTY5MjYsImV4cCI6MTgwMjU0MzkyNiwiaWF0IjoxNzAyNDU2OTI2LCJpc3MiOiJpb2l0IiwiYXVkIjoiYmdsb2JhbCJ9.P9px-Ed0TQTQd1ILp-dYTNhvk0RhspUOxYYv3-_aTbgVfcK6vejn63Vr7zklPIv1d_vKI3cAnkdZFWu0nxe6OHVlSU64-n6oQ1hm81O9kPwKvp_Gb1RlPdoh1j_YCGE5-99pb95Hkmg8N-iwBrbg2ny5CNWguTLsmxye7Z8IXjlHRMR5yroHcb1aMnFSTMh1_U97DrXqZaOKKccrl23nFNvcpiXbbcusUlb-b8pYjjnKqLWnyhiwt7MR_dAOSqXFoyYQc9jabvYd1FjrpjbmbxAlAdJ4q_Mw8iSz7mCpJcAzAVVbHbZ_GYunDAxgiMED-ydY1ZhnGdPauZrGs5tkZw" } };

        private SDK sdk = new SDK();

        public MainPage()
        {
            InitializeComponent();
        }



        private void CheckTokenExist(object sender, EventArgs e)
        {
            try
            {

                labelToken.Text = SDKToken;
                SemanticScreenReader.Announce(labelToken.Text);
            }
            catch (Exception ex)
            {
                labelToken.Text = ex.StackTrace;
                SemanticScreenReader.Announce(labelToken.Text);
            }
        }

        private void CheckAccountExist(object sender, EventArgs e)
        {
            try
            {

                edtAccount.Text = SDKAccount;
                SemanticScreenReader.Announce(labelToken.Text);
            }
            catch (Exception ex)
            {
                edtAccount.Text = ex.StackTrace;
                SemanticScreenReader.Announce(labelToken.Text);
            }
        }


        private void SDKLogin(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Login(accounts[edtAccount.Text], THIRD_SERVICE_ID, edtAccount.Text);

                var response = JsonConvert.DeserializeObject<AuthResponse>(s);
                SDKToken = response.token;

                LabelContent.Text = SDKToken;
                SDKAccount = edtAccount.Text;
                SemanticScreenReader.Announce(LabelContent.Text);
                SemanticScreenReader.Announce(labelToken.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void SDKLogout(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.Logout();

                LabelContent.Text = s;
                SemanticScreenReader.Announce(LabelContent.Text);
                SemanticScreenReader.Announce(labelToken.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private async void SDKSendFile(object sender, EventArgs e)
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
                string fileId = Guid.NewGuid().ToString();

                LabelSendId.Text = fileId;
                string[] array = { edtReceiveAccount.Text };
                string s = sdk.SendFile(SDKToken, fileId, array, ret);
                LabelContent.Text = s;

                SemanticScreenReader.Announce(LabelContent.Text);
                SemanticScreenReader.Announce(labelToken.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        private byte[] ConvertStreamToByteArray(Stream stream)
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

        private void SDKGetFile(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.GetFile(SDKToken, edtGetId.Text);

                LabelContent.Text = s;

                SemanticScreenReader.Announce(labelToken.Text);
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }

        private void SDKSendText(object sender, EventArgs e)
        {
            try
            {
                string thirdPartyId = Guid.NewGuid().ToString();

                LabelSendId.Text = thirdPartyId;
                string[] array = { edtReceiveAccount.Text };
                string s = sdk.SendText(SDKToken, thirdPartyId, array, "Text send");
                LabelContent.Text = s;

                SemanticScreenReader.Announce(labelToken.Text);
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        private void SDKGetText(object sender, EventArgs e)
        {
            try
            {
                string s = sdk.GetText(SDKToken, edtGetId.Text);

                LabelContent.Text = s;
                SemanticScreenReader.Announce(labelToken.Text);
                SemanticScreenReader.Announce(LabelContent.Text);
            }
            catch (Exception ex)
            {
                LabelContent.Text = ex.StackTrace;
                SemanticScreenReader.Announce(LabelContent.Text);
            }
        }
    }
}


