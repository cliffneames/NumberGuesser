using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
	class Program
	{
        static void GuessingGame()
        {
            Random randomNumber = new Random();

            int random = randomNumber.Next(1, 101);
            int guess = 0, counter = 0;
            string possibleNumber = null;

            do
            {

                Console.WriteLine("Please guess a number between 1 and 100: ");
                possibleNumber = Console.ReadLine();

                if (int.TryParse(possibleNumber, out guess) && guess > random)
                {
                    Console.WriteLine("The number is lower than what you guessed");
                    counter++;
                }
                else if (int.TryParse(possibleNumber, out guess) && guess < random)
                {
                    Console.WriteLine("The number is higher than what you guessed");
                    counter++;
                }
                else if (int.TryParse(possibleNumber, out guess) && guess == random)
                {
                    Console.WriteLine("You've matched the number exactly you WIN!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess was not valid");
                }

                if (counter == 5)
                {
                    Console.WriteLine("You Lose Sucker!");
                }
            }
            while (counter < 5);
        }
		static void Main(string[] args)
		{

            GuessingGame();
            
		}
	}
}
