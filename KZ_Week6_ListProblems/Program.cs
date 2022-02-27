// Kyle Zapalac, 27-Feb-2022, GAME-1343 (SP 2022)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_ListProblems_KZ
{
    class Program
    {
        // use main to call 3 functions that are solving problems
        static void Main(string[] args)
        {
            // call problem 1 function
            Console.WriteLine("================= PROBLEM #1 ====================\n");
            ProblemOne();

            // call problem 2 function
            Console.WriteLine("\n================= PROBLEM #2 ====================\n");
            ProblemTwo();

            // end output
            Console.WriteLine("\n=================================================\n");
        }

        // take user input and output a facebook style message based on the number of names (use a list!)
        static void ProblemOne()
        {
            // initialize the list and input
            List<string> nameList = new List<string>();
            string input = "";

            // runs loop at least once, until a blank input is entered by user
            do
            {
                // get input from user
                Console.Write("Enter name or just hit 'enter' to trigger the Facebook display: ");
                input = Console.ReadLine();

                // if exit condition has not been met, continue building array
                if (input != "")
                {
                    nameList.Add(input);
                }

            } while (input != "");

            // get number of names using .Count
            int nameCount = nameList.Count;

            // print blank line
            Console.WriteLine();

            // use switch to print certain input based on number of names (aka number of likes)
            switch (nameCount)
            {
                case 0: // write nothing if 0 likes
                    Console.WriteLine();
                    break;
                case 1: // write this if 1 like
                    Console.WriteLine(nameList[0] + " likes your post.");
                    break;
                case 2: // write this if 2 likes
                    Console.WriteLine(nameList[0] + " and " + nameList[1] + " like your post.");
                    break;
                default: // write this if 3 or more likes
                    Console.WriteLine(nameList[0] + ", " + nameList[1] + ", and " + (nameCount - 2) + " others like your post.");
                    break;
            }
        }

        // write a program that asks the user to enter the sentence then counts each unique letter (use a dictionary!)
        static void ProblemTwo()
        {
            // initialize dictionary
            Dictionary<char, int> sentenceAnalyzer = new Dictionary<char, int>();

            // get input from user
            Console.Write("Enter a sentence for analysis: ");
            string sentence = Console.ReadLine();

            // create array of lower case characters from the user inputted string
            char[] letters = sentence.ToLower().ToCharArray();

            // iterate through entire sentence and count unique characters
            foreach (char letter in letters)
            {
                // ignore spaces per example in assignment
                if (letter != ' ')
                {
                    if (sentenceAnalyzer.ContainsKey(letter))
                    {
                        // increase count for this letter (increments VALUE for this KEY 'letter')
                        sentenceAnalyzer[letter]++;
                    }
                    else
                    {
                        // adds initial instance of character
                        sentenceAnalyzer.Add(letter, 1);
                    }
                }
            }

            // output counts for each letter by iterating through each key value pair
            foreach (KeyValuePair<char, int> kvp in sentenceAnalyzer)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}
