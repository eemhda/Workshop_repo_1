namespace Workshop_repo_1;

class Program
{
    
    static void Main(string[] args)
    {
        RandomFact fact = new RandomFact();
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Workshop Repository!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Complete Workshop Task Step 1\n" +
                              "2. Surprise Me!\n" +
                              "3. Exit");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You selected Workshop Task Step 1.");
                    // Add code for Workshop Task Step 1 here
                    break;
                case "2":
                    string stringFact = fact.RandomFactGenerator();
                    Console.WriteLine("Random Facts provided by ChatGPT:");
                    Console.WriteLine(stringFact);
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                    break;
                case "3":
                    run = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
    }
}