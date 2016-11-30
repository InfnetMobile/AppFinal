using System;
using InfoNews;
using Xamarin.Forms;
using InfoNews.iOS;
using System.IO;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace InfoNews.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS()
		{
		}

		#region ISQLite implementation
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFilename = "infonews.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);

			// This is where we copy in the prepopulated database
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
