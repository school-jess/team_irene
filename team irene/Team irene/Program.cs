using System;

class Program
{
    static void Main()
    {
        // Get user details
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Middle Initial: (optional)");
        string middleInitial = Console.ReadLine();

        Console.Write("Enter Suffix: (optional)");
        string suffix = Console.ReadLine();

        string fullName = $"{firstName} {lastName} {middleInitial} {suffix}";
        Console.WriteLine($"Full Name: {fullName}");

        // Get birthdate and calculate age
        Console.Write("Enter Birthdate (yyyy-MM-dd): ");
        DateTime birthDate;

        while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            Console.Write("Invalid date format. Please enter again (yyyy-MM-dd): ");
        }

        int age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now < birthDate.AddYears(age))
        {
            age--; // Adjust if birthday hasn't occurred this year yet
        }

        Console.WriteLine($"Age: {age}");

        // Get address details
        Console.Write("Enter House No.: ");
        string houseNo = Console.ReadLine();

        Console.Write("Enter Street: ");
        string street = Console.ReadLine();

        Console.Write("Enter Barangay: ");
        string barangay = Console.ReadLine();

        Console.Write("Enter Municipality: ");
        string municipality = Console.ReadLine();

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Console.Write("Enter Country: ");
        string country = Console.ReadLine();

        // Format and display the final address
        string finalAddress = $"{houseNo}, {street}, {barangay}, {municipality}, {city}, {country}";
        Console.WriteLine("\nFinal Address:");
        Console.WriteLine(finalAddress);
    }
}