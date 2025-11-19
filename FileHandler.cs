namespace Workshop_repo_1;

public class FileHandler
{
    private readonly string _filePathFacts = Path.Combine("data", "Facts.txt");
    
    public string GetRandomFact(int randomNumber)
    {
        try
        {
            if (!File.Exists(_filePathFacts))
            {
                Console.WriteLine("Facts file not found.");
                return null;
            }
    
            string[] lines = File.ReadAllLines(_filePathFacts);
            return lines[randomNumber];
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the facts file: {ex.Message}");
            return null;
        }
        
    }
}