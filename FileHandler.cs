namespace Workshop_repo_1;

public class FileHandler
{
    private readonly string _filePathPersons = Path.Combine("data", "Secrets.txt");
    private readonly string _filePathFacts = Path.Combine("data", "Facts.txt");
    
    public int PersonsInFile(string path)
    {
        if (!File.Exists(path))
            return 0; 

        int lineCount = File.ReadLines(path).Count();
        return lineCount;
    }
    
    public void SavePersonToFile(Person person)
    {
        string data = person.ToString() + Environment.NewLine;
        try
        {
            string directory = Path.GetDirectoryName(_filePathPersons);
            
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Console.WriteLine($"Directory not found: {directory}");
                return;
            }
    
            if (!File.Exists(_filePathPersons))
            {
                Console.WriteLine($"File not found: {_filePathPersons}");
                return;
            }
    
            File.AppendAllText(_filePathPersons, data);
            Console.WriteLine($"Content successfully written to {_filePathPersons}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
        }
    }

    public Person GetPersonByName(string name)
    {
        try
        {
            if (!File.Exists(_filePathPersons))
            {
                Console.WriteLine("File not found.");
                return null;
            }
    
            string[] lines = File.ReadAllLines(_filePathPersons);
            foreach (string line in lines)
            {
                if (line.Contains(name))
                {
                    string[] parts = line.Split(", ");
                    if (parts.Length == 2)
                    {
                        string firstName = parts[0];
                        string lastName = parts[1];
                        return new Person(firstName, lastName);
                    }
                }
            }
    
            Console.WriteLine("Person not found in the file.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            return null;
        }
    }
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