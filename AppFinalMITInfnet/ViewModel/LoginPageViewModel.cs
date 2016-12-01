using System;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;

using System.Linq.Expressions;
using Prism.Navigation;
using Acr.UserDialogs;
using System.Collections.Generic;

namespace AppFinalMITInfnet.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        readonly IPageDialogService _pageDialogService;
        readonly INavigationService _navigationService;
        readonly IBaseApplicationService<User> _userService;
        readonly IUserDialogs _userDialogs;

        public DelegateCommand Confirm { get; set; }
        public DelegateCommand<User> Navigate { get; set; }

        public LoginPageViewModel(IPageDialogService pageDialogService
                                  , INavigationService navigationService
                                  , IBaseApplicationService<User> userService
                                 , IUserDialogs userDialogs)
        {
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;
            _userService = userService;
            _userDialogs = userDialogs;

            Confirm = new DelegateCommand(ConfirmAction);
            Navigate = new DelegateCommand<User>(NavigateAction);
        }

        Action ConfirmAction
        {
            get
            {
                return new Action(async () =>
                {
                    if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                    {
                        await _pageDialogService.DisplayAlertAsync(string.Empty
                                                                   , "Usuário/Senha inválidos"
                                                                   , "OK");
                        ResetLoginInfo();
                        return;
                    }

                    Expression<Func<User, bool>> filter = (f) => f.Username == Username && f.Password == Password;
                    var result = await _userService.GetByFilter(filter);

                    if (result == null)
                    {
                        await _pageDialogService.DisplayAlertAsync(string.Empty
                                                                   , "Usuário/Senha inválidos"
                                                                   , "OK");
                        ResetLoginInfo();
                        return;
                    }

                    _userDialogs.ShowLoading("Carregando", MaskType.Black);
                    await Navigate.Execute(result);
                });
            }
        }

        public Action<User> NavigateAction
        {
            get
            {
                return new Action<User>(async (User user) =>
                {
                    var parameters = new NavigationParameters();
                    parameters.Add("LoggedUser", user);

                    await _navigationService.NavigateAsync("HomePage", parameters, true, false);
                    _userDialogs.HideLoading();
                });
            }
        }

        void ResetLoginInfo()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
