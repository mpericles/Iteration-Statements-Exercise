using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace IterationStatements
{
    class Program
    {
        //LukeWarm Section: Create methods below



        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000
            //Initilize the variable with a value of 1000 which is the starting point
            //var num = 1000; and  //Create a list called "numbers"
            //static void PrintNumbers1000Posnneg()
            //{
            //}
            var numbers = new List<int>();
            var num = 1001;
            // Create a do-while loop
            do
            {
                // decrease num each execution;  descrease num by 1
                num--;
                Console.WriteLine(num);
            } while (num > -1000);

            //Methods not working
            //PrintNumbers1000Posnneg();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            var chiffre = new List<int>();
            var i = 3;
            // while loop
            while (i < 999)
            {
                // increase num each execution;  increase num by 3
                i = i + 3;
                chiffre.Add(i);
            }
            Console.WriteLine("Increase:");
            foreach (var number in chiffre)
            {
                //Code to be executed
                Console.WriteLine(number);
            }

            //Write a method to accept two integers as parameterss and check whether they are equal or not
            static int CheckNum(int nume, int numf)
            {
                if (nume == numf)
                {
                    return 1;
                }
                else return 0;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"This is the result of CheckNum Method with Number 7 and Number 3");
            Console.WriteLine("If the result of CheckNum Method is 0 then the numbers are not equal");
            Console.WriteLine(CheckNum(7, 3));

            //Write a method to check whether a given number is even or odd
            int b;
            Console.WriteLine(" ");
            Console.WriteLine("Enter a Number : ");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            //Write a method to check whether a given number is positive or negative
            Console.WriteLine("Enter a number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (c == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
            Console.ReadLine();

            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()
            int age2v;
            Console.WriteLine(" ");
            Console.WriteLine("Input the voting age: ");
            //vote_age= Convert.ToInt32(Console.ReadLine());
            age2v = int.Parse(Console.ReadLine());

            if (age2v < 18)
            {
            Console.WriteLine(" you are not eligible to vote");
            }
            else
            Console.WriteLine("Congratulations! You are eligible to vote.");

            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10

            //Write a method to display the multiplication table(from 1 to 12) of a given integer


            //Call the methods to test them in the Main method below
        }
    }
}

//start for loop here - For loop did not work - there were no errors but it did not work
//for (var i = 1000; i <= numbers.Count && i >= -1000; i--)
//{
// place numbers[i] inside of the Console.WriteLine() method
//  Console.WriteLine(" test ");
//Console.WriteLine(numbers[i]);
//}
//}
//}
