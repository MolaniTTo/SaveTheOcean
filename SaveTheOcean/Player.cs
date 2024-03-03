using System;

namespace SaveTheOcean
{
    public class Player
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Player(string name, int experience = 0)
        {
            Name = name;
            Experience = experience;
        }

        public void UpdateExperience(int points) // update the experience
        {
            Experience += points;
        }

        public override string ToString() // override the ToString method
        {
            return $"Player: {Name}, Experience: {Experience}";
        }
    }
}
