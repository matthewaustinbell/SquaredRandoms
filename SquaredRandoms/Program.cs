using System;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 50);

            Console.WriteLine(randomNumber);
            
        }
    }
}
