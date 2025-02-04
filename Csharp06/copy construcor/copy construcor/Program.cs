namespace copy_construcor
{
    /*
     * A copy constructor is a constructor that initializes a new object by copying the values 
     * of an existing object of the same type.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("John Doe", 30);
            Console.WriteLine("emp1: " + emp1);

            Employee emp2 = new Employee(emp1);
            Console.WriteLine("Copied emp2: " + emp2);
            Console.WriteLine();

            emp1.Name = "Jane Doe";
            emp1.Age = 35;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("emp1: " + emp1);
            Console.WriteLine("emp2: " + emp2);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Copy constructor
        public Employee(Employee other)
        {
            Name = other.Name;
            Age = other.Age;
        }
        public override string ToString()
        {
            return $"Employee [Name: {Name}, Age: {Age}]";
        }
    }
}
