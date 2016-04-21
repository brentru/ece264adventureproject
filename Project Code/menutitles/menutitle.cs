using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advMenuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // display title artwork + credits
            titleArt();

            // title - prompt user loop 
            Console.WriteLine("\n\n");
            Console.WriteLine("     info: type h for command output at any time during Cryo Break");
            Console.WriteLine("\n\n");

            


            string menuStart = menuLoad("\nWould you like to play? \n");
            while (menuStart == "Y" | menuStart == "YES")
            {
                string menuInput = menuCommand("What would you like to do: ");
                // questions to pass to shape depending on type of shape

                if (menuInput == "START" || menuInput == "S")
                {
                    // start program flow
                    Console.WriteLine("Loading Cryo Break....");
                    // get out of routine + make a call to XML loading
                }
                else if (menuInput == "QUIT" || menuInput == "Q" || menuInput == "EXIT" || menuInput == "E")
                {
                    Console.WriteLine("Thanks for playing!");
                    System.Environment.Exit(1); // quit program safely 
                }
                else if (menuInput == "H" || menuInput == "HELP")
                {
                    // call menu help printing routine here
                    menuHelp();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR in: title - prompt error user section");
                }

                menuStart = menuLoad("\nWould you like to play?\n");
            }


        }
        

        // menu help printing routine
        static void menuHelp()
        {
            twoLine();twoLine();twoLine();
            Console.WriteLine("Cryo Break, Title Screen Help Menu");
            oneLine();
            Console.WriteLine("S, Start: Starts the game");
            Console.WriteLine("Q, E, Quit, Exit: Quits the program ");
            Console.WriteLine("H, Help,: Help menu (you're in this right now)");
        }

        static void oneLine()
        {
            // writes a blankline
            Console.WriteLine("\n");
        }
        static void twoLine()
        {
            // writes 2x blanklines 
            Console.WriteLine("\n\n");
        }

        static string menuLoad(string prompt)
        {
            string[] valid = new string[] { "Y", "N", "YES", "NO" };
            string menuLAnswer; // return valid hand value within list
            menuLAnswer = GetString(prompt, valid, "? Invalid answer, please re-enter");
            return menuLAnswer;
        }

        static void titleArt()
        {
            var titleArr = new[]
            {
                    @" _____                   ______                _    ",
                    @"/  __ \                  | ___ \              | |   ",
                    @"| /  \/_ __ _   _  ___   | |_/ /_ __ ___  __ _| | __", 
                    @"| |   | '__| | | |/ _ \  | ___ \ '__/ _ \/ _` | |/ /", 
                    @"| \__/\ |  | |_| | (_) | | |_/ / | |  __/ (_| |   < ", 
                    @" \____/_|   \__, |\___/  \____/|_|  \___|\__,_|_|\_\", 
                    @"             __/ |                                  ", 
                    @"            |___/                                   ", 
            };
            Console.WriteLine("\n\n");
            // print out each line for the title 
            foreach (string line in titleArr)
                Console.WriteLine(line);
            Console.WriteLine("by: david austin, brent rubell, and eric pires"); // credits
        }
        // handler for valid menu commands
        static string menuCommand(string prompt)
        {
            string[] valid = new string[] { "S", "START", "YES", "Y", "N", "NO", "QUIT", "Q", "EXIT", "E", "HELP", "H" };
            string menuAnswer; // return valid hand value within list
            menuAnswer = GetString(prompt, valid, "? Invalid answer, please re-enter");
            return menuAnswer;
        }


        // universal get string w. prompt, valid values and error msg
        static string GetString(string prompt, string[] valid, string error)
        {
            string response;
            bool OK = false;
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine().ToUpper();
                foreach (string s in valid) if (response == s.ToUpper()) OK = true;
                if (!OK) Console.WriteLine(error);
            } while (!OK);
            return response;
        }
    }
}
