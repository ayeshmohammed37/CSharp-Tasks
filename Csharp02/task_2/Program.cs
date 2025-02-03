using System;
using Microsoft.VisualBasic;

namespace task_2
{
    internal class Program
    {
        public class Point
        {
            public int x;
            public int y;
        }
        static void Main()
        {
            #region Comments
            ///* crate interger varible x = 10
            //     y =20 */
            //int x = 10;
            //int y = 20;
            //// add x to y and store them in the integer varible called sum
            //int sum = x + y;
            ////write the sum as output in the console
            //Console.WriteLine(sum); 
            #endregion

            #region Comment Shortcut
            /*the shortcut to comment and uncomment
                    ctrl + / 
                */
            #endregion

            #region fix the errors
            ///* you can't sotre string in integer var
            //y is not declared
            //*/
            ////int x = "10";
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y); 
            #endregion

            #region runtime and logical error
            /*
                 runtime error happening during the program 
                 excution ex: invalid operation
                */
            //int x = 1 / 0;
            /*
             logical error a mistake in the logic of the code
             lead to incorrect output
            */
            //int l = 1;
            //int areaOfRec = 1 + 1 + 1 + 1; // it should be 1*1 
            #endregion

            #region Declare Varibles
            //string fullName = "Ayesh Mohammed";
            //int age = 25;
            //double monthlySalary = 000.0;
            //bool isStudent = true; 
            #endregion

            #region namming conventions
            /*
                 it's make easy to read or debug the code and in general 
                 the team members should follow a standared and certain naming convention
                */
            #endregion

            #region changing value of ref type
            //Point p1 = new Point();
            //Point p2 = new Point();

            //p1.x = 1;
            //p2.x = 2;
            //p1.y = 3;
            //p2.y = 4;
            //p2 = p1;

            //p2.x = 6;
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p1.x);
            #endregion

            #region difference between ref and value types
            // Value type:
            // int x = 5;
            // the program goes to the stack and allocate 4 byte memory for var x
            // Ref type:
            // Point p = new Point()
            // the program going to the stack and allocate memory for varible p which will store a refrence to 
            // Point object int the heap
            #endregion

            #region Calculates
            //double x = 15;
            //double y = 4;
            //double sum = x + y
            //double sub = x - y;
            //double pro = x * y;
            //double div = x / y;
            //double rem = x % y; 
            #endregion

            #region find the output
            //int a = 2, b = 7;
            //Console.WriteLine(a % b); // 2
            //// a < b  so it will return 2
            #endregion

            #region check the number
            //int x = 15;
            //bool check = x > 10 && x % 2 == 0;
            #endregion

            #region logicat and bitwise AND operator
            //logical
            //if (3 > 0 && 4 < 10)
            //{
            //    Console.WriteLine("logical");
            //}
            // the logical && it compare two conditions true && false....
            //// bitwise
            //int u = 6 & 3; //2
            // compare bit by bit so it will compare 110(6) & 011(3) = 010(2)
            #endregion

            #region Casting
            //Console.Write("Enter a double value: ");
            //double doubleValue = double.Parse(Console.ReadLine());
            //int explicitCast = (int)doubleValue;
            //int implicitAlternative = Convert.ToInt32(doubleValue);
            //Console.WriteLine($"value: {doubleValue}");
            //Console.WriteLine($"explicit casting: {explicitCast}");
            //Console.WriteLine($"Convert.ToInt32: {implicitAlternative}");
            #endregion


            #region explict casting
            //because the conversion involves data loss
            #endregion

            #region Working with age
            //Console.Write("Enter your Age: ");
            //var age = int.Parse(Console.ReadLine());
            //bool ageGraterThan10 = age > 10;
            //Console.WriteLine($"Age is grater than 10: {ageGraterThan10}");
            //System.FormatException: Input string was not in a correct format.
            // we can use Tryparse
            //if(!int.TryParse(Console.ReadLine(), out int age))
            //{
            //    Console.WriteLine("Invalit Age");
            //}
            //else
            //{
            //    Console.WriteLine($"Age is grater than 10: {age > 10}");
            //}
            #endregion

            #region post and prefix increment
            //int x = 3;
            //Console.WriteLine(x++); // 3
            //Console.WriteLine(++x); // 5
            //Console.WriteLine(--x); // 4
            //Console.WriteLine(x--); // 4 
            #endregion

            #region value of x
            //int x = 5;
            //int y = ++x + x++;
            // x = 7(1.++x = 6, x++ = 7), y = (6 + 6)= 12
            //Console.WriteLine($"x = {x}\ny = {y}");
            #endregion
        }
    }
}
