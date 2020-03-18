using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using petRescueApplication.Models;

namespace petRescueApplication.DAL
{
    public class AnimalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            var animals = new List<Animal>
            {
                new Animal{AnimalsName="Cooper",CommonName="Canine",BreedName="Labrador Retriever"},
                new Animal{AnimalsName="Zues",CommonName="Canine",BreedName="German Shepard Mix"},
                new Animal{AnimalsName="Snickers",CommonName="Feline",BreedName="ShortHair"},
                new Animal{AnimalsName="Midnight",CommonName="Feline",BreedName="LongHair"},
                new Animal{AnimalsName="Hearts",CommonName="Guinea Pig",BreedName="N/A"},
                new Animal{AnimalsName="Miggsey",CommonName="Iguana",BreedName="N/A"},
                new Animal{AnimalsName="Dale",CommonName="Degu",BreedName="N/A"},
                new Animal{AnimalsName="Dusty",CommonName="Canine",BreedName="Labrador Retriever mix"},
                new Animal{AnimalsName="Isis",CommonName="Canine",BreedName="Huskey/Labrador Mix"},
                new Animal{AnimalsName="Kasia",CommonName="Canine",BreedName="Huskey/Malmute Mix"}
            };

            animals.ForEach(a => context.Animals.Add(a));
            context.SaveChanges();
            var patrons = new List<Patron>
            {
                new Patron{FirstName="Frank", LastName="Furter", Address="120 Olympus Drive", City="Chicago", State="IL", Country="USA"},
                new Patron{FirstName="Daphne", LastName="Blake", Address="100 Coral St", City="Traverse City", State="MI", Country="USA"},
                new Patron{FirstName="Johnny", LastName="Quest", Address="240 Maple Dr", City="Minneapolis", State="MN", Country="USA"},
                new Patron{FirstName="Elmer", LastName="Fudd", Address="136 Bugsey Lane", City="The Villages", State="FL", Country="USA"},
                new Patron{FirstName="Christopher", LastName="Robin", Address="450 Honey Bear Lane", City="San Diego", State="CA", Country="USA"},
                new Patron{FirstName="Shaggy", LastName="Rogers", Address="620 Burger Lane", City="San Fransisco", State="CA", Country="USA"},
                new Patron{FirstName="Freddie", LastName="Jones", Address="900 royal palm way", City="Michigan City", State="IN", Country="USA"},
            };
            patrons.ForEach(d => context.Patrons.Add(d));
            context.SaveChanges();
            var adoptions = new List<Adoption>
            {
                new Adoption{AnimalID=1, PatronID=1},
                new Adoption{AnimalID=2, PatronID=2},
                new Adoption{AnimalID=3, PatronID=3},
                new Adoption{AnimalID=4, PatronID=4},
                new Adoption{AnimalID=5, PatronID=5,},
                new Adoption{AnimalID=6, PatronID=1},
                new Adoption{AnimalID=7, PatronID=6}
                
            };
            adoptions.ForEach(ad => context.Adoptions.Add(ad));
            context.SaveChanges();

        }

    }

}
