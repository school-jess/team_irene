using basic_information_library.models;

class Program
{
    static void Main()
    {

        BasicInformation model = new BasicInformation();
        // MySqlConnection conn = new MySqlConnection($"Server=localhost; database=first_database; user=root; password={Env.GetString("MYSQL_ROOT_PASSWORD")};");
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

            // MySqlCommand cmd = new MySqlCommand($"INSERT INTO first_table (first_name, middle_initial, last_name, suffix, full_name, birthday, age, house_number, street_name, barangay, city, country, full_address) value (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, @value12, @value13)", conn);
            // cmd.Parameters.AddWithValue("@value1", model.firstName);
            // string? middleInitial = null;
            // if (model.middleInitial != "")
            // {
            //     middleInitial = model.middleInitial;
            // }
            // cmd.Parameters.AddWithValue("@value2", middleInitial);
            // cmd.Parameters.AddWithValue("@value3", model.lastName);
            // string? suffix = null;
            // if (model.suffix != "")
            // {
            //     suffix = model.suffix;
            // }
            // cmd.Parameters.AddWithValue("@value4", suffix);
            // cmd.Parameters.AddWithValue("@value5", model.fullName);
            // cmd.Parameters.AddWithValue("@value6", model.birthDay);
            // cmd.Parameters.AddWithValue("@value7", model.age);
            // cmd.Parameters.AddWithValue("@value8", model.houseNumber);
            // cmd.Parameters.AddWithValue("@value9", model.street);
            // cmd.Parameters.AddWithValue("@value10", model.barangay);
            // cmd.Parameters.AddWithValue("@value11", model.city);
            // cmd.Parameters.AddWithValue("@value12", model.country);
            // cmd.Parameters.AddWithValue("@value13", model.address);
            // int rowsAffected = cmd.ExecuteNonQuery();
            // Console.WriteLine("Saved to database");
            // Console.WriteLine($"{rowsAffected} row(s) inserted");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}