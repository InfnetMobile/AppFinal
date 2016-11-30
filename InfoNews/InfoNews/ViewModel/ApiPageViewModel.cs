﻿using System.Linq;
using System;
using System.Threading.Tasks;

using Prism.Mvvm;
using System.Collections.ObjectModel;
using Prism.Navigation;
using PropertyChanged;
using Prism.Commands;

namespace InfoNews
{
	[ImplementPropertyChanged]
	public class ApiPageViewModel : BindableBase, INavigationAware
	{
		readonly IApiService<RootObject> _clientApiService;
		readonly IBaseApplicationService<Result> _clientBaseApplicationService;
		readonly INavigationService _navigationService;

		public ObservableCollection<Result> Clients { get; set; }
		public DelegateCommand<Result> ItemTappedCommand { get; set; }

		async Task NavigateTo(string page, Result client)
		{
			var parameters = new NavigationParameters();
			parameters.Add("Client", client);

			await _navigationService.NavigateAsync(page, parameters);
		}

		Action<Result> ItemTappedAction
		{
			get
			{
				return new Action<Result>(async (result) =>
				{
					await NavigateTo("ApiPage", result);
				});
			}
		}

		public ApiPageViewModel(IApiService<RootObject> clientApiService,
									   IBaseApplicationService<Result> clientBaseApplicationService,
									   INavigationService navigationService)
		{
			_clientApiService = clientApiService;
			_clientBaseApplicationService = clientBaseApplicationService;
			_navigationService = navigationService;

			ItemTappedCommand = new DelegateCommand<Result>(ItemTappedAction);
			Task.Run(async () => await LoadClientsFromApi());
		}


		async Task LoadClientsFromApi()
		{
			try
			{
				//var result = await _clientApiService.GetAll("?exc=login,id", 3);
				var result = await _clientApiService.Get();

				if (!result.Results.Any())
					throw new ArgumentNullException(nameof(result), "Nenhum dado retornado");
				
				 //result.Results.ForEach((obj) => _clientBaseApplicationService.Insert(obj));
				//result.Results.ForEach((obj) => _clientBaseApplicationService(obj));

				//result.Results.ToList();

				this.Clients = new ObservableCollection<Result>(result.Results);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
