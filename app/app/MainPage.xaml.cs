namespace app
{
    public partial class MainPage : ContentPage
    {
        private string tag = "anhnd";
        private Encryption encryption = new Encryption();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.Login();
            }
            else
            {
                s = "encryption is null";
            }

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }

        private void UploadFile(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.UploadFile();
            }
            else
            {
                s = "encryption is null";
            }

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }

        private void GetFile(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.GetFile();
            }
            else
            {
                s = "encryption is null";
            }

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }

        private void UpdatePermission(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.UpdatePermission();
            }
            else
            {
                s = "encryption is null";
            }

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }

        private void BackUp(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.BackUp();
            }
            else
            {
                s = "encryption is null";
            }

            LabelContent.Text = s;
            SemanticScreenReader.Announce(LabelContent.Text);
        }

        private void Restore(object sender, EventArgs e)
        {
            string s;

            if (encryption != null)
            {
                s = encryption.Restore();
            }
            else
            {
                s = "encryption is null";
            }

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
