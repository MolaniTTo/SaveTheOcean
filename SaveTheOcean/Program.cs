using SaveTheOcean;

namespace SaveTheOcean
{
    public class Program
    {
        static Random random = new Random();

        public static void RescueSimulation(Player player) // This method is used to simulate a rescue and treatment of an animal
        {
            Animal[] speciesArray = new Animal[] { new Turtle(), new Seabird(), new Cetacean() }; // Array of animals
            Animal chosenSpecies = speciesArray[random.Next(speciesArray.Length)]; // Choose a random animal from the array
            string rescueNumber = "RES" + random.Next(0, 1000).ToString("D3");// Generate a random rescue number
            string rescueDate = "27-02-2024";
            int affectationDegree = random.Next(1, 100);
            string location = "Calella"; 

            // Print the rescue information

            Console.WriteLine("+-------------------------------------------------------------+\r\n");
            Console.WriteLine("|                       RESCAT                                |");
            Console.WriteLine("+-------------------------------------------------------------+\r\n");
            Console.WriteLine("| # Rescat | Data rescat | Superfamília   | GA | Localització |\r\n");
            Console.WriteLine($"| {rescueNumber}   | {rescueDate}  |   {chosenSpecies.Species}    | {affectationDegree} |    {location}      |");
            Console.WriteLine("+-------------------------------------------------------------+\r\n");
            Console.WriteLine();
            Console.WriteLine("Aquí tens la seva fitxa, per a més informació:\r\n");
            Console.WriteLine();
            Console.WriteLine("+-------------------------------------------------------------+\r\n");
            Console.WriteLine("|                       FITXA                                 |\r\n");
            Console.WriteLine("+-------------------------------------------------------------+\r\n");
            Console.WriteLine("| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n");
            if (chosenSpecies is Turtle)
            {
                Turtle turtle = (Turtle)chosenSpecies;
                Console.WriteLine($"| {turtle.Name} |   {turtle.Species} | {turtle.Type}   | {turtle.Weight} kg              |\r\n");
            }
            else if (chosenSpecies is Seabird)
            {
                Seabird seabird = (Seabird)chosenSpecies;
                Console.WriteLine($"| {seabird.Name} |      {seabird.Species} | {seabird.Type}   | {seabird.Weight} kg              |\r\n");
            }
            else if (chosenSpecies is Cetacean)
            {
                Cetacean cetacean = (Cetacean)chosenSpecies;
                Console.WriteLine($"| {cetacean.Name} |     {cetacean.Species} | {cetacean.Type}   | {cetacean.Weight} kg              |\r\n");
            }
            Console.WriteLine("+-------------------------------------------------------------+\r\n");

            // Ask the player if they want to cure or transfer the animal to the CRAM

            Console.WriteLine($"El/La {chosenSpecies.Species} té un grau d’afectació (GA) del {affectationDegree}%. Vols curar (1) o traslladar al centre (2)?");

            bool locationCare = Console.ReadLine() == "1";

            int newGa = chosenSpecies.CalculateNewGA(affectationDegree, locationCare); // Calculate the new GA
            Console.WriteLine($"El tractament aplicat ha deixat l'animal amb un grau d'afectacio del {newGa}%.");

            if (newGa < 5)
            {
                Console.WriteLine("Tractament exitos! L'animal pot ser entregat de nou a la selva.");
                player.UpdateExperience(50);
            }
            else
            {
                Console.WriteLine("Tractament fracassat. L'animal necessita mes tractament per part del CRAM.");
                player.UpdateExperience(-20);
            }

            Console.WriteLine(player);
        }

        public static void Main()
        {
            // Main menu
            Console.WriteLine("Save the ocean!");
            Console.WriteLine("Què vols fer?");
            Console.WriteLine("1. Jugar!");
            Console.WriteLine("2. Sortir");

            string option = Console.ReadLine();

            if (option == "1") 
            {
                Console.WriteLine("Perfecte! Què vols ser?");
                Console.WriteLine("1. Tècnic (45 XP)");
                Console.WriteLine("2. Veterinari (80 XP)");

                string playerType = Console.ReadLine();
                int startingExperience = playerType == "1" ? 45 : 80;

                Console.WriteLine("Genial! I el teu nom?");
                string playerName = Console.ReadLine();
                Player player = new Player(playerName, startingExperience);

                Console.WriteLine($"Hola, {playerName}!");

                Console.WriteLine("El 112 ha rebut una trucada d’avís d’un exemplar a rescatar.");
                Console.WriteLine("Les dades que ens han donat són les següents:");

                RescueSimulation(player);
            }
            else if (option == "2")
            {
                Console.WriteLine("Fins el proper rescat!");
            }
            else
            {
                Console.WriteLine("Opció invàlida.");
            }
        }

    }

}