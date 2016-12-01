using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(AppFinalMITInfnet.Droid.SQLiteConnection_Android))]
namespace AppFinalMITInfnet.Droid
{
	public class SQLiteConnection_Android : ISQLiteConnection
	{
		public SQLiteConnection_Android() { }

		public SQLite.SQLiteConnection GetPlataformSpecificConnection()
		{
			var sqliteFilename = "localDB.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			var conn = new SQLite.SQLiteConnection(path);
			return conn;
		}
	}
}
