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

		public App()
		{
			MainPage = new LoginPage();
		}


        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<LoginPage>();
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<ClientListPage>();
			Container.RegisterTypeForNavigation<ClientDetailPage>();
			Container.RegisterTypeForNavigation<ProductListPage>();
			Container.RegisterTypeForNavigation<ProductDetailPage>();

			Container.RegisterInstance(Acr.UserDialogs.UserDialogs.Instance);

        }
    }
}
