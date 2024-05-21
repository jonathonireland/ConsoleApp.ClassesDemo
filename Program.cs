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

var person1 = new Person("Developer", "One", new DateOnly(2000, 10, 31));

person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "741852963");

person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

