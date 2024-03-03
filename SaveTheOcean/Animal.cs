using System;


namespace SaveTheOcean
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public double Weight { get; set; }

        public Animal(string species, double weight)
        {
            Species = species;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Species} - {Weight} kg";
        }

        public abstract int CalculateNewGA(int ga, bool locationCare);
    
    }
}
