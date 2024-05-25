
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public partial class Person
{
    public Person()
    {

    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties/Data Members
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A";

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
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine($"Tax Number already exists for {FirstName} {LastName}");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber() 
    {
        return _idNumber;
    }

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
