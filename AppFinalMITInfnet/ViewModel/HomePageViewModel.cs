using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace AppFinalMITInfnet.ViewModels
{
    public class HomePageViewModel : BindableBase
    {
        public ObservableCollection<MenuItem> Menus { get; set; }
        public DelegateCommand<object> ChooseCorrectPageCommand { get; set; }

        readonly INavigationService _NavigationService;

        Action<object> NavigateToAction
        {
            get
            {
                return new Action<object>(async (menuItem) =>
                {
                    await ShowNewPageFromMenu(((MenuItem)menuItem).MenuId);
                });
            }
        }

        public HomePageViewModel(INavigationService navigationService)
        {
            _NavigationService = navigationService;

            ChooseCorrectPageCommand = new DelegateCommand<object>(NavigateToAction);
            Menus = MenuMockHelper.Menus;
        }

        async Task ShowNewPageFromMenu(int menu)
        {
            switch (menu)
            {
                case 0:
                    await NavigateTo("ClientListPage");
                    break;

                case 1:
                    await NavigateTo("ProductListPage");
                    break;

                case 2:
                    await NavigateTo("OrderListPage");
                    break;

                case 3:
                    await NavigateTo("CompanyListPage");
                    break;

                case 4:
                    await NavigateTo("SetupPage");
                    break;

                case 5:
                    await NavigateTo("LoginPage");
                    break;
            }
        }

        async Task NavigateTo(string page)
        {
            await _NavigationService.NavigateAsync(page);
        }
    }
}
