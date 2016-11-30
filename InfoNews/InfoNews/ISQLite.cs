using System;
using SQLite;

namespace InfoNews
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
