using System;

namespace opdrachtweek3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Oefening Lesweek 3 */

            int number;
            int multiplicand = 7;
            
            // Met een array
            int[] numbers = new int[11];
            //int numberToAdd = 1;

            Console.WriteLine("Vul een getal in: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Met het getal 7
            for(int i = 0; i <= 10; i++) {
               numbers[i] = i * multiplicand;
                // Kan ook op deze manier is hetzelfde
                // int multiplication = multiplicand * i;
               Console.WriteLine(i + " x " + multiplicand + " = " + numbers[i]);
            }

            Console.WriteLine();

            // Met een zelfgekozen getal 
            for(int i = 0; i <= 10; i++) {
               numbers[i] = i * number;
                // Kan ook op deze manier is hetzelfde
                // int multiplication = number1 * i;
               Console.WriteLine(i + " x " + number + " = " + numbers[i]);
            }

            // Volgende is met een list

            // Volgende is met een Hashtable

            // Resultaat moet opgeslagen worden in 3 verschillende datacollecties
            // Als alle elementen opgeslagen zijn in de datacollecties dien je elke datacollectie te overlopen en elk opgeslagen element af te drukken in de console.
            
            
        }
    }
}
