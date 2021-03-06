﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace petRescueApplication.Models
{
    public class Patron
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}