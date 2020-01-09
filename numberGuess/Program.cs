using System;

namespace numberGuess
{
    class Program
    {

        static void getAppInfo()
        {
            // set app var
            string appName = "Number Guesser";
            string appversion = "1.0.0";
            string appAuthor = "Eddy Bautista";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Practice with placeholders
            Console.WriteLine("{0}: Version {1} by {2}", appName, appversion, appAuthor);

            // reset color
            Console.ResetColor();
        }


        static void greetUser()
        {
            //Ask users Name
            Console.WriteLine("What is your name");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine(" Hello {0}, Lets play a game!", inputName);
        }

        //Takes in two params, the color of text and the mssg that will display to the user
        static void printColorMsg(ConsoleColor color, string message)
        {
            // Change text color when not a number
            Console.ForegroundColor = color;

            //Tell user they did not enter a number
            Console.WriteLine(message);

            // reset color
            Console.ResetColor();
        }

        static void Main(string[] args)
        {

            getAppInfo();

            greetUser();

            while (true)
            {

                //init correct random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init guess var;
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // make sure it is a number- by taking a string and converting it to a number
                    if (!int.TryParse(input, out guess))
                    {
                        printColorMsg(ConsoleColor.Red, "Sorry that's not a number");
                       
                        //Keep going
                        continue;

                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        printColorMsg(ConsoleColor.Red, "Sorry wrong number! Please try again!");
              
                    }
                }
                printColorMsg(ConsoleColor.Yellow, "You picked the correct numer!");

                // ask to play again
                Console.WriteLine("Play again?[y/n]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
            }
        }
    }
}
