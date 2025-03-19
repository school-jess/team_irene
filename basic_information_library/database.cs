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
        MySqlCommand cmd = new MySqlCommand("INSERT INTO first_table (first_name, middle_initial, last_name, suffix, full_name, birthday, age, house_number, street_name, barangay, city, country, full_address, province) value (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, @value12, @value13, @value14)", conn);
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
        cmd.Parameters.AddWithValue("@value6", model.birthday);
        cmd.Parameters.AddWithValue("@value7", model.age);
        cmd.Parameters.AddWithValue("@value8", model.houseNumber);
        cmd.Parameters.AddWithValue("@value9", model.street);
        cmd.Parameters.AddWithValue("@value10", model.barangay);
        cmd.Parameters.AddWithValue("@value11", model.city);
        cmd.Parameters.AddWithValue("@value12", model.country);
        cmd.Parameters.AddWithValue("@value13", model.address);
        cmd.Parameters.AddWithValue("@value14", model.province);
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
        string sqlStr = $"DELETE FROM first_table WHERE first_name=\"{firstName}\"";
        MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
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
