using System;
using Prism.Services;

namespace AppFinalMITInfnet
{
    public sealed class DatabaseConfig
    {
        static volatile DatabaseConfig instance;
        static readonly object syncLock = new object();
        static SQLite.SQLiteConnection conn = null;

        DatabaseConfig()
        {
           conn = new DependencyService().Get<ISQLiteConnection>().GetPlataformSpecificConnection();
        }

        public static SQLite.SQLiteConnection GetDatabaseConnection
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                            instance = new DatabaseConfig();
                    }
                }

                return conn;
            }
        }
    }
}
