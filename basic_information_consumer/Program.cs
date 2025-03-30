using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using basic_information_library.models;
using System.Globalization;

var services = new ServiceCollection();
var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
services.AddDbContext<DatabaseCtx>(option =>
{
    option.UseMySQL(config["MYSQL_CONN_STR"]);
});
var serviceProvider = services.BuildServiceProvider();
var scope = serviceProvider.CreateScope();
var dbCtx = scope.ServiceProvider.GetRequiredService<DatabaseCtx>();

Console.Clear();
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
                            model.first_name = Console.ReadLine() ?? "";

                            Console.Write("Enter Middle Initial (Optional): ");
                            model.middle_initial = Console.ReadLine() ?? "";

                            Console.Write("Enter Last Name: ");
                            model.last_name = Console.ReadLine() ?? "";

                            Console.Write("Enter Suffix (Optional): ");
                            model.suffix = Console.ReadLine() ?? "";

                            // Get birthdate and calculate age of the user
                            Console.Write("Enter Birthdate (yyyy-MM-dd): ");
                            string dateInput = Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd");
                            DateTime parsedDate = DateTime.ParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                            // Get address details of the user
                            Console.Write("Enter House No.: ");
                            model.house_number = Console.ReadLine() ?? "";

                            Console.Write("Enter Street: ");
                            model.street_name = Console.ReadLine() ?? "";

                            Console.Write("Enter Barangay: ");
                            model.barangay = Console.ReadLine() ?? "";

                            Console.Write("Enter City: ");
                            model.city = Console.ReadLine() ?? "";

                            Console.Write("Enter Municipality: ");
                            model.province = Console.ReadLine() ?? "";

                            Console.Write("Enter Country: ");
                            model.country = Console.ReadLine() ?? "";

                            Console.Clear();
                            Console.WriteLine($"Full Name: {model.full_name}");
                            Console.WriteLine($"Age: {model.age}");
                            Console.WriteLine($"Address: {model.full_address}");
                            dbCtx.first_table.Add(model);
                            dbCtx.SaveChanges();
                            break;
                        case 2:
                            List<BasicInformation> personalDetails = dbCtx.first_table.ToList();
                            foreach (var personalDetail in personalDetails)
                            {
                                Console.WriteLine($"first name: {personalDetail.first_name}, middle initial: {personalDetail.middle_initial}, last name: {personalDetail.last_name}, suffix: {personalDetail.suffix}, full name: {personalDetail.full_name}, birthday: {personalDetail.birthday}, age: {personalDetail.age}, house number: {personalDetail.house_number}, street: {personalDetail.street_name}, barangay: {personalDetail.barangay}, city: {personalDetail.city}, province: {personalDetail.province}, country: {personalDetail.country}, full address: {personalDetail.full_address}");
                            }
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
