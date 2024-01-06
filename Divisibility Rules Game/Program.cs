namespace Divisibility_Rules_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 51;
            bool isCorrect = false;
            Random rand = new Random();
            int randomNumber = rand.Next(MIN_NUMBER, MAX_NUMBER); // From 1 to 50

            Console.WriteLine("A random number (between 1 and 50) has been randomly generated. Can you guess the number? \n");

            while (!isCorrect)
            {
                CheckDivisibilityRules(randomNumber);

                Console.Write("Please enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number.");
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again. Your guess is not correct.");
                        CheckDivisibilityRules(randomNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

        }

        static void CheckDivisibilityRules(int number)
        {
            Console.WriteLine("Here some clues to help you guess the number: \n");

            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0 && number % number == 0)
                    Console.WriteLine($"The number is divisible by {i}");
            }
        }
    }
}
