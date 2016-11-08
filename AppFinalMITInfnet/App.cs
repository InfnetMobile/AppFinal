﻿using Prism.Unity;
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
            Container.RegisterTypeForNavigation<ClientDetailPage>();
            Container.RegisterTypeForNavigation<ClientListPage>();
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<ProductDetailPage>();
            Container.RegisterTypeForNavigation<ProductListPage>();
        }
    }
}
