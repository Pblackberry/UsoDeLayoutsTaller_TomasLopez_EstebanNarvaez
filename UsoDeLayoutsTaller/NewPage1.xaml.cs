namespace UsoDeLayoutsTaller;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void Boton2_Clicked(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }
}