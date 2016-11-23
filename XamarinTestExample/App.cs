using System;

using XamarinTestExample.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace XamarinTestExample
{
    public class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("HomePage");
        }

        protected override void RegisterTypes()
        {
            

            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<UserInfoConfirmationPage>();
            Container.RegisterInstance(Acr.UserDialogs.UserDialogs.Instance);
        }
    }
}