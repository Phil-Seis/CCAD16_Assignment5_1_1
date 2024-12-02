//Given an integer x, return true if x is a palindrome, and false otherwise.
    //Example 1:
        //Input: x = 121 (treat every digit as it's own element)
        //Output: true
        //Explanation: 121 reads as 121 from left to right and from right to left.
    //Example 2:
        //Input: x = -121
        //Output: false
        //Explanation: From left to right, it reads -1 2 1. From right to left, it becomes 1 2 -1. Therefore it is not a palindrome.+

//How to solve:
    //Main Method:
        //Ask user for an array, convert the string input to int array.
        //Set boolean value for Palindrome
        //If / Else for print statements

    //Palindrome Method:
        //If first element is a negative, set boolean to false
        //For loop to run through array (only halfway n/2) and compare elements
            //If [i] doesn't equal n-1
                //False
            //else
                //True
    

using System;
using System.Linq;

namespace CCAD16_Assignment5_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type in an array of integers separated by spaces, and I'll determine if it's a Palindrome:");
            string userInput = Console.ReadLine();
            int[] userArray = userInput.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Your array is: [{string.Join(", ", userArray)}]");

            bool isPalindrome = CheckPalindrome(userArray);

            if (isPalindrome)
            {
                Console.WriteLine("\nYour array is a Palindrome.");
            }
            else
            {
                Console.WriteLine("\nYour array is NOT a Palindrome.");
            }
        }

        static bool CheckPalindrome(int[] array)
        {
            if (array[0] < 0)
            {
                return false;
            }

            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
