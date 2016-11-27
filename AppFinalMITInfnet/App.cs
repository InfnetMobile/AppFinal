using Prism.Unity;
using Microsoft.Practices.Unity;
using AppFinalMITInfnet.Views;
using System.Net.Http;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace AppFinalMITInfnet
{
    public class App : PrismApplication
    {
        public static SQLite.SQLiteConnection dbConn;
        public static HttpClient HttpClientInstance;
        public static bool IsConnected;

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
			Container.RegisterInstance(Acr.UserDialogs.UserDialogs.Instance);

			Container.RegisterType<IApiService<RootObject>, ApiService<RootObject>>();
			Container.RegisterType<IBaseApplicationService<User>, BaseApplicationService<User>>();
			Container.RegisterType<IBaseApplicationService<Result>, BaseApplicationService<Result>>();

            Container.RegisterTypeForNavigation<LoginPage>();
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<ClientListPage>();
			Container.RegisterTypeForNavigation<ClientDetailPage>();
			Container.RegisterTypeForNavigation<ProductListPage>();
			Container.RegisterTypeForNavigation<ProductDetailPage>();

        }
    }
}
