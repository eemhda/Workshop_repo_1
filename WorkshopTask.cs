namespace Workshop_repo_1;

public class WorkshopTask
{
    public void TaskOne()
    {
        Console.WriteLine("This is Workshop Task Step 1.");
        Console.WriteLine("Enter Your first name:");
        string firstName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Your last name:");
        string lastName = Console.ReadLine() ?? "";
        Person person = new Person(firstName, lastName);
        
        Console.WriteLine("You have now created a Person object:");
        Console.WriteLine(person);
        Console.ReadKey();
    }
    public void TaskTwo()
    {
        Console.WriteLine("This is Workshop Task Step 2.");
        Thread.Sleep(1000);
        Console.WriteLine("Prepare your Github Username");
        Thread.Sleep(1000);
        Console.WriteLine("Go to Ted, he will add you as a contributor.");
        Thread.Sleep(1000);
        Console.WriteLine("Create a new branch named with your first name from dev-branch.");
        Console.WriteLine("Instructions on how to create a branch can be found in the README file.");
        Thread.Sleep(1000);
        Console.WriteLine("Press any key to proceed to Task 3.");
        Console.ReadKey();
    }

    public void TaskThree()
    {
        Console.WriteLine("This is Workshop Task Step 3.");
        Thread.Sleep(1000);
        Console.WriteLine("By pressing any key, you will be guided to see a random fact.");
        Console.ReadKey();
        Console.WriteLine("Loading random fact...");
        Thread.Sleep(1000);
        RandomFact fact = new RandomFact();
        string stringFact = fact.RandomFactGenerator();
        Console.WriteLine("Here is your random fact:");
        Console.WriteLine(stringFact);
        Thread.Sleep(1000);
        Console.WriteLine("Save the fact for later!");
        Thread.Sleep(1000);
        Console.WriteLine("Open the *data/Secrets.txt* file.");
        Thread.Sleep(1000);
        Console.WriteLine("Enter the saved fact on a new line in the file along with your name.");
        Thread.Sleep(1000);
        Console.WriteLine("**************EXAMPLE**************");
        Console.WriteLine("this is a random fact, Ted Petersson");
        Console.WriteLine("**********************************");
        Thread.Sleep(1000);
        Console.WriteLine("Commit and push your changes to your branch.");
        Thread.Sleep(1000);
        Console.WriteLine("Instructions on how to merge your branch is provided in README.md file.");
        Thread.Sleep(1000);
        Console.WriteLine("Congratulations! You have completed the workshop tasks.");
        Console.ReadKey();
    }
    
   
}