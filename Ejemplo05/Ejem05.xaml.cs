namespace Ejemplo05;

public partial class Ejem05 : ContentPage
{
	public Ejem05()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		(sender as Button).Text = "Presioname de nuevo";
    }
}