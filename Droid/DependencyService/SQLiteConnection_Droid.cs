using System;
using System.IO;
using Xamarin.Forms;

using AppFinalMITInfnet.Droid;

[assembly: Dependency(typeof(SQLiteConnection_Droid))]
namespace AppFinalMITInfnet.Droid
{
    public class SQLiteConnection_Droid : ISQLiteConnection
    {
        public SQLite.SQLiteConnection GetPlataformSpecificConnection()
        {
            try
            {
                var sqliteFilename = "localDB.db3";
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentsPath, sqliteFilename);
                var conn = new SQLite.SQLiteConnection(path);
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}