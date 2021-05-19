using Dapper;
using System;
using System.Data.SqlClient;

namespace SQLNEWTEST
{
    class SQLQueryManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samuel Kraut\Documents\Test1.mdf;Integrated Security=True;Connect Timeout=30";
                        
        private readonly static string InsertMitarbeiterQuery = "INSERT INTO Mitarbeiter(Vorname, Nachname, Geburtstag) VALUES ('@Vorname','@Nachname','@Geburtstag')";
        
        public void InsertMitarbeiter(string vorname, string nachname, DateTime geburtstag)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Execute(InsertMitarbeiterQuery, new { Vorname = vorname, Nachname = nachname, Geburtstag = geburtstag });
        }
    }
}
