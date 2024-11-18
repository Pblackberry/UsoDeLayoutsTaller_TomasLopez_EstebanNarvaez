namespace UsoDeLayoutsTaller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       
        private void Boton1_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
