using ZodiApp.Views;

namespace ZodiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage1());
        }
    }
}
