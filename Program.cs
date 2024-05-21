Console.WriteLine("************ - Classes and Objects - *************");

// Define an object of a type Person.
Person person;

Person baby = new Person();

baby.LastName = "THompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);
