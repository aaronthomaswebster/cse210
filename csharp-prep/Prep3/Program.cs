using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        int numberOfGuesses = 0;

        do{
            numberOfGuesses++;
            Console.Write("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());
            if(guess > magicNumber){
                Console.WriteLine("Too high!");
            } else if(guess < magicNumber){
                Console.WriteLine("Too low!");
            }
        } while(guess != magicNumber);

        Console.WriteLine($"You guessed the magic number in {numberOfGuesses} guesses!");
        
    }
}