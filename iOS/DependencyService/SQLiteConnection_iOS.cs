using System;
using System.IO;

using AppFinalMITInfnet.iOS;

namespace AppFinalMITInfnet.iOS
{
    public class SQLiteConnection_iOS : ISQLiteConnection
    {
        public SQLite.SQLiteConnection GetPlataformSpecificConnection()
        {
            try
            {
                var sqliteFilename = "localDB.db3";
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string libraryPath = Path.Combine(documentsPath, "..", "Library");
                var path = Path.Combine(libraryPath, sqliteFilename);
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