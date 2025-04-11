using System;  // Provides basic types such as System.String, System.Int32, etc.
using System.Collections.Generic;  // Provides collections like List<T>, Dictionary<T, T>, etc.
using System.Linq;  // Enables LINQ (Language Integrated Query) for querying collections.
using System.Text;  // Contains classes for working with text (e.g., StringBuilder).
using System.Threading.Tasks;  // Provides types for asynchronous programming and tasks.

namespace DemoLibrary
{
    // Represents a model for a person with properties for personal information.
    public class PersonModelInfo
    {
        // The unique identifier for a person (e.g., database ID).
        public int Id { get; set; }

        // The person's first name.
        public string FirstName { get; set; }

        // The person's last name.
        public string LastName { get; set; }

        // A computed property that combines FirstName and LastName to return the full name.
        public string FullName
        {
            get
            {
                // Returns the full name in the format: "FirstName LastName"
                return $"{FirstName} {LastName}";
            }
        }
    }
}
