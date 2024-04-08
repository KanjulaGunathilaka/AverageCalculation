using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This app will calculate the average of four numbers entered by the user.
            //Declaring variables
            int num1, num2,num3,num4,average;

            //Display message of the app
            Console.Write("\n\n App to calculate the average of four numbers \n\n");
            Console.Write("---------------------------------\n");

            //Display message for the user to enter the first number
            Console.WriteLine("Enter the first number");

            //User enter the number that converts to integer
            num1 = Convert.ToInt32(Console.ReadLine());

            //Display message for the user to enter the second number
            Console.WriteLine("Enter the second number");

            //User enter the number that converts to integer
            num2 = Convert.ToInt32(Console.ReadLine());


            //Display message for the user to enter the first number
            Console.WriteLine("Enter the third number");

            //User enter the number that converts to integer
            num3 = Convert.ToInt32(Console.ReadLine());


            //Display message for the user to enter the first number
            Console.WriteLine("Enter the forth number");

            //User enter the number that converts to integer
            num4 = Convert.ToInt32(Console.ReadLine());



            //Calculating average of the four numbers and sorting in another variable-average
            average = (num1 + num2 + num3 + num4)/ 4;

            //Display the result to the user
            Console.WriteLine($"The average of the numbers are {average}");

        }
    }
}
