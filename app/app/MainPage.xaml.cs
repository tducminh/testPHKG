using sdk;


namespace app
{
    public partial class MainPage : ContentPage
    {
        private const String THIRD_PARTY_TOKEN = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pbmh0dXllbiIsIm5iZiI6MTcwMjQ1NjkyNiwiZXhwIjoxNzAyNTQzOTI2LCJpYXQiOjE3MDI0NTY5MjYsImlzcyI6ImlvaXQiLCJhdWQiOiJiZ2xvYmFsIn0.EF2z3IuCsQX0G3ew3S-3WOTYVn1CnXHdd5iUJRpuZiWdL8A91oCIcuTBwF3m5RVkTQM56KtJGH-vIaUH8cZEDTBG0cag-wGpN77gg5ltEVEmPkfZazbLqfrHN98uX0pjEwQqpAjwlmqRk6WmDqVYRoLzdOjM03cigmlpcqjAixnuvm2pEJjsxmaEIq-n8gpHikGQROkJr_kiFZTez8ZSHOu1Qea7x5vC9ftYrMI1Iarhjbl3bWkt1oSkteZEhQ3lRt2NL26a67C27nrB6NgKGXoO-il_upegqCCt7u2QBSpAthCOicMCQNNt3EjYn8s1sREcBXVIYiPrmxRPwSNN1w";
        private const String THIRD_SERVICE_ID = "1";

        private SDK sdk = new SDK();

        public MainPage()
        {
            InitializeComponent();
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
    }
}
