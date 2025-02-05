using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region constructor
            //Car car1 = new Car();
            //Car car2 = new Car(1);
            //Car car3 = new Car(2, "Toyota");
            //Car car4 = new Car(3, "Ford", 25000.50);
            //Console.WriteLine($"Car1: {car1}\nCar2: {car2}\ncar3: {car3}\ncar4: {car4}");
            // the compiler is define a default construcor for the class, it takes no arguments
            // but if define a constructor by yourself, the compiler will cancel the default constructor automatically 
            #endregion

            #region OverLoading
            //Calculator calc = new Calculator();
            //Console.WriteLine($"5 + 10 = {calc.Sum(5, 10)}");
            //Console.WriteLine($"2 + 4 + 6 = {calc.Sum(2, 4, 6)}");
            //Console.WriteLine($"3.5 + 7.2 = {calc.Sum(3.5, 7.2)}");
            // its reduce the complex of the code and make it easy for reading 
            // and more easy for client, you can use the same method to work on 
            // different data types 
            #endregion

            #region inheritance 
            //Child child = new Child(10, 20, 30);
            //Console.WriteLine($"Child X: {child.X}\nChild Y: {child.Y}\nChild Z: {child.Z}");
            // to avoid code dublicate and in inheritance The base class might have its own
            // initialization constructor, the Constructor chaining allows the derived class
            // to call the base class's constructor to ensure that these inherited members are properly initialized 
            #endregion

            #region override
            //Child child = new Child(2, 3, 4);
            //Console.WriteLine(child.Product());
            // Replaces the base class method
            // it creates a new method in the child class
            // that has the same name as the base class method
            // but is hide it. 
            #endregion

            #region ToString 
            //Parent parent = new Parent(10, 20);
            //Child child = new Child(10, 20, 30);
            //Console.WriteLine(parent);
            //Console.WriteLine(child);
            //Parent poly = child;
            //Console.WriteLine(poly); 
            #endregion

            #region Interface
            //Rectangle rectangle = new Rectangle(5, 10);
            //Console.WriteLine($"Area: {rectangle.Area}");
            //rectangle.Draw();
            // interface defines what a class should do, but not how it should do it. 
            #endregion

            #region default implementation of a method
            //Circle circle = new Circle(5);
            //Console.WriteLine($"Circle Area: {circle.Area}");
            //circle.Draw();
            //circle.PrintDetails(); 
            #endregion

            #region IMovable 
            //Car myCar = new Car();
            //myCar.Brand = "Toyota Camry";
            //myCar.Price = 60;
            //IMovable movableVehicle = myCar;
            //movableVehicle.Move(); 
            #endregion

            #region  IReadable and IWritable
            //File myFile = new File();
            //myFile.Write("This is some data to write.");
            //Console.WriteLine($"File content: {myFile.Read()}");
            // in C# a class can only inherit from one base class
            // by allowing a class to implement multiple interfaces.
            // This provides a way for a class to inherit multiple behaviors,
            // even though it can only inherit implementation from a single base class. 
            #endregion
        }
    }
    public interface IMovable
    {
        void Move();
    }
    public class Car : IMovable
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }
        public Car(int id)
        {
            Id = id;
            Brand = "Unknown";
            Price = 0.0;
        }
        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0.0;
        }
        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
        public override string ToString()
        {
            return $"ID: {Id}, Brand: {Brand}, Price: {Price}";
        }
    }
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual int Product()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    public class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        //public new int Product() 
        //{
        //    return X * Y * Z;
        //}
        public override int Product() // 'override' keyword replaces the base class method
        {
            return X * Y * Z;
        }
        public override string ToString() 
        {
            return $"({X}, {Y}, {Z})";
        }
    }
    public interface IShape
    {
        double Area { get; }
        void Draw();
        public void PrintDetails()
        {
            Console.WriteLine($"Shape details: Area = {Area}");
        }
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area
        {
            get { return Width * Height; }
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Circle details: Radius = {Radius}, Area = {Area}");
        }
    }
    public interface IReadable
    {
        string Read();
    }
    public interface IWritable
    {
        void Write(string data);
    }
    public class File : IReadable, IWritable
    {
        private string _content;

        public File()
        {
            _content = "";
        }

        public string Read()
        {
            return _content;
        }

        public void Write(string data)
        {
            _content = data;
        }
    }

}
