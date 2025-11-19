namespace Workshop_repo_1;

class Program
{
    
    static void Main(string[] args)
    {
        RandomFact fact = new RandomFact();
        WorkshopTask workshop = new WorkshopTask();
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Workshop Repository!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Begin Workshop Task 1\n" +
                              "2. Exit");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You selected Workshop Task Step 1.");
                    workshop.TaskOne();
                    break;
                case "2":
                    run = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
        
    }
}