using System;
using System.Text;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman");
            //Stash of secrets word
            string[] secretWords = new string[5];
            secretWords[0] = "hospital";
            secretWords[1] = "motorcycle";
            secretWords[2] = "computer";
            secretWords[3] = "horse";
            secretWords[4] = "flower";

            //Randomly choose a secret word 
            Random random = new Random();
            int num = random.Next(0, 4);
            string secretWord = secretWords[num];
            int wordLength = secretWord.Length;
           
            //The users info
            char letter;
            int numberOfGuesses = 10;
            StringBuilder lettersGuessed = new StringBuilder();

            //The word and letters displayed while guessing
            char[] guessedWord = new char[secretWord.Length];
            for (int i = 0; i < wordLength; i++) {
                guessedWord[i] = '_';
            }
            Console.WriteLine("The word is " + wordLength + " letters long. ");
            Boolean keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Guess a letter: ");
                letter = char.Parse(Console.ReadLine());

                for (int i = 0; i < wordLength; i++)
                {
                    if (letter == secretWord[i])
                    {
                        guessedWord[i] = letter;
                    }
                }
                lettersGuessed.Append(letter);
                numberOfGuesses--;
                Console.WriteLine(guessedWord);
                Console.WriteLine("Number of guesses left: " + numberOfGuesses);
                Console.WriteLine("Letters guessed: " + lettersGuessed.ToString());
                if(numberOfGuesses == 0)
                    keepRunning = false;
                string guessedWordInAString = new string(guessedWord);
                if(guessedWordInAString == secretWord)
                    keepRunning = false;
            }
            
        }// End of main
    }// End if class
}// End of namespace