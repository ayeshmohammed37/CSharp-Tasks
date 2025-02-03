using System;
using System.Numerics;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initializes a one-dimensional array
            //// Initializing array using 'new int[size]'
            //int[] array1 = new int[5];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = i + 1;
            //}
            //Console.WriteLine("Array1 (using new int[size]):");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}
            //Console.WriteLine();


            ////  Initializing array using initializer list
            //int[] array2 = { 10, 20, 30, 40, 50 };
            //Console.WriteLine("\nArray2 (using initializer list):");
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.Write(array2[i] + " ");
            //}
            //Console.WriteLine();

            //// Initializing array using Array syntax sugar
            //int[] array3 = new int[] { 100, 200, 300, 400, 500 };
            //Console.WriteLine("\nArray3 (using Array syntax sugar):");
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write(array3[i] + " ");
            //}
            //Console.WriteLine();

            //// Demonstrating IndexOutOfRangeException
            //Console.WriteLine("IndexOutOfRangeException:");
            //Console.WriteLine(array1[10]);

            ////What is the default value assigned to array elements in C#?
            ///*
            // * depend on the type of the array
            // */
            #endregion


            #region shallow copy and deep copy
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2;

            //// Shallow copy
            //arr2 = arr1;
            //Console.WriteLine("arr1: ");
            //foreach (int e in arr1)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("arr2: ");
            //foreach (int e in arr2)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("------------------------------------------------");

            //arr1[0] = 99;
            //Console.WriteLine("arr1: ");
            //foreach (int e in arr1)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("arr2: ");
            //foreach (int e in arr2)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine("------------------------------------------------");
            ////deep copy using Clone
            //int[] arr3 = (int[])arr1.Clone();
            //Console.WriteLine("arr1: ");
            //foreach(int e in arr1)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("arr3: ");
            //foreach (int e in arr3)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine("------------------------------------------------");

            //arr1[1] = 88;
            //foreach (int e in arr1)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("arr3: ");
            //foreach (int e in arr3)
            //{
            //    Console.WriteLine(e);
            //}

            //What is the difference between Array.Clone() and Array.Copy() ?
            //Array.Clone:  Creates a shallow copy of the array.
            //Array.Copy:   Copies elements from one array to another.
            //

            #endregion

            #region 2D array
            //int[,] grades = new int[3, 3];

            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Enter grades for Student {student + 1}:");
            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write($"  Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nGrades for each student:");
            //for (int student = 0; student < 3; student++)
            //{
            //    Console.Write($"Student {student + 1}: ");
            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write(grades[student, subject] + " ");
            //    }
            //    Console.WriteLine();
            //}
            // What is the difference between GetLength() and Length for multidimensional arrays ?
            // Length will return the number of rows in the array
            // GetLength will return number of columns in the array
            #endregion

            #region 5 array methods
            //int[] arr = { 5, 2, 8, 1, 4 };
            //Console.WriteLine("Original Array: " + string.Join(", ", arr));

            //Array.Sort(arr);
            //Console.WriteLine("\nAfter Sort: " + string.Join(", ", arr));

            //Array.Reverse(arr);
            //Console.WriteLine("After Reverse: " + string.Join(", ", arr));

            //int index = Array.IndexOf(arr, 8);
            //Console.WriteLine("\nIndex of 8: " + index);

            //int[] copyArr = new int[5];
            //Array.Copy(arr, copyArr, arr.Length);
            //Console.WriteLine("\nCopied Array: " + string.Join(", ", copyArr));


            //Array.Clear(arr, 0, arr.Length);
            //Console.WriteLine("\nAfter Clear (all elements set to default): " + string.Join(", ", arr));

            //What is the difference between Array.Copy() and Array.ConstrainedCopy() ?
            /*
             * Array.Copy()
             * Copies elements from one array to another.
             * Copies elements from one array to another.
             * Array.ConstrainedCopy()
             * Similar to Array.Copy(), but it is specifically designed to
             * ensure type safety by enforcing runtime type-checking during copying.
             */


            #endregion

            #region looping
            //int[] arr = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();  

            //Console.WriteLine("Using foreach loop:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();  

            //Console.WriteLine("Using while loop (reverse order):");
            //int index = arr.Length - 1;  
            //while (index >= 0)
            //{
            //    Console.Write(arr[index] + " ");
            //    index--;
            //}
            //Console.WriteLine();
            //

            #endregion

            #region positive odd num
            //int number;
            //bool isValid;

            //do
            //{
            //    Console.Write("Please enter a positive odd number: ");
            //    string input = Console.ReadLine();
            //    isValid = int.TryParse(input, out number);

            //    if (isValid && number > 0 && number % 2 != 0)
            //    {
            //        Console.WriteLine($"You entered a valid positive odd number: {number}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive odd number.");
            //    }

            //} while (true);

            ////Why is input validation important when working with user inputs? 
            //// input validation is important to ensure that user inputs are correct, prevent errors

            #endregion


            #region 2D array 
            int[,] matrix =
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            Console.WriteLine("Matrix (2D Array):");
            for (int i = 0; i < matrix.GetLength(0); i++)  
            {
                for (int j = 0; j < matrix.GetLength(1); j++)  
                {
                    Console.Write(matrix[i, j] + "\t");  
                }
                Console.WriteLine();  
            }
            #endregion


            #region month number
            //Console.Write("Enter a month number (1-12): ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //string monthNameIfElse = "";
            //if (monthNumber == 1) monthNameIfElse = "January";
            //else if (monthNumber == 2) monthNameIfElse = "February";
            //else if (monthNumber == 3) monthNameIfElse = "March";
            //else if (monthNumber == 4) monthNameIfElse = "April";
            //else if (monthNumber == 5) monthNameIfElse = "May";
            //else if (monthNumber == 6) monthNameIfElse = "June";
            //else if (monthNumber == 7) monthNameIfElse = "July";
            //else if (monthNumber == 8) monthNameIfElse = "August";
            //else if (monthNumber == 9) monthNameIfElse = "September";
            //else if (monthNumber == 10) monthNameIfElse = "October";
            //else if (monthNumber == 11) monthNameIfElse = "November";
            //else if (monthNumber == 12) monthNameIfElse = "December";
            //else monthNameIfElse = "Invalid month number";

            //Console.WriteLine("Month Name using if-else: " + monthNameIfElse);
            #endregion




        }
    }
}
