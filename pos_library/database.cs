using DotNetEnv;
using MySql.Data.MySqlClient;

namespace pos_library;

public class Database
{
    public MySqlConnection conn { get; set; }
    public Database()
    {
        Env.Load();
    }

    public void Connect(string user)
    {
        string connStr = $"Server=localhost; database=pos; user={user}; password={Env.GetString("MYSQL_ROOT_PASSWORD")};";
        conn = new MySqlConnection(connStr);
        conn.Open();
    }

    ~Database()
    {
        conn.Close();
    }
}