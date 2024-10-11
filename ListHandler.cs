namespace OOP_Generic_Collections
{
    public class ListHandler : Employee
    {
        public ListHandler(string id, string name, string gender, decimal salary)
            : base(id, name, gender, salary)
        {
        }

        public static void FirstMaleObject(List<Employee> employeesList, string gender)
        {
            Employee firstMaleEmployee = employeesList.Find(e => e.Gender.Equals("Male"));

            // If Male isn't null, return first Male in Stack. Otherwise return No male gender found
            Console.WriteLine(firstMaleEmployee != null ? $"{firstMaleEmployee}\n" : "No employee with gender Male found\n");
        }

        public static void FindAllMaleObject(List<Employee> employees)
        {
            List<Employee> maleEmployees = employees.FindAll(e => e.Gender.Equals("Male"));

            // As long as Foreach loop find gender Male, print it out. Else print message No Male employees found.
            if (maleEmployees.Count > 0)
            {
                Console.WriteLine("All male employees:");
                foreach (var male in maleEmployees)
                {
                    Console.WriteLine($"{male}\n");
                }
            }
            else
            {
                Console.WriteLine("No Male employees found.");
            }
        }
    }
}