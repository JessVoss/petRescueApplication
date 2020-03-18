using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace petRescueApplication.Models
{
    public class Adoption
    {
        public int ID { get; set; }
        public int AnimalID { get; set; }
        public int PatronID { get; set; }
       

        public virtual Animal Animal { get; set; }
        public virtual Patron Patron { get; set; }
    }
}