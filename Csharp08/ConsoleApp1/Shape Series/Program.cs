namespace Shape_Series
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Square Series:");
            PrintTenShapes(new SquareSeries());
            Console.WriteLine("\nCircle Series:");
            PrintTenShapes(new CircleSeries());

            List<Shape> shapes = new List<Shape>
            {
                new Shape("Square", 25),
                new Shape("Circle", Math.PI * 4 * 4),
                new Shape("Rectangle", 6 * 8)
            };

            shapes.Sort();
            Console.WriteLine("\nSorted Shapes by Area:");
            foreach (var shape in shapes) Console.WriteLine(shape);

            GeometricShape triangle = new Triangle(3, 4);
            GeometricShape rectangle = new Rectangle(5, 7);

            Console.WriteLine("\nGeometric Shapes:");
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.Perimeter}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.Perimeter}");

        }
        static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.CurrentShapeArea);
                series.GetNextArea();
            }
            series.ResetSeries();
        }
    }

    interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }
    class SquareSeries : IShapeSeries
    {
        private int side = 1;
        public int CurrentShapeArea { get; set; } = 1;

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 1;
            CurrentShapeArea = 1;
        }
    }
    class CircleSeries : IShapeSeries
    {
        private int radius = 1;
        public int CurrentShapeArea { get; set; } = (int)(Math.PI * 1 * 1);

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = (int)(Math.PI * 1 * 1);
        }
    }
    class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape other)
        {
            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} with Area: {Area:F2}";
        }
    }
    abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public GeometricShape(double dim1, double dim2)
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
    class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height) : base(baseLength, height) { }
        public override double CalculateArea() => 0.5 * Dimension1 * Dimension2;
        public override double Perimeter => Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); // Assuming right triangle
    }
    class Rectangle : GeometricShape
    {
        public Rectangle(double width, double height) : base(width, height) { }
        public override double CalculateArea() => Dimension1 * Dimension2;
        public override double Perimeter => 2 * (Dimension1 + Dimension2);
    }

}
