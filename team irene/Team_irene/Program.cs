using team_irene2.models;

class Program
{
    static void Main()
    {
        irene model = new irene();
        // Get user details
        Console.Write("Enter First Name: ");
        model.firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        model.lastName = Console.ReadLine();

        Console.Write("Enter Middle Initial (Optional): ");
        model.middleInitial = Console.ReadLine();

        Console.Write("Enter Suffix (Optional): ");
        model.suffix = Console.ReadLine();

        Console.WriteLine($"Full Name: {model.fullName}");

        // Get birthdate and calculate age of the user
        Console.Write("Enter Birthdate (yyyy-MM-dd): ");
        try {
            model.birthDay = Convert.ToDateTime(Console.ReadLine());
        } catch {
            Console.Write("Invalid date format. Please enter again (yyyy-MM-dd): ");
        }

        Console.WriteLine($"Age: {model.age}");

        // Get address details of the user
        Console.Write("Enter House No.: ");
        model.houseNumber = Console.ReadLine();

        Console.Write("Enter Street: ");
        model.street = Console.ReadLine();

        Console.Write("Enter Barangay: ");
        model.barangay = Console.ReadLine();

        Console.Write("Enter Municipality: ");
        model.province = Console.ReadLine();

        Console.Write("Enter City: ");
        model.city = Console.ReadLine();

        Console.Write("Enter Country: ");
        model.country = Console.ReadLine();

        // Format and display the final address
        Console.WriteLine("\nFinal Address:");
        Console.WriteLine(model.address);
    }
}