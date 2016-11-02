using System;

using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Ammount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool Status { get; set; }
    }
}