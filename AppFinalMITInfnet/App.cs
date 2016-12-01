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
            //NavigationService.NavigateAsync("ClientListPage");
			//trocado a primeira pagina para o login
			NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
			//adicionado userdialogs
			Container.RegisterInstance<IUserDialogs>(UserDialogs.Instance);


            Container.RegisterTypeForNavigation<LoginPage>();

			//adicionado as outras views na navegação
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<ClientListPage>();
			Container.RegisterTypeForNavigation<ClientDetailPage>();
			Container.RegisterTypeForNavigation<ProductDetailPage>();
			Container.RegisterTypeForNavigation<ProductListPage>();


			//adicionada container da base
			Container.RegisterType<IBaseApplicationService<User>, BaseApplicationService<User>>();
			Container.RegisterType<IBaseApplicationService<Result>, BaseApplicationService<Result>>();
			Container.RegisterType<IBaseRepository<User>, BaseRepository<User>>();
			Container.RegisterType<IBaseRepository<Result>, BaseRepository<Result>>();

			//adicionado root object
			Container.RegisterType<IApiService<RootObject>, ApiService<RootObject>>();

        }
    }
}
