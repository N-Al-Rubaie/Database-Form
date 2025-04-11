using Dapper;  // Dapper is a micro ORM for working with databases, simplifies SQL queries.
using System;  // Provides basic types such as System.String, System.Int32, etc.
using System.Collections.Generic;  // Provides collections like List<T>, Dictionary<T, T>, etc.
using System.Configuration;  // Provides access to configuration settings (like connection strings).
using System.Data;  // Provides classes for data access, like IDbConnection and IDataReader.
using System.Data.SQLite;  // Provides classes for interacting with SQLite databases.
using System.Linq;  // Enables LINQ (Language Integrated Query) for querying collections.
using System.Text;  // Contains classes for working with text (e.g., StringBuilder).
using System.Threading.Tasks;  // Provides types for asynchronous programming and tasks.

namespace DemoLibrary
{
    // Provides methods for interacting with the SQLite database, such as loading and saving people.
    public class SqliteDataAccess
    {
        // Loads a list of people from the SQLite database.
        // Returns a list of PersonModelInfo objects.
        public static List<PersonModelInfo> LoadPeople()
        {
            // Using a 'using' block to ensure the connection is properly disposed of when done.
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Executes a SQL query to retrieve all records from the Person table.
                // The results are mapped to a list of PersonModelInfo objects.
                var output = cnn.Query<PersonModelInfo>("select * from Person", new DynamicParameters());

                // Converts the result to a list and returns it.
                return output.ToList();
            }
        }

        // Saves a person's information into the SQLite database.
        // Accepts a PersonModelInfo object and inserts it into the Person table.
        public static void SavePerson(PersonModelInfo person)
        {
            // Again, uses 'using' to ensure proper disposal of the connection.
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Executes an SQL query to insert a new person into the database.
                // Uses parameters to prevent SQL injection.
                cnn.Execute("insert into Person (FirstName, LastName) values (@FirstName, @LastName)", person);
            }
        }

        // Loads the connection string from the configuration file.
        // The 'id' parameter allows loading different connection strings if needed.
        private static string LoadConnectionString(string id = "Default")
        {
            // Retrieves the connection string from the configuration file by its name (Default by default).
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
