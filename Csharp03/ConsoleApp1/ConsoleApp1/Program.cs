using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region handell null into parse and Convert
            //try
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(x);
            //}
            //catch(Exception ex) 
            //{
            //        Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine(x);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //int x = Convert.ToInt32(null);
            //int y = int.Parse(null);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //// https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-9.0
            //// from docs Convert.ToInt32 return 0 if the input is null. 
            //// https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-9.0
            //// for parse(null) return ArgumentNullException 
            #endregion

            #region Tryparse
            //Console.Write("Enter Number: ");
            //var input = Console.ReadLine();
            //if(int.TryParse(input, out int result))
            //{
            //    Console.WriteLine($"the number is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR: you should enter right number");
            //}

            ///*
            // * Parse throw exception if it can't parse the value
            // * Tryparse contains try/catch internally and it's 
            // * implemented without exceptions so that it is fast 
            // * actully the parse method will call tryparse 
            // * and then throw the exception if it's return false
            // * https://stackoverflow.com/questions/467613/parse-v-tryparse
            // * https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-9.0
            // * from microsoft docs:
            // * Remarks
            // *The TryParse method is like the Parse method, except
            // *the TryParse method does not throw an exception if the
            // *conversion fails. It eliminates the need to use exception handling
            // *to test for a FormatException in the event that s is invalid and 
            // *cannot be successfully parsed.
            // */ 
            #endregion

            #region GetHashCode
            //Object x = new Object();
            //x = 10;
            //Console.WriteLine(x.GetHashCode());
            //x = 3.333m;
            //Console.WriteLine(x.GetHashCode());
            ///*
            // * the hash code is used to identify objects in hash-based collections.
            // * It helps improve the performance of lookups, insertions, and deletions in these collections.
            // */ 
            #endregion

            #region Objects References
            //var obj1 = new A();
            //obj1.Value = 1;
            //var obj2 = obj1;
            //obj2.Value = 2;
            //Console.WriteLine(obj1.Value);
            //Console.WriteLine(ReferenceEquals(obj1, obj2));
            #endregion

            #region string
            //string s1 = "hello, "; // create object string s1 in memory and assign "hello, "
            //Console.WriteLine(s1.GetHashCode());  // write the hashcode for s1 12345231332
            //s1 += "Hi Willy";  // create new string in memory and assign it to s1 and destroy the old string
            //Console.WriteLine(s1.GetHashCode()); // write the hashcode of the new string in memory 999987828
            // strings are immutable in C# for security and Memory efficiency 
            #endregion

            #region StringBuilder
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(",Nice to meet you!");
            //Console.WriteLine(sb.GetHashCode());
            //// when you modify a stingbuilder it update the current string buffer not create new one so
            //// more memory efficent 
            #endregion

            #region string formating
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //Console.WriteLine(x+y);
            //Console.WriteLine(string.Format("{0}", x+y));
            //Console.WriteLine($"{x+y}");
            //// I think string interpolation it's easy 
            #endregion

            #region stringbuilderMethods
            //StringBuilder sb = new StringBuilder();
            //sb.Append("hello world");
            //sb.Replace("hello", "hi");
            //sb.Insert(2, " ahmed");
            //Console.WriteLine(sb.ToString());
            //sb.Remove(3, 4);
            //Console.WriteLine(sb.ToString()); 
            // stringBuilder is mutable and have alot of methodes that can help me to play with strings
            #endregion

        }

        public class A
        {
            public int Value;
        }

    }
}
