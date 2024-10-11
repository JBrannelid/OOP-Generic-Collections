namespace OOP_Generic_Collections
{
    public class StackHandler : Employee
    {
        public StackHandler(string id, string name, string gender, decimal salary)
            : base(id, name, gender, salary)
        {
        }

        public static void RemoveObjectFromStack(Stack<Employee> employeeStack)
        {   // As long as EmployeeStack is less than 0, display and remove (.Pop()) employee from the Stack
            while (employeeStack.Count > 0)
            {
                var topItem = employeeStack.Pop(); //
                Console.WriteLine(topItem.ToString()); // Convert and print object/element to string
                Console.WriteLine($"Remaining employees in the stack = {employeeStack.Count}\n");
            }
        }

        public static void PeekObjectFromStack(Stack<Employee> employeeStack)
        {   // Peek() display object without removing from the Stack. For loop will run 2 times
            Employee peekobj = employeeStack.Peek();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(peekobj.ToString()); // Convert and print object/element to string
                Console.WriteLine($"Remaining employees in the stack = {employeeStack.Count}\n");
            }
        }
    }
}