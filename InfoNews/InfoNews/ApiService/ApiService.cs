using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InfoNews
{
	public class ApiService<T> : IApiService<T> where T : class
	{
		//readonly IBaseRepository<T> _repo;

		public ApiService()
		{
			if (App.HttpClientInstance == null)
				App.HttpClientInstance = HttpClientInstance.GetClientInstance;
		}

		public async Task<T> Get()
		{
			try
			{
				var data = await App.HttpClientInstance.GetAsync("api/");

				if (data == null)
					throw new ArgumentNullException(nameof(data), "Nenhum dado retornado do serviço");

				if (!data.IsSuccessStatusCode)
					throw new ArgumentException(ReturnWebServiceErrorMsg(data.StatusCode));

				var jsonString = await data.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(jsonString);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<T> Get(string excludeFilter)
		{
			try
			{
				//?exc=info
				var data = await App.HttpClientInstance.GetAsync($"api/{excludeFilter}");

				if (data == null)
					throw new ArgumentNullException(nameof(data), "Nenhum dado retornado do serviço");

				if (!data.IsSuccessStatusCode)
					throw new ArgumentException(ReturnWebServiceErrorMsg(data.StatusCode));

				var jsonString = await data.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(jsonString);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<T> GetAll(int count)
		{
			//?results=5000
			try
			{
				var data = await App.HttpClientInstance.GetAsync($"api/?results={count}");

				if (data == null)
					throw new ArgumentNullException(nameof(data), "Nenhum dado retornado do serviço");

				if (!data.IsSuccessStatusCode)
					throw new ArgumentException(ReturnWebServiceErrorMsg(data.StatusCode));

				var jsonString = await data.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(jsonString);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<T> GetAll(string excludeFilter, int count)
		{
			try
			{
				var data = await App.HttpClientInstance.GetAsync($"api/?results={count}&exc={excludeFilter}");

				if (data == null)
					throw new ArgumentNullException(nameof(data), "Nenhum dado retornado do serviço");

				if (!data.IsSuccessStatusCode)
					throw new ArgumentException(ReturnWebServiceErrorMsg(data.StatusCode));

				var jsonString = await data.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(jsonString);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		string ReturnWebServiceErrorMsg(HttpStatusCode statusCode)
		{
			var msg = string.Empty;

			switch (statusCode)
			{
				case HttpStatusCode.BadRequest:
					msg = "Chamada inválida.";
					break;

				case HttpStatusCode.Forbidden:
					msg = "Acesso negado.";
					break;

				case HttpStatusCode.NotFound:
					msg = "Método não encontrado;";
					break;
			}

			return msg;
		}
	}
}
