using sdk;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private string tag = "anhnd";
        int count = 0;
        private Sdk sdk = new Sdk();


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var s = sdk.Login();

            CounterBtn.Text = s;

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
