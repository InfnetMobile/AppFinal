using System;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Name : BaseEntity
    {
        public string Title { get; set; }

        public string First { get; set; }

        public string FirstCapitalized => Humanizer.To.TitleCase.Transform(First);

        public string Last { get; set; }

        [ForeignKey(typeof(Result))]
        public int ResultId { get; set; }
    }
}
