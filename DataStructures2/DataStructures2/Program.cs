using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            { 6,7,21};



            //Display all elements
            DisplayElements(numbers);
            //Add 2
            numbers.Add(2);
            //Add 7
            numbers.Add(7);



            //Add 3 between 21 and 2
            numbers.Insert(3, 3);
            //Display all elements
            DisplayElements(numbers);
            //Remove 7 
            numbers.Remove(7);
            //Add100
            numbers.Add(100);
            //Remove the second last element
            numbers.RemoveAt(numbers.Count - 2);
            //Display all elements
            DisplayElements(numbers);
            Console.WriteLine(CheckNumber(5, numbers));
            Console.WriteLine($"SumOfEven: {SumOfEven(numbers)}");
            AverageOfOdd(numbers);
            MultiplesOf3And7(numbers);



        }



        //Display all elements
        static void DisplayElements(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("=====================\n");
        }

        //Create a method to check if the n(any) number exists in the list. Return true or false

        static bool CheckNumber(int x, List<int> ls)
        {
            return ls.Contains(x);
        }

        //Create a method to calculate and return sum of all the even numbers in the list

        static int SumOfEven(List<int> ls) 
        {
           int sum = 0;
            foreach (int n in ls) 
           {
            if(n % 2 == 0) 
                {
                    sum += n;
                }
           }
            return sum;
            
   
        }


        //Create a method to calculate and display average of all the odd number in the list

        static void AverageOfOdd(List<int> ls) 
        {
            int sum = 0;
            int count = 0;
            double average = 0;

            foreach (int n in ls)
            {
                if (n % 2 != 0)
                {
                    sum += n;
                    count++;
                }
            }

            average = sum/ count;
            Console.WriteLine($"Average : {average.ToString("N2")}");

        }

        //Create a method to display all the numbers that are both multiples of 3 and 7 from list

        static void MultiplesOf3And7(List<int> ls)
        {
            foreach (int n in ls)
            {
                if (n % 3 == 0 && n % 7==0)
                {
                    Console.WriteLine(n);
                }
            }

        }

        //Want display to show string Even or Odd
        static string CheckForNumber(int x)

        { 
            //variable = Condition ? value when true : value when false
            string results = "none";

            //results = x % 2 == 0 ? "Even" : "Odd";
            //A) else if
            //

            if (x % 2 ==0) 
            
            {
                results = "Even";
            }

            // A) different way when have else if
            //Else if(x % 3 == 0)
            //{
            //results = "Multiples of 3"
            //}

            else
            {
                results = "Odd";
            }

            return results;
        }


        //Another Way
        //Tenary
        static bool CheckForNumber2(int x)
        { 
            return x % 2 == 0;
        }
    }



}