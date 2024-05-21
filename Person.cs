
// Define a class

public class Person 
{ 
    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }

    public void PrintFullName() 
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

}

