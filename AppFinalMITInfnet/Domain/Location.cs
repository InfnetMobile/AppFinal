using System;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Location : BaseEntity
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        [ForeignKey(typeof(Result))]
        public int ResultId { get; set; }
    }
}
