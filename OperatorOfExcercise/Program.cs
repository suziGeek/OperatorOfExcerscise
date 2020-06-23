using System;

namespace OperatorOfExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"Enter a number to guess what my favoritenumber is!");
           
                var userInput = int.Parse(Console.ReadLine());

            if(favNumber < userInput)
            {
                Console.WriteLine($"To Low!");
            }
            else if ( favNumber > userInput)
            {
                Console.WriteLine($"To High!");
            }
            else 
            { 
                Console.WriteLine($"Never Mind..."); 
            }

        }
    }
}
