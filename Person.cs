namespace Workshop_repo_1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firsName, string lastName)
    {
        FirstName = firsName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName}, {LastName}";
    }
}