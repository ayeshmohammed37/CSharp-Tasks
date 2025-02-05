namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IVehicle
            //IVehicle myCar = new Car();
            //IVehicle myBike = new Bike();
            //myCar.StartEngine();
            //myCar.StopEngine();
            //myBike.StartEngine();
            //myBike.StopEngine();
            // It promotes flexibility, scalability, and easier maintenance 
            #endregion

            #region Shape
            //Shape rect = new Rectangle(5, 10);
            //Shape circ = new Circle(7);
            //Console.WriteLine("Rectangle Area: " + rect.GetArea());
            //Console.WriteLine("Circle Area: " + circ.GetArea());
            // prefer an abstract class over an interface When you want to
            // provide both common functionality and enforce a structure. 
            #endregion

            #region IComparable
            //Product[] products = {
            //new Product { Id = 1, Name = "Laptop", Price = 1200 },
            //new Product { Id = 2, Name = "Phone", Price = 800 },
            //new Product { Id = 3, Name = "Tablet", Price = 400 }
            //};
            //Array.Sort(products);
            //foreach (var product in products)
            //    Console.WriteLine($"{product.Name}: ${product.Price}");
            //// implementing IComparable improve flexibility in sorting,
            //// It allows custom sorting logic, making sorting more adaptable. 
            #endregion

            #region copy constructor 
            //Student student1 = new Student{ Id = 1, Name = "Alice", Grade = 90 };
            //Student student2 = new Student(student1);
            //Console.WriteLine($"Student Copy - Name: {student2.Name}, Grade: {student2.Grade}");
            //// a copy constructor To create a new object as a copy of an existing object. 
            #endregion

            #region IWalkable
            //IWalkable robot = new Robot();
            //robot.Walk();
            //// It allows a class to implement multiple interfaces with the same method name. 
            #endregion

            #region Account
            //Account acc = new Account { AccountId = 101, AccountHolder = "John", Balance = 5000 };
            //Console.WriteLine($"Account Holder: {acc.AccountHolder}, Balance: {acc.Balance}");
            //// Structs are value types, while classes are reference types. 
            #endregion

            #region ILogger
            //ILogger logger = new ConsoleLogger();
            //logger.Log("Logging message.");
            //// They allow adding new methods to interfaces without breaking existing implementations. 
            #endregion

            #region Book
            //Book book1 = new Book("C# Programming");
            //Book book2 = new Book("C# Programming", "John Doe");
            //Console.WriteLine($"Book1 Title: {book1.Title}, Author: {book1.Author}");
            //Console.WriteLine($"Book2 Title: {book2.Title}, Author: {book2.Author}");
            //// It provides multiple ways to initialize an object based on available data. 
            #endregion

        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book() { }
        public Book(string title) { Title = title; }
        public Book(string title, string author) { Title = title; Author = author; }
    }
    interface ILogger
    {
        void Log(string message) => Console.WriteLine("Default Log: " + message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("Custom Log: " + message);
    }
    struct Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;
        public int AccountId { get => accountId; set => accountId = value; }
        public string AccountHolder { get => accountHolder; set => accountHolder = value; }
        public double Balance { get => balance; set => balance = value; }
    }
    interface IWalkable
    {
        void Walk();
    }

    class Robot : IWalkable
    {
        void IWalkable.Walk() => Console.WriteLine("Robot walking as per interface.");
        public void Walk() => Console.WriteLine("Robot walking normally.");
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Student(Student other) => (Id, Name, Grade) = (other.Id, other.Name, other.Grade);
        public Student()
        {
            
        }
    }
    class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CompareTo(Product other) => Price.CompareTo(other.Price);
    }
    abstract class Shape
    {
        public abstract double GetArea();
        public void Display() => Console.WriteLine("Displaying shape...");
    }
    class Rectangle : Shape
    {
        private double width, height;
        public Rectangle(double w, double h) { width = w; height = h; }
        public override double GetArea() => width * height;
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double r) { radius = r; }
        public override double GetArea() => Math.PI * radius * radius;
    }
    interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }
    class Car : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Car engine started.");
        public void StopEngine() => Console.WriteLine("Car engine stopped.");
    }

    class Bike : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Bike engine started.");
        public void StopEngine() => Console.WriteLine("Bike engine stopped.");
    }

}
