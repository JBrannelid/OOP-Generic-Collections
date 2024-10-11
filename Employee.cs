namespace OOP_Generic_Collections
{
    public class Employee
    {   // Properties for the employee
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        // Constructor to initialize an employee
        public Employee(string id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Override of the ToString method to provide a detailed representation of the object
        public override string ToString()
        {
            // Returns a string that includes all properties with a more formatted and readable appearance
            return
                   $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Salary: {Salary:C}"; // Format string to display salary. Determined by the current settings of the environment in which the program is running
        }

        private static bool ContainsEmployeeWithId(IEnumerable<Employee> employeeStack, string id) // Private, access just inside Employee class
        {   // Check if employee with a specific ID exists in the collection
            foreach (var employee in employeeStack)
            {
                if (employee.Id == id)
                {
                    return true; // Found the employee with the specified ID
                }
            }
            return false; // Employee not found
        }

        public static void ReturnContainsId(IEnumerable<Employee> employees, string id)
        {
            string message = ContainsEmployeeWithId(employees, id) ? $"ID {id} is in the collection" : $"{id} is NOT in the collection"; // Save bool value to string message
            Console.WriteLine($"{message}\n"); // Print the result of the check
        }
    }
}