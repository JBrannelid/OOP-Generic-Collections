// Programmer:   Johannes Brannelid
// Institute:    Chas Academy
// Program:      Full stack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 7:        OOP Generic collections

namespace OOP_Generic_Collections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------------------------------//
            //                                                    1. Stack <T>                                                                      //
            //--------------------------------------------------------------------------------------------------------------------------------------//

            // Create 5 objects of class Employee with properties (Id, Name, Gender, Salary)
            Employee employee1 = new Employee("001", "John Snow", "Male", 33000);
            Employee employee2 = new Employee("002", "Tolvan Tolvansson", "Unknown", 5000);
            Employee employee3 = new Employee("003", "John Doe", "Male", 50000);
            Employee employee4 = new Employee("004", "Jane Doe", "Female", 50000);
            Employee employee5 = new Employee("005", "Linnea Andersson", "Female", 30000);

            Stack<Employee> employeeStack = CreateEmployeeStack(); // Call CreateEmployeeStack and push object to employeeStack

            DisplayStack(employeeStack); // Call DisplayStack and print out all objects

            PrintReadkey(); // Prompt user for random input and clean the console

            Console.WriteLine("Retrieve Using Pop Method");
            StackHandler.RemoveObjectFromStack(employeeStack); // Retrieve and display remaining objects using the Pop(T item) method

            PrintReadkey(); // Prompt user for random input and clean the console

            employeeStack = CreateEmployeeStack(); // Call CreateEmployeeStack() again and push the object back to employeeStack

            Console.WriteLine("Retrieve Using Peek Method two times");
            StackHandler.PeekObjectFromStack(employeeStack); // Call object with Peek-Method and display object left in the stack

            PrintReadkey(); // Prompt user for random input and clean the console

            // Check if employee with a certain ID is in stack with a ternary operator
            Console.WriteLine("Check if employee with Id '003' is in the Stack");
            Employee.ReturnContainsId(employeeStack, "003"); // Call the method to check for ID "003"

            PrintReadkey(); // Prompt user for random input and clean the console

            //--------------------------------------------------------------------------------------------------------------------------------------//
            //                                                    2. List <T>                                                                       //
            //--------------------------------------------------------------------------------------------------------------------------------------//

            List<Employee> employeesList = CreateEmployeeList(); // Call CreateEmployeeList and push object to employeeList

            Console.WriteLine("Check if employee with Id '002' is in the List");
            Employee.ReturnContainsId(employeesList, "002");

            PrintReadkey(); // Prompt user for random input and clean the console

            Console.WriteLine("First employee with gender male");
            ListHandler.FirstMaleObject(employeesList, "gender"); // Find first employee with gender male

            PrintReadkey(); // Prompt user for random input and clean the console

            ListHandler.FindAllMaleObject(employeesList); // Find all male object

            PrintReadkey(); // Prompt user for random input and clean the console
        }

        private static void DisplayStack(Stack<Employee> employeeStack)
        {
            // Display all employees in the stack without affecting the original stack
            foreach (var item in employeeStack)
            {
                Console.WriteLine($"\nEmployee remaining in the stack = {employeeStack.Count}");
                Console.WriteLine(item.ToString());
                Console.WriteLine("");
            }
        }

        private static void PrintReadkey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Sense console.Clear() didn't cleared the console buffer completely (struggle with LIFO and ToString() Method)
            // Did I add an escape sequence
            Console.WriteLine("\x1b[3J");
        }

        private static Stack<Employee> CreateEmployeeStack()
        {
            // Create a stack and add then created objects to the stack with Push() methods
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(new Employee("001", "John Snow", "Male", 33000)); // Push(T item) add element (LIFO)
            employeeStack.Push(new Employee("002", "Tolvan Tolvansson", "Unknown", 5000));
            employeeStack.Push(new Employee("003", "John Doe", "Male", 50000));
            employeeStack.Push(new Employee("004", "Jane Doe", "Female", 50000));
            employeeStack.Push(new Employee("005", "Linnea Andersson", "Female", 30000));

            return employeeStack;
        }

        private static List<Employee> CreateEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("001", "John Snow", "Male", 33000));
            employeeList.Add(new Employee("002", "Tolvan Tolvansson", "Unknown", 5000));
            employeeList.Add(new Employee("003", "John Doe", "Male", 50000));
            employeeList.Add(new Employee("004", "Jane Doe", "Female", 50000));
            employeeList.Add(new Employee("005", "Linnea Andersson", "Female", 30000));

            return employeeList;
        }
    }
}

// Summary of Thoughts
// - Environment Sensitivity: The format string might be affected by the user's environment settings. Ex format Salary:C. Handling this variability isn't a focus of the project.
// - Input Handling: The program is not designed to manage user input or errors, which is why error handling and case sensitivity for strings are not prioritized
// - List and Stack Handler Class: The primary purpose of the List and Stack handler class is to enhance code readability and maintainability