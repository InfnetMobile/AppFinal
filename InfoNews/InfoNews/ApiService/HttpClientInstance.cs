using System;
using System.Net.Http;

namespace InfoNews
{
	public sealed class HttpClientInstance
	{
		static volatile HttpClientInstance instance;
		readonly static object syncLock = new object();
		static HttpClient _client;

		HttpClientInstance()
		{
			_client = new HttpClient();
			_client.Timeout = TimeSpan.FromSeconds(40);
			_client.BaseAddress = new Uri("https://randomuser.me/");
		}

		public static HttpClient GetClientInstance
		{
			get
			{
				try
				{
					if (instance == null)
					{
						lock (syncLock)
						{
							if (instance == null)
								instance = new HttpClientInstance();
						}
					}

					return _client;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}
	}
}
