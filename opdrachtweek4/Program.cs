using System;

namespace opdrachtweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a number between 0 en 100");

            number = Convert.ToInt32(Console.ReadLine());
            if(number > 100) {
                Console.WriteLine("Geen geldig nummer! ");
            }
            
        }
    }
}
