using basic_information_library.models;
using basic_information_library;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        Console.Clear();
        Database db = new Database();
        try
        {
            db.Connect("root");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        BasicInformation model = new BasicInformation();
        bool tryAgain = true;
        int selected = 1;
        string[] options = { "Create", "Print", "Exit" };
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\u21E7 - Up");
            Console.WriteLine("\u21E9 - Down");
            Console.WriteLine("\u21A9 - Enter");
            Console.WriteLine("********************");
            for (int i = 0; i < options.Length; i++)
            {
                if (i + 1 == selected)
                {
                    Console.Write($"* >  \x1b[1;32m{i + 1}. {options[i]}\x1b[0m");
                }
                else
                {
                    Console.Write($"*    {i + 1}. {options[i]}");
                }
                for (int j = 0; j < (20 - (7 + options[i].Length)) - 2; j++)
                {
                    Console.Write($" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine("********************");
            ConsoleKey action = Console.ReadKey().Key;
            switch (action)
            {
                case ConsoleKey.Enter:
                    while (tryAgain == true)
                    {
                        Console.Clear();
                        try
                        {
                            switch (selected)
                            {
                                case 1:
                                    // Get user details
                                    Console.Write("Enter First Name: ");
                                    model.firstName = Console.ReadLine() ?? "";

                                    Console.Write("Enter Middle Initial (Optional): ");
                                    model.middleInitial = Console.ReadLine() ?? "";

                                    Console.Write("Enter Last Name: ");
                                    model.lastName = Console.ReadLine() ?? "";

                                    Console.Write("Enter Suffix (Optional): ");
                                    model.suffix = Console.ReadLine() ?? "";

                                    // Get birthdate and calculate age of the user
                                    Console.Write("Enter Birthdate (yyyy-MM-dd): ");
                                    model.birthday = Console.ReadLine() ?? "";

                                    // Get address details of the user
                                    Console.Write("Enter House No.: ");
                                    model.houseNumber = Console.ReadLine() ?? "";

                                    Console.Write("Enter Street: ");
                                    model.street = Console.ReadLine() ?? "";

                                    Console.Write("Enter Barangay: ");
                                    model.barangay = Console.ReadLine() ?? "";

                                    Console.Write("Enter City: ");
                                    model.city = Console.ReadLine() ?? "";

                                    Console.Write("Enter Municipality: ");
                                    model.province = Console.ReadLine() ?? "";

                                    Console.Write("Enter Country: ");
                                    model.country = Console.ReadLine() ?? "";

                                    Console.Clear();
                                    Console.WriteLine($"Full Name: {model.fullName}");
                                    Console.WriteLine($"Age: {model.age}");
                                    Console.WriteLine($"Address: {model.address}");
                                    db.Insert(model);
                                    break;
                                case 2:
                                    MySqlDataReader data = db.Select(null);
                                    while (data.Read())
                                    {
                                        Console.WriteLine($"id: {data["id"]}, first name: {data["first_name"]}, middle initial: {data["middle_initial"]}, last name: {data["last_name"]}, suffix: {data["suffix"]}, full name: {data["full_name"]}, birthday: {data["birthday"]}, age: {data["age"]}, house number: {data["house_number"]}, street: {data["street_name"]}, barangay: {data["barangay"]}, city: {data["city"]}, province: {data["province"]}, country: {data["country"]}");
                                    }
                                    db.CloseReader(data);
                                    break;
                                case 3:
                                    goto exited;
                            }
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
                        if (wantToTryAgain == ConsoleKey.N)
                        {
                            break;
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selected == options.Length)
                    {
                        continue;
                    }
                    selected += 1;
                    break;
                case ConsoleKey.UpArrow:
                    if (selected == 1)
                    {
                        continue;
                    }
                    selected -= 1;
                    break;
                default:
                    Console.WriteLine("Pls choose from options only");
                    break;
            }
        }
    exited:
        Console.WriteLine("Goodbye!");
    }
}