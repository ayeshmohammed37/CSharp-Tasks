namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Point Struct 
            //Point point = new Point();
            //Console.WriteLine(point); 
            // structs stored in the stack not in the heap and they are value type not refrence type
            // so for that it can not be inherited
            #endregion

            #region Class TypeA 
            //TypeA obj = new TypeA(1, 2, 3);
            //Console.WriteLine($"H: {obj.H}");
            //Console.WriteLine($"G: {obj.G}");
            //Console.WriteLine($"F: {obj.GetF()}"); 
            // it's control the scope and visibilty of clss members
            // so the enhance and enforce the OOP concepts like Abstraction
            //  Encapsulation,...
            #endregion

            #region Employee Class
            //Employee emp = new Employee(123, "Ayesh", 1222);
            //Console.WriteLine($"Name: {emp.Name}\nID: {emp.EmpId}\nSalary: {emp.Salary}"); 
            // nhances code readability, allowing a focus on the logic flow rather
            // than intricate inner workings, Encapsulation helps in isolating
            // implementation details from the behavior exposed to clients of a class
            // and give you more control on the code
            #endregion

            #region Constructor override 
            //Point p1 = new Point(5);
            //Point p2 = new Point(10, 20);
            //Point p3 = new Point();
            //Console.WriteLine(p1 + ", " + p2 + ", " + p3);
            // constructor is special method thad called when struct or class
            // is created, any stuct or class have a default construcor and you
            // can override it or inherit it
            #endregion

            #region Class vs Struct 
            //Point p = new Point(10, 20);
            //Console.WriteLine("Before: " + p);
            //ChangePoint(p);
            //Console.WriteLine("After: " + p);

            //Employee emp = new Employee("John Doe", 30);
            //Console.WriteLine("\nBefore: " + emp);
            //ChangeEmp(emp);
            //Console.WriteLine("After: " + emp); 
            // struct stored in stack but class stored in heap and refrence for the
            // object in the stack
            #endregion
        }

        static void ChangePoint(Point point)
        {
            point.X = 100;
            point.Y = 200;
        }
        static void ChangeEmp(Employee employee)
        {
            employee.Name = "Jane Doe";
            employee.Age = 35;
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(int x)
        {
            X = x;
            Y = 0;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class TypeA
    {
        private int F;
        internal int G;
        public int H;

        public TypeA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }
        public int GetF()
        {
            return F;
        }
    }

    //public struct Employee
    //{
    //    private int _empId;
    //    private string _name;
    //    private double _salary;
    //    public int EmpId
    //    {
    //        get { return _empId; }
    //    }
    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
    //    public double Salary
    //    {
    //        get { return _salary; }
    //        set { _salary = value; }
    //    }
    //    public Employee(int empId, string name, double salary)
    //    {
    //        _empId = empId;
    //        _name = name;
    //        _salary = salary;
    //    }
    //}

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Employee [Name: {Name}, Age: {Age}]";
        }
    }
}
