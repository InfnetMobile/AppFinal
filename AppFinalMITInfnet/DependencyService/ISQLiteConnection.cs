using System;
namespace AppFinalMITInfnet
{
    public interface ISQLiteConnection
    {
        SQLite.SQLiteConnection GetPlataformSpecificConnection();
    }
}
