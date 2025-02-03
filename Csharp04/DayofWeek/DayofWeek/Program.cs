using System;
using System.Numerics;
using System.Text;

class Program
{
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    static void Main()
    {
        Console.Write("Enter a number between 1 and 7: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= 1 && input <= 7)
        {
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());

            Console.WriteLine("The day corresponding to number " + input + " is: " + day);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
        }

        //What happens if the user enters a value outside the range of 1 to 7 ?
        //Invalid input!Please enter a number between 1 and 7.


    }
}
