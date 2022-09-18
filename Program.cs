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
            string secretWord = "hus"; // secretWords[num];
            int wordLength = secretWord.Length;
           
            //The users info
            char letter;
            int numberOfGuesses = 4;
            StringBuilder lettersGuessed = new StringBuilder();

            //The word and letters displayed while guessing
            char[] guessedWord = new char[secretWord.Length];
            for (int i = 0; i < wordLength; i++) {
                guessedWord[i] = '_';
            }
            Console.WriteLine("The word is " + wordLength + " letters long. ");

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Guess a letter: ");
                try
                {
                    letter = char.Parse(s: Console.ReadLine());
                    if (Char.IsDigit(letter))
                    {
                        Console.WriteLine("There is no number in the word.");
                    }
                    else
                    {
                        for (int i = 0; i < wordLength; i++)
                        {
                            if (letter == secretWord[i])
                            {
                                guessedWord[i] = letter;
                            }
                        }
                    }
                    for(int i = 0; i < lettersGuessed.Length; i++)
                    {
                        if(lettersGuessed[i] != letter)
                        {

                        }
                    }
                    lettersGuessed.Append(letter);
                    numberOfGuesses--;
                    Console.WriteLine(guessedWord);
                    Console.WriteLine("Number of guesses left: " + numberOfGuesses);
                    Console.WriteLine("Letters guessed: " + lettersGuessed.ToString());
                    if(numberOfGuesses == 0) {
                        Console.WriteLine("The correct word is " + secretWord);
                        keepRunning = false;
                    }
                    string guessedWordInAString = new string(guessedWord);
                    if(guessedWordInAString == secretWord){
                        Console.WriteLine("You guessed wright! ");
                        keepRunning = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            
        }// End of main
    }// End if class
}// End of namespace