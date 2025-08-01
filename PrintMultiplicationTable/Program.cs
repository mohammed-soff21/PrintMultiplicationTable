﻿namespace PrintMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring variables
            char cUserChoice = ' ';
            int nUserInput = 0;
            while (true)
            {
                // Welcome message
                WelcomeApp("printing the multiplication table of a number given by the user");
                // To read user input and validate it
                do
                {
                    if (IsNumber("a number to display its multiplication table", out nUserInput))
                        break;
                } while (true);
                // To print the multiplication table of the number given by the user
                PrintMultiplicationTable(nUserInput);
                // To read user choice to continue in the app again and validate the user input
                if (!IsChar("y to continue or n to exit", out cUserChoice))
                    return;
                // Convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // To check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // To check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }

        }


        #region Methods 

        // This region contains the main methods used in the application
        #region main-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("***********************************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate character from the user
        static bool IsChar(string field, out char cInput)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out cInput))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 4) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter y to continue or n to exit");
            return false;
        }

        // 5) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        // 6) this method to read and validate int number from the user
        static bool IsNumber(string field, out int nValue)
        {
            Console.Write($"Please, enter {field}: ");
            if (!int.TryParse(Console.ReadLine(), out nValue))
            {
                Print("Please, enter a valid number");
                return false;
            }
            return true;
        }

        // 7) this method to print the multiplication table of a number given by the user
        static void PrintMultiplicationTable(int number)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine($"That is the multiplication table of {number}:");
            for (int nCounter = 1; nCounter <= 12; ++nCounter)
                Console.WriteLine($"{number}*{nCounter}={nCounter * number}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
        #endregion


        #endregion

    }
}
