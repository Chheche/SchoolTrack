using Microsoft.VisualBasic;

namespace ProjetDevTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(Profile), typeof(Profile));
            Routing.RegisterRoute(nameof(Information), typeof(Information));
        }
    }
}
