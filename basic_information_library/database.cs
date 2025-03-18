using MySql.Data.MySqlClient;
using DotNetEnv;
using basic_information_library.models;

namespace basic_information_library;

public class Database
{
    MySqlConnection conn { get; set; }

    public Database()
    {
        Env.Load();
    }

    public void Connect(string user)
    {
        string connStr = $"Server=localhost; database=first_database; user={user}; password={Env.GetString("MYSQL_ROOT_PASSWORD")};";
        conn = new MySqlConnection(connStr);
        conn.Open();
    }

    public void Insert(BasicInformation model)
    {
        MySqlCommand cmd = new MySqlCommand($"INSERT INTO first_table (first_name, middle_initial, last_name, suffix, full_name, birthday, age, house_number, street_name, barangay, city, country, full_address) value (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, @value12, @value13)", conn);
        cmd.Parameters.AddWithValue("@value1", model.firstName);
        string? middleInitial = null;
        if (model.middleInitial != "")
        {
            middleInitial = model.middleInitial;
        }
        cmd.Parameters.AddWithValue("@value2", middleInitial);
        cmd.Parameters.AddWithValue("@value3", model.lastName);
        string? suffix = null;
        if (model.suffix != "")
        {
            suffix = model.suffix;
        }
        cmd.Parameters.AddWithValue("@value4", suffix);
        cmd.Parameters.AddWithValue("@value5", model.fullName);
        cmd.Parameters.AddWithValue("@value6", model.birthDay);
        cmd.Parameters.AddWithValue("@value7", model.age);
        cmd.Parameters.AddWithValue("@value8", model.houseNumber);
        cmd.Parameters.AddWithValue("@value9", model.street);
        cmd.Parameters.AddWithValue("@value10", model.barangay);
        cmd.Parameters.AddWithValue("@value11", model.city);
        cmd.Parameters.AddWithValue("@value12", model.country);
        cmd.Parameters.AddWithValue("@value13", model.address);
        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine("Saved to database");
        Console.WriteLine($"{rowsAffected} row(s) inserted");
    }

    public void Select()
    {
        MySqlCommand cmd = new MySqlCommand($"SELECT * FROM first_table", conn);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"id: {reader["id"]}, first_name: {reader["first_name"]}, middle_initial: {reader["middle_initial"]}, last_name: {reader["last_name"]}, suffix: {reader["suffix"]}, full_name: {reader["full_name"]}, birthday: {reader["birthday"]}, age: {reader["age"]}, house_number: {reader["house_number"]}, street_name: {reader["street_name"]}, barangay: {reader["barangay"]}, city: {reader["city"]}, country: {reader["country"]}, full_address: {reader["full_address"]}");
        }
    }

    ~Database()
    {
        conn.Close();
    }
}
