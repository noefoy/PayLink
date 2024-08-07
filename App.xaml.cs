using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

namespace PayLink2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            var navigation = new NavigationPage(new LoginPage());
            MainPage = navigation;
            navigation.Pushed += OnPagePushed;
            navigation.Popped += OnPagePopped;
        }

        void OnPagePushed(object sender, NavigationEventArgs e)
        {
            // Add custom animation for page push
            if (e.Page != null)
            {
                e.Page.TranslationX = 500;
                e.Page.TranslateTo(0, 0, 500, Easing.CubicOut);
            }
        }

        void OnPagePopped(object sender, NavigationEventArgs e)
        {
            // Add custom animation for page pop
            if (e.Page != null)
            {
                e.Page.TranslationX = 0;
                e.Page.TranslateTo(500, 0, 500, Easing.CubicIn);
            }
        }
    }
}
