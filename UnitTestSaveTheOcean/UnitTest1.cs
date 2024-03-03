using SaveTheOcean;

namespace UnitTestSaveTheOcean
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestAnimalCalculateNewGA()
        {
            // Arrange
            Animal turtle = new Turtle("Turtle", 50);
            Animal seabird = new Seabird("Seabird", 2);
            Animal cetacean = new Cetacean("Cetacean", 500);

            // Act
            int turtleNewGA = turtle.CalculateNewGA(1, true);
            int seabirdNewGA = seabird.CalculateNewGA(1, true);
            int cetaceanNewGA = cetacean.CalculateNewGA(1, true);

            // Assert
            Console.WriteLine($"Turtle New GA: {turtleNewGA}");
            Console.WriteLine($"Seabird New GA: {seabirdNewGA}");
            Console.WriteLine($"Cetacean New GA: {cetaceanNewGA}");
        }

        public void TestAnimalToString()
        {
            // Arrange
            Animal turtle = new Turtle("Turtle", 50);
            Animal seabird = new Seabird("Seabird", 2);
            Animal cetacean = new Cetacean("Cetacean", 500);

            // Act
            string turtleString = turtle.ToString();
            string seabirdString = seabird.ToString();
            string cetaceanString = cetacean.ToString();

            // Assert
            Console.WriteLine($"Turtle: {turtleString}");
            Console.WriteLine($"Seabird: {seabirdString}");
            Console.WriteLine($"Cetacean: {cetaceanString}");

            // Additional Assertions
            if (!turtleString.Contains("Turtle") || !turtleString.Contains("50"))
                throw new Exception("Turtle's string representation is incorrect.");
            if (!seabirdString.Contains("Seabird") || !seabirdString.Contains("2"))
                throw new Exception("Seabird's string representation is incorrect.");
            if (!cetaceanString.Contains("Cetacean") || !cetaceanString.Contains("500"))
                throw new Exception("Cetacean's string representation is incorrect.");
        }
    }

    [TestClass]

    public class PlayerTests
    {
        [TestMethod]
        public void TestUpdateExperience()
        {
            // Arrange
            Player player = new Player("TestPlayer", 0);

            // Act
            player.UpdateExperience(50);
            Console.WriteLine($"Player Experience after adding 50 points: {player.Experience}");

            player.UpdateExperience(-20);
            Console.WriteLine($"Player Experience after subtracting 20 points: {player.Experience}");
        }
    }

    [TestClass]

    public class PlayerTestsToString
    {
        [TestMethod]
        public void TestPlayerToString()
        {
            // Arrange
            Player player = new Player("TestPlayer", 50);

            // Act
            string playerString = player.ToString();

            // Assert
            Console.WriteLine($"Player: {playerString}");
            if (!playerString.Contains("TestPlayer") || !playerString.Contains("50"))
                throw new Exception("Player's string representation is incorrect.");
        }

    }

}