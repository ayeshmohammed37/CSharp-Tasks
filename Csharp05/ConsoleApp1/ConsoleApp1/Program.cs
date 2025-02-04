namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DivideByZeroException
            //Console.Write("Enter Two Intgers: ");
            //string str = Console.ReadLine();
            //int num1 = Convert.ToInt32(str.Split(" ")[0]);
            //int num2 = Convert.ToInt32(str.Split(" ")[1]);
            //try
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation Complete");
            //}
            // the finally block will always excuted even if try or catch block excuted
            // so it will be good if you want to make any cleanup in this block
            #endregion

            #region TestDegensiveCode
            //try
            //{
            //    TestDegensiveCode();
            //}
            //catch (NegativeNumber ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // parse if throw an exception when some thing is wrong or a null but
            // tryparse is give true or false not throwing exception and return 0 if you give it null value
            #endregion

            #region null.HasValue and null.Value
            //int? n = null;
            ////n ??= 0;
            //Console.WriteLine(n);
            //Console.WriteLine(n.HasValue);
            //try
            //{
            //    Console.WriteLine(n.Value);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("n.Value throw exception if n is null");
            //    Console.WriteLine(ex.Message);
            //}
            // exception occurs when trying to access Value on a null: InvalidOperationException
            #endregion

            #region out of range array
            //int[] arr = new int[5];
            //try
            //{
            //    Console.WriteLine(arr[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // if you try to access element out of range the array the compiler will
            // throw exception and if it's not checking then you will get random data
            // from memory that's not good for your program
            #endregion

            #region 3x3 arr
            //int[,] arr = new int[3, 3];
            //int rowSum = 0;
            //int colSum = 0;

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"enter value for arr[{i+1}, {j+1}]: ");
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0;i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        rowSum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum of elements in {1+i} row: {rowSum}");
            //    rowSum = 0;
            //}

            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        colSum += arr[j, i];
            //    }
            //    Console.WriteLine($"Sum of elements in {1 + i} Col: {colSum}");
            //    colSum = 0;
            //}
            //Console.WriteLine(arr.GetLength(2));
            // get length used to get the dimension of specific length in the multi dimension array
            // arr[3,5,6] arr.getlength(2) = 6
            #endregion

            #region jagged array
            //int[][] arr = new int[3][];
            //int choice;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter number of cols in {i + 1} row:");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = new int[choice];
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"Enter Value of arr[{i + 1}, {j + 1}]: ");
            //        arr[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Matrix = ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]}, ");
            //    }
            //    Console.WriteLine();
            //}
            // rectangular arrays are fixed size so maybe memory allocate block of memory for elements we don't need them
            // jagged arrays are not fixed in size so at memry allocates the block of memory that we need
            #endregion

            #region nullable reference types
            //string? str;
            //string s = Console.ReadLine();
            //if (s == "null")
            //{
            //    str = null;
            //    Console.WriteLine(str!);
            //}
            //else
            //{
            //    str = s;
            //    Console.WriteLine(str);
            //}
            //  help you find potential null reference errors in your code.
            //  There's no runtime difference between a non-nullable reference
            //  type and a nullable reference type
            // C# Docs Nullable reference types (C# reference
            #endregion

            #region Boxing and UNBoxing
            //// boxing
            //int x = 11;
            //Object obj = x;
            //Console.WriteLine($"value type = {x}, boxing it {obj}");
            //// unboxing
            //try
            //{
            //    int y = (int)obj;
            //    Console.WriteLine($"Unboxing object to value type: {y}");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Boxing and unboxing are computationally expensive processes.
            //When a value type is boxed, an entirely new object must be created.
            //This can take up to 20 times longer than a simple reference assignment.
            //When unboxing, the casting process can take four times as long as an assignment.
            #endregion

            #region out parameters 
            //SumAndMultiply(3, 2, out int s, out int m);
            //Console.WriteLine($"3 + 2 = {s},\n3 * 2 = {m}");
            // because out parameters used to return values from the method 
            // so we can guarante the user will recive valid data
            #endregion

            #region print string n times
            //PrintStringNTimes("hello!");
            //Console.WriteLine();
            //PrintStringNTimes("hello!", 5);
            //Console.WriteLine();
            //PrintStringNTimes(n:2,txt:"hello!");
            // clarity and consistency in parameter assignment
            #endregion

            #region nullable array
            //int[]? arr = null;
            //Console.WriteLine(arr?.Length);
            // If the varibale is null, the operator returns
            // null instead of throwing a NullReferenceException
            #endregion

            #region Switch Expression
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();
            //int dayNumber = day.ToLower() switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => -1 
            //};
            //var result = dayNumber == -1? "Invalid day entered." : $"The corresponding number for {day} is: {dayNumber}";
            //Console.WriteLine(result);
            #endregion

            #region SumArray 
            //// with an individual values
            //int sum1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine($"Sum of individual values: {sum1}");

            ///// with an array
            //int[] numbers = { 10, 20, 30, 40 };
            //int sum2 = SumArray(numbers);
            //Console.WriteLine($"Sum of array: {sum2}");
            // it must be the last parameter for the method defintion
            // and just one oarma allowed no more than one
            #endregion

            #region postive ints in Range
            //Console.Write("Enter a positive integer: ");
            //if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.Write(i);
            //        if (i < number)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion

            #region Multiplication Table
            //Console.Write("Enter an integer: ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(number * i);
            //        if (i < 12)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter an integer.");
            //}
            #endregion

            #region Even Numbers 
            //Console.Write("Enter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            //{
            //    for (int i = 2; i <= number; i += 2)
            //    {
            //        Console.Write(i);
            //        if (i < number - 1)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion

            #region Compute Exponentiation
            //Console.Write("Enter  base and exponent: ");
            //string str = Console.ReadLine();
            //if (int.TryParse(str.Split(" ")[0], out int baseNum))
            //{
            //    if (int.TryParse(str.Split(" ")[1], out int exponent))
            //    {
            //        long result = (long)Math.Pow(baseNum, exponent);
            //        Console.WriteLine($"{result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer for the exponent.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter an integer for the base number.");
            //}
            #endregion

            #region Reverse string 
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray); 
            //string reversedString = new string(charArray);

            //Console.WriteLine("Reversed string: " + reversedString);
            #endregion

            #region Reverse Integer
            //Console.Write("Enter an integer: ");
            //string number = Console.ReadLine();
            //Console.Write("Reversed integer: ");
            //for (int i = number.Length -1; i >= 0; i-- )
            //{
            //    Console.Write(number[i]);
            //}           
            #endregion

            #region Reverse Sentence 
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //string reversedSentence = string.Join(" ", words);
            //Console.WriteLine("Reversed sentence: " + reversedSentence); 
            #endregion
        }

        public static void TestDegensiveCode()
        {
            int X, Y, Z;
            //bool flag;
            do
                Console.WriteLine("enter first number :");
            while (!int.TryParse(Console.ReadLine(), out X));
            if (X < 0)
                throw new NegativeNumber("X is Negatrive Number");

            do
                Console.WriteLine("enter second number :");
            while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);
            if (Y < 0)
                throw new NegativeNumber("Y is Negatrive Number");
            if (Y <= 1)
                throw new LessThanOne("Y is Less Than or equal to one");

            Z = X / Y;

            int[] arr = { 1, 2, 3, 4 };
            if (arr?.Length > 108)
                arr[108] = 78;
        }
        public static void SumAndMultiply(int x, int y, out int sum, out int multi)
        {
            sum = x + y;
            multi = x * y;
        }
        public static void PrintStringNTimes(string txt, int n = 3)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(txt);
            }
        }

        static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
    public class NegativeNumber : Exception
    {
        public NegativeNumber(string massege) : base(massege)
        {

        }

        public void PrintMassege()
        {
            Console.WriteLine("you entered Negative Number!!");
        }
    }

    public class LessThanOne : Exception
    {
        public LessThanOne(string massege) : base(massege)
        {

        }
    }
}
