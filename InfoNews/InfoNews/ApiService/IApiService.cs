using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoNews
{
	public interface IApiService<T> where T : class
	{
		Task<T> Get();
		Task<T> GetAll(int count);

		Task<T> Get(string excludeFilter);
		Task<T> GetAll(string excludeFilter, int count);
	}
}
