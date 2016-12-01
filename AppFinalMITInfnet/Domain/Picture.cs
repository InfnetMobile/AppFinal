using System;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Picture : BaseEntity
    {
        public string Large { get; set; }

        public string Medium { get; set; }

        public string Thumbnail { get; set; }

        [ForeignKey(typeof(Result))]
        public int ResultId { get; set; }
    }
}
