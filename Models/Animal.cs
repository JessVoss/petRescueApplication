using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace petRescueApplication.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string AnimalsName { get; set; }
        public string CommonName { get; set; }

        public string BreedName { get; set; }
        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}