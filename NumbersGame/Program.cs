using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)              // Erik Engvall NET 22
        {
            Random rnd = new Random();         //  This code and the one below will randomly set the number and puts into the variabel
            int rndNumbrs = rnd.Next(1, 20);   //  This code and the one above will randomly set the number and puts into the variabel
            int maxGuess = 5;    // Max guesses is 5


            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 & 20. Kan du gissa vilket? Du får " + maxGuess + " försök. "); // Printing out welcome to the user and the total of guesses
            NumGame(rndNumbrs, maxGuess);
        }
        public static bool NumGame(int rndNumbrs, int maxGuess)  // The method were the game is "installed" in 
        {

            bool correct = false;  // Creating a bool that will check if my answers is correct or false, if its false the user is going through the if loop 5 times.
            do
            {
                string n = Console.ReadLine();
                int i = int.Parse(n);

                if (i == rndNumbrs)    // The if statement checks if the answer is correct or false, it also says if it's lower or higher and also how many guesses you have left.
                {
                    Console.WriteLine("Woho! Du gjorde det!");  // The user solved the game
                    break;
                }
                else if (maxGuess == 1)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");  // The user didnt solved the game with 5 guesses 
                    correct = true;
                }
                else if (i > rndNumbrs)
                {
                    maxGuess--;
                    Console.WriteLine("Tyvärr du gissade för högt!");   // The user guessed to high
                    Console.WriteLine("Du har " + maxGuess + " försök kvar");   // You have ____ tries left
                }
                else if (i < rndNumbrs)
                {
                    maxGuess--;
                    Console.WriteLine("Tyvärr du gissade för lågt!");   // The user guessed to low
                    Console.WriteLine("Du har " + maxGuess + " försök kvar");  // You have ____ tries left.
                }

            } while (correct == false);

            return true;
        }
    }
}
