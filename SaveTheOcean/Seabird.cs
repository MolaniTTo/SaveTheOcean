using System;

namespace SaveTheOcean
{
    public class Seabird : Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Seabird(string species = "Au marina", double weight = 2, string name = "MioMio", string type = "Diomedeidae") : base(species, weight) {
        
            Name = name;
            Type = type;
        }

        public override int CalculateNewGA(int ga, bool locationCare) // override the CalculateNewGA method
        {
            int x = 5;
            int newGa = ga - (ga * ga + x);
            return newGa;
        }
    }
}
