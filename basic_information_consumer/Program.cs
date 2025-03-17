using basic_information_library.models;
using basic_information_library;

class Program
{
    static void Main()
    {
        Database db = new Database();
        db.Connect("root");
        BasicInformation model = new BasicInformation();
        bool tryAgain = true;
        while (tryAgain)
        {
            try
            {
                // Get user details
                Console.Write("Enter First Name: ");
                model.firstName = Console.ReadLine();

                Console.Write("Enter Middle Initial (Optional): ");
                model.middleInitial = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                model.lastName = Console.ReadLine();

                Console.Write("Enter Suffix (Optional): ");
                model.suffix = Console.ReadLine();

                Console.WriteLine($"Full Name: {model.fullName}");

                // Get birthdate and calculate age of the user
                Console.Write("Enter Birthdate (yyyy-MM-dd): ");
                model.birthDay = Console.ReadLine();
                Console.WriteLine(model.birthDay);

                Console.WriteLine($"Age: {model.age}");

                // Get address details of the user
                Console.Write("Enter House No.: ");
                model.houseNumber = Console.ReadLine();

                Console.Write("Enter Street: ");
                model.street = Console.ReadLine();

                Console.Write("Enter Barangay: ");
                model.barangay = Console.ReadLine();

                Console.Write("Enter City: ");
                model.city = Console.ReadLine();

                Console.Write("Enter Municipality: ");
                model.province = Console.ReadLine();

                Console.Write("Enter Country: ");
                model.country = Console.ReadLine();
                // Format and display the final address
                Console.WriteLine("\nFinal Address:");
                Console.WriteLine(model.address);
                db.Insert(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ConsoleKey wantToTryAgain = ConsoleKey.A;
            while (wantToTryAgain != ConsoleKey.Y && wantToTryAgain != ConsoleKey.N)
            {
                Console.Write("Do you want to continue(Yy/Nn)? ");
                wantToTryAgain = Console.ReadKey().Key;
            }
        }
    }
}