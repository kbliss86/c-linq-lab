using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_linq_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            LINQ and Collections

            Objective:
            Learn to use LINQ to query and manipulate collections in C#.

            Task:
            Use LINQ to search and analyze a collection of integers.
            */

            /*
            Build Specifications:

            1. Create the following array:
               int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

            2. Write code using LINQ to answer the following questions:
               - Find the Minimum value.
               - Find the Maximum value.
               - Find the Maximum value less than 10000.
               - Find all the values between 10 and 100.
               - Find all the values between 100000 and 999999 inclusive.
               - Count all the even numbers.
            */

            /*
            Hints:
            - Use the Min(), Max(), Where(), and Count() LINQ methods to answer the questions.
            - Consider using Console.WriteLine to output the results.
            */

            /*
            Testing the Code with User Input:
            //Declare Variables
            */
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
            bool validInput = false;
            int userNumber;

            //do while to validate response is int
            //for loop to tell the user the current array values
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Array Value {i} is {nums[i]}");
            }
            //Prompt User to add Numbers to the array
            do
            {
                Console.WriteLine("Please Enter an additional integer");
                    string userInput = Console.ReadLine();
                    validInput = int.TryParse(userInput, out userNumber);
                if (!validInput)
                {
                    Console.WriteLine("Please Enter a valid integer");
                }
            }
            while (!validInput);
            Console.WriteLine($"You Entered {userNumber}");
            int[] userNums = new int[nums.Length + 1]; // Creates a new Array to input the user integer

            //For loop to input the existing original array and the new array
            for (int y = 0; y < nums.Length; y++)
            {
                userNums[y] = nums[y];
            }

            userNums[userNums.Length - 1] = userNumber;

            /*
            You can then rerun the LINQ queries on the modified array.
            Use the Min(), Max(), Where(), and Count() LINQ methods to answer the questions.
            */

            Console.WriteLine($"Max Value: {userNums.Max()}");
            Console.WriteLine($"Min Value: {userNums.Min()}");
            var valuesLessThan1000 = userNums.Where(n => n < 1000);
            Console.WriteLine($"Max Value less than 1000: {string.Join(", ",valuesLessThan1000)}");//Joins the Values with a "," delimeter
            var valuesBetween10and100 = userNums.Where(n => n > 10 && n < 100);
            Console.WriteLine($"Max Value: {string.Join(", ",valuesBetween10and100)}");
            var valuesBetween100000And999999 = userNums.Where(n => n > 100000 && n < 999999);
            Console.WriteLine($"Max Value: {string.Join(", ",valuesBetween100000And999999)}");
            int evenNumbers = userNums.Count(n => n % 2 == 0);
            Console.WriteLine($"Max Value: {evenNumbers}");
            Console.ReadLine();
            /*
            Example Console Output:

            Minimum value: 10
            Maximum value: 523863
            Maximum value less than 10000: 3764
            Values between 10 and 100: 10, 12
            Values between 100000 and 999999: 112233, 523863
            Count of even numbers: 5
            */

        }
    }
}
