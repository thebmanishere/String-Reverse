using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString _reverseString = new ReverseString();

            string userPrompt = "Please enter a word or sentence you want to be reversed: ";
            Console.WriteLine("{0}", userPrompt);

            try {

                string userInput = Console.ReadLine();

                string initalString = "Inital input: ";
                Console.WriteLine("{0}{1}", initalString, userInput);

                string consoleOutput = "Reversed output: ";

                char[] reversedStringArray = _reverseString.Reverse(userInput);
                string stringToReturn = new string(reversedStringArray);

                Console.WriteLine("{0}{1}", consoleOutput, stringToReturn);

            } catch(Exception ex)
            {
                Console.WriteLine("{0}{1}", "Input could not be reversed: ", ex.Message);
            }           
        }
    }
}
