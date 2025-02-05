namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Weekdays
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day}: {(int)day}");
            //}
            ////when the exact values need to be preserved 
            #endregion

            #region Enum Grades 
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade}: {(short)grade}");
            //}
            //a compile-time error will occur
            #endregion

            #region Person Class
            //Person person1 = new Person() { Id = 1, Name = "Alice", Gender = Gender.Female, Department = "HR" };
            //Person person2 = new Person() { Id = 2, Name = "Bob", Gender = Gender.Male, Department = "Engineering" };

            //Console.WriteLine(person1.Details);
            //Console.WriteLine(person2.Details);
            //allows a property to be overridden in a derived class.
            #endregion

            #region Utility Class 
            //Console.WriteLine($"10 cm in inches: {Utility.CmToInch(10)}");
            //Console.WriteLine($"Circle area with radius 5: {Utility.CalcCircleArea(5)}");
            // Static members belong to the type itself, They are accessed using the class name.
            // Object members belong to instances of the class and require an object to access them.
            #endregion

            #region ComplexNumber Class
            //ComplexNumber num1 = new ComplexNumber { Real = 2, Imag = 3 };
            //ComplexNumber num2 = new ComplexNumber { Real = 1, Imag = 4 };

            //ComplexNumber result = num1 * num2;
            //Console.WriteLine($"Result of multiplication: {result}");
            //Not all operators can be overloaded in C#. For example,
            //the sizeof, is, and new operators cannot be overloaded.
            #endregion

            #region Gender Enum 
            //Console.WriteLine($"Gender Male: {(byte)Gender.Male}");
            //Console.WriteLine($"Gender Female: {(byte)Gender.Female}");

            //Console.WriteLine("Memory size of Gender enum: " + sizeof(byte) + " bytes");
            //when memory usage is a concern
            #endregion

            #region Temperature Conversion 
            //double celsius = 25;
            //double fahrenheit = 77;

            //Console.WriteLine($"{celsius}°C = {Utility.CelsiusToFahrenheit(celsius)}°F");
            //Console.WriteLine($"{fahrenheit}°F = {Utility.FahrenheitToCelsius(fahrenheit)}°C");
            //because it is not meant to be instantiated. A static class
            //is designed to contain static members that are accessed without creating an object.
            #endregion

            #region Employee Class with Equals Method 
            //Employee emp1 = new Employee(101, "Alice", 5000, 30);
            //Employee emp2 = new Employee(102, "Bob", 6000, 25);
            //Employee emp3 = new Employee(101, "Alice", 5000, 30);

            //Employee[] employees = { emp1, emp2 };

            //Employee found = Helper2<Employee>.SearchArray(employees, emp3);

            //if (found.Equals(default(Employee)))
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //else
            //{
            //    Console.WriteLine($"Found: {found}");
            //}
            //Equals method is used to compare the contents of objects,
            //while the == operator compares object references (for classes) or values (for structs)
            #endregion

            #region Non-generic Swap Method for Rectangle Struct
            //Rectangle rect1 = new Rectangle(5, 10);
            //Rectangle rect2 = new Rectangle(7, 12);

            //Console.WriteLine("Before Swap:");
            //Console.WriteLine($"Rect1: {rect1}");
            //Console.WriteLine($"Rect2: {rect2}");

            //Swap(ref rect1, ref rect2);

            //Console.WriteLine("After Swap:");
            //Console.WriteLine($"Rect1: {rect1}");
            //Console.WriteLine($"Rect2: {rect2}");

            #endregion
        }
        public static void Swap(ref Rectangle rect1, ref Rectangle rect2)
        {
            Rectangle temp = rect1;
            rect1 = rect2;
            rect2 = temp;
        }
    }
    enum Weekdays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Grades : short
    {
        A = 90,
        B = 80,
        C = 70,
        D = 60,
        E = 50,
        F = -1 
    }
    
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; } 
        public virtual string Details => $"{Name} - {Department}";
    }
    internal static class Utility
    {
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double CalcCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = left.Real + right.Real,
                Imag = left.Imag + right.Imag,
            };
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = left.Real - right.Real,
                Imag = left.Imag - right.Imag,
            };
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = left.Real * right.Real - left.Imag * right.Imag,
                Imag = left.Real * right.Imag + left.Imag * right.Real,
            };
        }
    }
    enum Gender : byte
    {
        Male = 1,
        Female
    }
    internal struct Employee
    {
        private int EmpID;
        private string EmpName;
        private decimal empsalary;

        public string GetName() => EmpName;
        public void SetName(string value) => EmpName = value.Length <= 20 ? value : value.Substring(0, 20);
        public decimal Salary { get => empsalary; set => empsalary = value < 4000 ? 4000 : value; }
        public int Age { get; set; }

        public Employee(int id, string name, decimal salary, int age)
        {
            EmpID = id;
            EmpName = name;
            empsalary = salary;
            Age = age;
        }
        public override string ToString() => $"Emp Id: {EmpID}, Name: {EmpName}, Salary: {empsalary}, Age: {Age}";

        // Implementing Equals method
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.EmpID == other.EmpID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmpID.GetHashCode();
        }
    }
    class Helper2<T>
    {
        public static T SearchArray(T[] array, T item)
        {
            foreach (var element in array)
            {
                if (element.Equals(item))
                {
                    return element;
                }
            }
            return default;
        }
    }
    struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString() => $"Length: {Length}, Width: {Width}";
    }

}
