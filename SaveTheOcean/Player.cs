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

        public void UpdateExperience(int points)
        {
            Experience += points;
        }

        public override string ToString()
        {
            return $"Player: {Name}, Experience: {Experience}";
        }
    }
}
