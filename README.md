# Database Form

This project is a simple Windows Forms application that allows users to manage a list of people. It features the ability to add people to a database and display them in a list.

## Project Overview

### 1. **Main Form**
This is the main form of the application where users can enter the first and last names and view the list of added people.

![Main Form](https://github.com/user-attachments/assets/0929527e-17b2-4581-af0f-605ea84ab3a0)


### 2. **People List**
This screenshot shows the updated list of people displayed on the right-hand side of the form.

![People List](https://github.com/user-attachments/assets/65dd31ee-824f-4185-adc4-b75c7b4ed7a6)

The application enables users to:
- Add a person's first and last name.
- View a list of all people in the database.

It uses **SQLite** as the database for storing the people's information. The form interface is created with **Windows Forms** (WinForms) and allows users to easily interact with the application.

## Features
- **Add Person**: Users can add a person by entering their first and last name into input fields and pressing the "Add Person" button.
- **List People**: A list is displayed showing the people stored in the database, with each person's full name visible.
- **Refresh List**: Users can refresh the displayed list to see the most current information.

## Project Structure

- **DatabaseFormUI**: This is the main UI project, where the application interface is defined.
- **DemoLibrary**: Contains logic for interacting with the SQLite database, such as loading and saving data.

### Key Components
1. **`PeopleForm`**: The main form for displaying and adding people.
   - Controls: `TextBox`, `Button`, `ListBox`, `Label`, etc.
   - Events: `addPersonButton_Click`, `refreshListButton_Click`
   
2. **Database Access**: Interaction with the SQLite database is handled by a class in `DemoLibrary` which connects to the database, saves new people, and loads them to display in the UI.


## How to Use

1. **Run the application**: When you start the application, the main window will appear.
2. **Add a person**: Enter a first name and last name, then click "Add Person" to store them in the database.
3. **View the list**: The list of people will be displayed in the list box. You can click "Refresh List" to update the list if any changes were made.

## Requirements

- .NET Framework 4.7 or higher
- SQLite Database (used for data storage)
