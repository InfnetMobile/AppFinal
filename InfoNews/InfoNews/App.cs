using System;
using Xamarin.Forms;
using System.Diagnostics;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System.Net.Http;

namespace InfoNews
{
	public class App : PrismApplication
	{
		public static bool UsuarioLogado { get; set; }
		public static SQLite.SQLiteConnection dbConn;
		public static HttpClient HttpClientInstance;
		static UsuarioDataBase database;

		public static int IdUsuarioLogado { get; set;}

		public App()
		{
			if (!UsuarioLogado)
			{
				Resources = new ResourceDictionary();
				Resources.Add("marron", Color.FromHex("6D0019"));

				var nav = new NavigationPage(new LoginPage());
				nav.BarBackgroundColor = (Color)App.Current.Resources["marron"];
				nav.BarTextColor = Color.White;

				MainPage = nav;
			}
			else
			{
				Resources = new ResourceDictionary();
				Resources.Add("marron", Color.FromHex("6D0019"));

				var nav = new NavigationPage(new InfoNewsPage());
				nav.BarBackgroundColor = (Color)App.Current.Resources["marron"];
				nav.BarTextColor = Color.White;

				MainPage = nav;
			}
		}

		public static UsuarioDataBase Database
		{
			get
			{
				if (database == null)
				{
					database = new UsuarioDataBase();
				}
				return database;
			}
		}

		protected override void OnInitialized()
		{
			NavigationService.NavigateAsync("InfoNewsPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<InfoNewsPage>();
		}
	}
}