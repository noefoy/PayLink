using Microsoft.Maui.Controls;

namespace PayLink2
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            // Handle login logic here
            // For example, navigate to the main page
            Navigation.PushAsync(new MainPage());
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            // Handle register logic here
            // For example, navigate to the registration page
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}
