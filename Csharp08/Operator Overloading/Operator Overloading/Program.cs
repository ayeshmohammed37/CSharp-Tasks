using System.Drawing;

namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(3, 4);
            Point p2 = new Point(5, 6);

            Point result = p1 + p2; 
            Console.WriteLine(result);

            result = p1 - p2;
            Console.WriteLine(result);

            result = p1 * p2;
            Console.WriteLine(result);

            result = p1 / p2;
            Console.WriteLine(result);

        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }
        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.X / p2.X, p1.Y / p2.Y);
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
