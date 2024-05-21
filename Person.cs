
// Define a class

using System.Security.Cryptography;

public class Person 
{ 
    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }

    // Field member
    private string _taxNumber;

    public void PrintFullName() 
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }

    public void GenerateTaxNumber()
    {
        _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

}

