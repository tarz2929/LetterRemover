using System;

namespace LetterRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Title: Letter Remover
            Purpose: Remove given characters from a string.

            Author: James Grieve
            Last Modified: August 13, 2020
            */

            string userInput, userChar, output;
            
            Console.WriteLine("Welcome to the letter remover application! You will be prompted to enter both a string and a character, and every instance of that character will be removed from the string.\n");

            Console.Write("Please enter a string from which characters will be removed: ");
            userInput = Console.ReadLine();

            Console.Write("Please enter a character to remove from the string: ");
            userChar = Console.ReadLine();
        }
    }
}
