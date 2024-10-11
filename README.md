# OOP Generic Collections

## Overview

This C# program demonstrates the use of generic collections, specifically **Stacks** and **Lists**, to manage employee data. 
The program display how¨to retrieve, display, and filter employee information based on gender.

## Code Structure

### 1. Employee Class

- Defines the properties of an employee:
  - ID
  - Name
  - Gender
  - Salary
- Includes methods for:
  - Displaying employee information ToString().
  - Checking if an employee exists by ID.

### 2. ListHandler Class

- Contains methods to:
  - Find the first male employee.
  - Retrieve all male employees from a list.

### 3. StackHandler Class

- Handles stack operations:
  - Pushing employees onto the stack.
  - Popping employees from the stack.
  - Peeking at the top employee in the stack.

### 4. Program Class

- Entry point of the application where all functionalities are executed.

## Usage

1. Clone the repository https://github.com/JBrannelid/OOP-Generic-Collections.git
2. Open the project in a IDE

### Example Operations

- Check if an employee exists by ID.
- Display the first male employee or all male employees.
- Perform stack operations like push, pop, and peek.

## Requirements

- .NET 6 or later.

## Summary of Thoughts

- **Environment Sensitivity**: 
  - The program's salary format may vary based on user settings. Handling this variability is not a priority for this project.
  
- **Input Handling**: 
  - The program does not manage user input errors, so case sensitivity and error handling are not implemented.

- **Code Readability**: 
  - The List and Stack handler classes are designed to enhance code readability and maintainability.

## License

This project is open-source. Feel free to modify and use it as needed.
