using MySql.Data.MySqlClient;
using basic_information_library.models;
using Microsoft.Extensions.Configuration;

namespace basic_information_library;

public class Database
{
    MySqlConnection conn { get; set; }
    IConfigurationRoot config;

    public Database()
    {
        config = new ConfigurationBuilder().AddUserSecrets<Database>().Build();
    }

    public void Connect(string user)
    {
        string connStr = $"Server=localhost; database=first_database; user={user}; password={config["MYSQL_ROOT_PASSWORD"]};";
        conn = new MySqlConnection(connStr);
        conn.Open();
    }

    public void Insert(BasicInformation model)
    {
        MySqlCommand cmd = new MySqlCommand("INSERT INTO first_table (first_name, middle_initial, last_name, suffix, full_name, birthday, age, house_number, street_name, barangay, city, country, full_address, province) value (@firstName, @middleInitial, @lastName, @suffix, @fullName, @birthday, @age, @houseNumber, @street, @barangay, @city, @country, @address, @province)", conn);
        cmd.Parameters.AddWithValue("@firstName", model.firstName);
        string? middleInitial = null;
        if (model.middleInitial != "")
        {
            middleInitial = model.middleInitial;
        }
        cmd.Parameters.AddWithValue("@middleInitial", middleInitial);
        cmd.Parameters.AddWithValue("@lastName", model.lastName);
        string? suffix = null;
        if (model.suffix != "")
        {
            suffix = model.suffix;
        }
        cmd.Parameters.AddWithValue("@suffix", suffix);
        cmd.Parameters.AddWithValue("@fullName", model.fullName);
        cmd.Parameters.AddWithValue("@birthday", model.birthday);
        cmd.Parameters.AddWithValue("@age", model.age);
        cmd.Parameters.AddWithValue("@houseNumber", model.houseNumber);
        cmd.Parameters.AddWithValue("@street", model.street);
        cmd.Parameters.AddWithValue("@barangay", model.barangay);
        cmd.Parameters.AddWithValue("@city", model.city);
        cmd.Parameters.AddWithValue("@country", model.country);
        cmd.Parameters.AddWithValue("@address", model.address);
        cmd.Parameters.AddWithValue("@province", model.province);
        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine("Saved to database");
        Console.WriteLine($"{rowsAffected} row(s) inserted");
    }

    public MySqlDataReader Select(string? firstName)
    {
        string sqlStr = "SELECT * FROM first_table";
        if (firstName != null)
        {
            sqlStr += $" WHERE first_name=@value1";
        }
        MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
        if (firstName != null)
        {
            cmd.Parameters.AddWithValue("@value1", firstName);
        }
        MySqlDataReader reader = cmd.ExecuteReader();
        return reader;
    }

    public void Remove(string firstName)
    {
        if (firstName == "")
        {
            throw new Exception("Must five first name");
        }
        string sqlStr = $"DELETE FROM first_table WHERE first_name=@first_name";
        MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
        cmd.Parameters.AddWithValue("first_name", firstName);
        cmd.ExecuteNonQuery();
    }

    public void CloseReader(MySqlDataReader reader)
    {
        reader.Close();
    }

    ~Database()
    {
        conn.Close();
    }
}
