using System;

namespace numberGuess
{
    class Program
    {
        


        static void Main(string[] args)
        {
            // set app var
            string appName = "Number Guesser";
            string appversion = "1.0.0";
            string appAuthor = "Eddy Bautista";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Practice with placeholders
            Console.WriteLine("{0}: Version {1} by {2}",appName, appversion,appAuthor );

            // reset color
            Console.ResetColor();

        }
    }
}
