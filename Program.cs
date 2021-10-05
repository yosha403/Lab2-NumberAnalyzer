using System;

//DevBuild Lab2 : Number Analyzer
//Author: Yosha Kunnummal
//Date: 10/05/2021

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            bool goOn = true;
            while (goOn == true)
            {
                Console.Write("Enter a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());

                //Checking whether the number is between 1 and 100
                if (number >= 1 && number < 100)
                {
                    //Find the remainder and check whether the number is odd or even
                    if (number % 2 != 0)
                    {
                        if (number > 60 || number <= 25)
                        {
                            Console.WriteLine($"{number } and Odd");
                        }
                    }
                    else
                    {
                        if (number >= 2 && number < 25)
                        {
                            Console.WriteLine("Even and less than 25");
                        }
                        //Checking whether the number is between 26 and 60 and printing the message
                        else if (number >= 26 && number <= 60)
                        {
                            Console.WriteLine("Even");
                        }
                        //Checking whether the number is greater than 60 and printing the message
                        else if (number > 60)
                        {
                            Console.WriteLine($"{number } and Even");
                        }
                    }
                }
                //If we input a number which is greater than 100, display the message like this
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }

                bool askAgain = true;

                while (askAgain == true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{name.ToString()}, Would you like to continue? Y / N");                    
                    string answer = Console.ReadLine().ToLower();
                    //Three possibilities to check
                    //1) Y 
                    //2) N 
                    //3) Anything else

                    if (answer == "y")
                    {
                        askAgain = false;
                        goOn = true;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        goOn = false;
                        Console.WriteLine("Good Bye!");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand that ");
                        Console.WriteLine("Let's try that again");
                    }
                }

            }
        }
    }
}
