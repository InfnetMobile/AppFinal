using System;

namespace AppFinalMITInfnet
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime LastLoginDate { get; set; }

        public bool Status { get; set; }
    }
}