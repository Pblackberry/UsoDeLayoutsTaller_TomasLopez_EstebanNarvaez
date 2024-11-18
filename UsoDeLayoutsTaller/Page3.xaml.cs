namespace UsoDeLayoutsTaller;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}