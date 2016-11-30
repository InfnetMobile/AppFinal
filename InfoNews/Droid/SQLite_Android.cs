using System;
using InfoNews;
using Xamarin.Forms;
using InfoNews.Droid;
using System.IO;

[assembly: Dependency (typeof(SQLite_Android))]

namespace InfoNews.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android()
		{
		}

		#region ISQLite implementation
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFilename = "infonews.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);

			Console.WriteLine(path);
			if (!File.Exists(path))
			{
				File.Create(path);
			}

			var conn = new SQLite.SQLiteConnection(path);

			return conn;
		}
		#endregion
	}
}
