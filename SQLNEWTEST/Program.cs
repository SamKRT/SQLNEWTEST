using System;

namespace SQLNEWTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryManager = new SQLQueryManager();
            queryManager.InsertMitarbeiter("Samuel", "Kraut", new DateTime(2000, 6, 16));
        }
    }
}
