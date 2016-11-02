using System;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Menu
    {
        public int Order { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public IList<MenuItem> Items { get; set; }
    }
}