using System;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using Xamarin.Forms;
using artina = UXDivers.Artina.Shared;

namespace AppFinalMITInfnet.ViewModels
{
    [ImplementPropertyChanged]
    public class ClientDetailPageViewModel : BindableBase, INavigationAware
    {
        Result _client;
        public Result Client
        {
            get { return _client; }
            set { SetProperty(ref _client, value); }
        }

        public FormattedString Label0
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            FontFamily =artina.FontAwesome.FontName,
                        ForegroundColor= AppConstants.DefaultBackgroundColor,
                            Text="\uf075"
                        },
                        new Span
                        {
                            Text = "2963",
                            ForegroundColor = Color.White
                        }
                    }
                };
            }
        }

        public FormattedString Label1
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            FontFamily =artina.FontAwesome.FontName,
                        ForegroundColor= AppConstants.DefaultBackgroundColor,
                            Text="\uf183"
                        },
                        new Span
                        {
                            Text = "2963",
                            ForegroundColor = Color.White
                        }
                    }
                };
            }
        }

        public FormattedString Label2
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            FontFamily =artina.FontAwesome.FontName,
                        ForegroundColor= AppConstants.DefaultBackgroundColor,
                            Text="\uf006"
                        },
                        new Span
                        {
                            Text = "2963",
                            ForegroundColor = Color.White
                        }
                    }
                };
            }
        }

        public FormattedString Label3
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            FontFamily =artina.FontAwesome.FontName,
                        ForegroundColor= AppConstants.DefaultBackgroundColor,
                            Text="\uf08a"
                        },
                        new Span
                        {
                            Text = "2963",
                            ForegroundColor = Color.White
                        }
                    }
                };
            }
        }

        public ClientDetailPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Client"))
                Client = (Result)parameters["Client"];
        }
    }
}
