using System;

using SQLite;

namespace AppFinalMITInfnet
{
    public class BaseEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}