﻿using System;
using Microsoft.AspNetCore.Identity;

namespace leave_management.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }

}
