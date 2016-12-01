using System;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace AppFinalMITInfnet
{
    public class Result : BaseEntity
    {
        public string Gender { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Name Name { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Location Location { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Registered { get; set; }

        public string Phone { get; set; }

        public string Cell { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Picture Picture { get; set; }

        public string Nat { get; set; }
    }
}