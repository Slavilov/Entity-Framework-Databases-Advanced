﻿using System;
using System.Collections.Generic;

namespace SoftUni_Second_Attempt_DB.Models
{
    public partial class Address
    {
        public Address()
        {
            Employees = new HashSet<Employee>();
        }

        public int AddressId { get; set; }
        public string AddressText { get; set; }
        public int? TownId { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
