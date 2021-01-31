using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("The secret number is (Between 1 to 10): ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won!");
                    return;
                }

            }
            Console.WriteLine("You Lost");
        }

    }
}
