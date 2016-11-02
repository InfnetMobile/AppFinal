using Prism.Unity;
using Microsoft.Practices.Unity;
using AppFinalMITInfnet.Views;
using System.Net.Http;
using Acr.UserDialogs;

namespace AppFinalMITInfnet
{
    public class App : PrismApplication
    {
        public static SQLite.SQLiteConnection dbConn;
        public static HttpClient HttpClientInstance;
        public static bool IsConnected;

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("ClientListPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<LoginPage>();
        }
    }
}
