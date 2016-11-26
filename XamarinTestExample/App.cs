using System;

using XamarinTestExample.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Acr.UserDialogs;

namespace XamarinTestExample
{
    public class App : PrismApplication
    {

        public App()
        {
          
        }
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("HomePage");
            
        }

        protected override void RegisterTypes()
        {

            Container.RegisterInstance(UserDialogs.Instance);
            
            //Container.RegisterInstance<IUserDialogs>(UserDialogs.Instance);
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<UserInfoConfirmationPage>();

            
            
        }
    }
}