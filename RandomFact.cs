namespace Workshop_repo_1;

public class RandomFact
{ 
    private FileHandler _file = new FileHandler();
    public string RandomFactGenerator()
    {
        _file = new FileHandler();
        
        int random = Random.Shared.Next(0, 31);
        
        return _file.GetRandomFact(random);
    }
}