using System;

namespace SaveTheOcean
{
    public class Cetacean : Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Cetacean(string species = "Cetaci", double weight = 500, string name = "Oumou", string type = "Dofí llistat") : base(species, weight) {
        
            Name = name;
            Type = type;
        }

        public override int CalculateNewGA(int ga, bool locationCare)
        {
            int x = locationCare ? 25 : 0;
            int newGa = ga - (int)(Math.Log10(ga)) - x;
            return newGa;
        }
    }
}
