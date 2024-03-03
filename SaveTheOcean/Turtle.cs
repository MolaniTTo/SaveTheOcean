using System;

namespace SaveTheOcean
{
    public class Turtle : Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Turtle(string species = "Tortuga", double weight = 50, string name= "Valpa", string type= "Tortuga Careta") : base(species, weight) {
            Name = name;
            Type = type;
        }

        public override int CalculateNewGA(int ga, bool locationCare) // override the CalculateNewGA method
        {
            int x = 5;
            int newGa = ga - ((ga - 2) * (2 * ga + 3)) - x;
            return newGa;
        }
    }
}
