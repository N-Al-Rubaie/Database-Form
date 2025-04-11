using DemoLibrary;  // References the DemoLibrary project to access the PersonModelInfo class and the SqliteDataAccess class.
using System;  // Provides fundamental types and base classes for the application.
using System.Collections.Generic;  // Contains classes for defining and working with collections like List<T>.
using System.ComponentModel;  // Provides types for component-based programming, typically for data binding and custom components.
using System.Data;  // Includes types for working with data sources, such as DataTables and DataSets.
using System.Drawing;  // Provides types for working with graphics, images, and drawing operations.
using System.Linq;  // Provides LINQ methods for querying collections in a declarative style.
using System.Text;  // Contains types for manipulating and encoding text.
using System.Threading.Tasks;  // Provides types for managing asynchronous operations and parallel tasks.
using System.Windows.Forms;  // Includes types for creating Windows Forms applications with user interfaces.

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        // List to hold the people fetched from the database
        List<PersonModelInfo> people = new List<PersonModelInfo>();

        // Constructor for the PeopleForm class
        public PeopleForm()
        {
            InitializeComponent();  // Initializes the form components
            LoadPeopleList();  // Loads the list of people from the database
        }

        // Method to load the list of people from the database
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();  // Fetches the list of people using SqliteDataAccess
            WireUpPeopleList();  // Updates the ListBox to display the list of people
        }

        // Method to bind the list of people to the ListBox
        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;  // Clears any existing data bound to the ListBox
            listPeopleListBox.DataSource = people;  // Binds the updated list of people to the ListBox
            listPeopleListBox.DisplayMember = "FullName";  // Displays the FullName property of each person in the list
        }

        // Event handler for the "Refresh List" button click
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();  // Reloads the list of people when the button is clicked
        }

        // Event handler for the "Add Person" button click
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            // Creates a new PersonModelInfo object to hold the data for the new person
            PersonModelInfo p = new PersonModelInfo();

            // Assigns the text from the input fields to the new person object
            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;

            // Saves the new person to the database
            SqliteDataAccess.SavePerson(p);

            // Clears the input fields after saving the person
            firstNameText.Text = "";
            lastNameText.Text = "";
        }

        // Event handler for form load, currently not being used
        private void PeopleForm_Load(object sender, EventArgs e)
        {
            // Code for handling the form load event can be added here if needed
        }
    }
}
