using System;
using UnityEngine;
using SQLite4Unity3d;
using SQLite4Unity3d;
public class DatabaseManager : MonoBehaviour
{

    private string dbPath;

    void Start()
    {
        dbPath = "URI=file:" + Application.dataPath + "/Database/users.db"; // Veritabaný dosya yolu
        CreateTable();
    }

    void CreateTable()
    {
        using (var connection = new SqliteConnection(dbPath))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Users (Username TEXT, Password TEXT)";
                command.ExecuteNonQuery();
            }
        }
    }

    public bool ValidateUser(string username, string password)
    {
        using (var connection = new SqliteConnection(dbPath))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
