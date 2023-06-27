using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.ComponentModel.Design;

namespace IterationStatements
{
    class Program
    {
        //LukeWarm Section: Create methods below

        //METHOD: Write a method that will print to the console all numbers 1000 through - 1000
        //Initilize the variable with a value of 1000 which is the starting point

        //var num = 1000; and Create a list called "numbers"
        static void PrintNumbersOnethwPosnneg()
        {
            var numbers = new List<int>();
            var num = 1001;
            Console.WriteLine("Print to the console all numbers 1000 through - 1000");
            // Create a do-while loop
            do
            {
                // decrease num each execution;  descrease num by 1
                num--;
                Console.WriteLine(num);
            } while (num > -1000);
        }

        //METHOD: Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void ThreeToNinetyNine()
        {
            var chiffre = new List<int>();
            var i = 3;
            Console.WriteLine(" ");
            Console.WriteLine("print to the console numbers 3 through 999 by 3 each time");
            //while loop
            while (i < 999)
            {
                //increase num each execution; increase num by 3
                i = i + 3;
                chiffre.Add(i);
            }
            //Console.WriteLine("Increase number by 3");
            foreach (var number in chiffre)
            {
                //Code to be executed
            Console.WriteLine(number);
            }
        }

        //METHOD: Write a method to accept two integers as parameterss and check whether they are equal or not
        static bool CheckNum(int nume, int numf)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Accept two integers as parameters. if they are equal value is true and if they are not equal value is false");
            if (nume == numf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //METHOD: Write a method to check whether a given number is even or odd
        static void EvenOdd()
        {
            int b;
            Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("This is going to try for 3 times");
            Console.WriteLine("Please Enter a Number either odd or even : ");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number:");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
        }

        //METHOD: Write a method to check whether a given number is positive or negative
        static void PosNeg()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Check whether a given number is positive or negative");
            Console.WriteLine("Enter a number:");
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
        }

        //METHOD: Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void Age2V()
        {
            int age2v;
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Input the voting age:");
            //vote_age= Convert.ToInt32(Console.ReadLine());
            age2v = int.Parse(Console.ReadLine());

            if (age2v < 18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            else
                Console.WriteLine("Congratulations! You are eligible to vote.");
        }

        //HEATING UP METHODS :-) - the simple one don't work - Need to get those going first


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        //int m = 10;
        static void NumRange()
        {
            int chiffre;
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("check if an integer(from the user) is in the range -10 to 10");
            Console.WriteLine("Type a number:");
            chiffre = int.Parse(Console.ReadLine());
            if (chiffre < 10 && chiffre > -10)
            {
                Console.WriteLine("is in range");
            }
            else
            {
                Console.WriteLine("not in range");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultNum()
        {
            int multn;
            Console.WriteLine(" ");
            Console.WriteLine("Provide number to multiply:");
            Console.WriteLine("The Multiplier");
            multn = int.Parse(Console.ReadLine());
            //Console.WriteLine(" ");
            Console.WriteLine("This is the 12 Multiplication Table");
            for (int j = 1; j <= 12; j++)
            {
            Console.WriteLine(multn * j);
            }
        }
        //Calling of Methods
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Methods 
            PrintNumbersOnethwPosnneg();
            ThreeToNinetyNine();
            Console.WriteLine(CheckNum(7, 3));
            EvenOdd();
            PosNeg();
            Age2V();

            //Special Heating up Methods - Did not even try
            NumRange();
            MultNum();

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
