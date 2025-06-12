namespace Assignment_10._2_2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
{
    new Employee { Name = "Alice", Age = 30, Salary = 50000 },
    new Employee {Name = "Bob", Age = 25, Salary = 60000 },
    new Employee { Name = "Charlie", Age = 35, Salary = 70000 }
};

            var solution = employees.Where(e => e.Age < 30 && e.Salary > 5000);

            foreach (var employee in solution)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }

            Console.ReadKey();
        }
    }
}
