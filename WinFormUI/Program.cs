using System;  // Provides fundamental classes and base types, such as data types, collections, and system functionality (e.g., Console, String, DateTime).
using System.Collections.Generic;  // Contains interfaces and classes that define various collections (e.g., List<T>, Dictionary<TKey, TValue>) used in the application.
using System.Linq;  // Provides classes and methods for Language Integrated Query (LINQ), allowing easier querying and manipulation of data in collections and arrays.
using System.Threading.Tasks;  // Includes classes that help with asynchronous programming, such as Task, enabling multi-threading and concurrency in the application.
using System.Windows.Forms;  // Provides classes for creating Windows-based graphical user interface (GUI) applications, such as forms, controls, and event handling.


namespace WinFormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]  // Specifies that the COM threading model for the application is single-threaded apartment.
        static void Main()
        {
            Application.EnableVisualStyles();  // Enables visual styles for the application.
            Application.SetCompatibleTextRenderingDefault(false);  // Ensures the default text rendering is compatible with the application.
            Application.Run(new PeopleForm());  // Starts the application and opens the PeopleForm window.
        }
    }
}
