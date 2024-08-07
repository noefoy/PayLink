namespace PayLink2;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        // Handle register logic here
        // For example, navigate to the Main Page page
        Navigation.PushAsync(new MainPage());
    }
}
