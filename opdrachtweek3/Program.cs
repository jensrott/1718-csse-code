using System;
using System.Collections.Generic; // Nodig voor lists te gebruiken
using System.Collections; // Nodig voor hastable te gebruiken

namespace opdrachtweek3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*------ Oefening Lesweek 3 ------*/

            int number;
            int i;
            int multiplicand = 7;
            
            // Een array is meestal sneller dan een list meestal
            // We maken een nieuwe Array
            int[] arrayNumbers = new int[11];
            //int numberToAdd = 1;

            Console.WriteLine("Vul een getal in: ");

            /* We moeten het nummer nog omzetten naar een integer om mee te rekenen, 
            standaard is het getal een string en hiermee kunnen we niet rekenen.*/
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Het nummer dat u invoerde was: " + number);

            // Write a break
            Console.WriteLine();    

            // Met het getal 7 zoals de opdracht het vroeg
            Console.WriteLine("ARRAYS:");
            for(i = 0; i <= 10; i++) {
               arrayNumbers[i] = i * multiplicand;
                // Kan ook op deze manier is hetzelfde
                // int multiplication = multiplicand * i;
               Console.WriteLine(i + " x " + multiplicand + " = " + arrayNumbers[i]);
            }

            // Write a break
            Console.WriteLine();

            Console.WriteLine("ZELFGEKOZEN GETAL:");
            // Met een zelfgekozen getal dat je intypt

            for(i = 0; i <= 10; i++) {
               arrayNumbers[i] = i * number;
                // Kan ook op deze manier is hetzelfde
                // int multiplication = number * i;
               Console.WriteLine(i + " x " + number + " = " + arrayNumbers[i]);
            }

            // Write a break
            Console.WriteLine();

            // Volgende is met een list
            Console.WriteLine("LISTS:");

            // We maken een nieuwe List
            List<int> listNumbers = new List<int>();

            for (i = 0; i <= 10; i++) {
                // Heeft maar 1 item
                listNumbers.Add(multiplicand * i);
                Console.WriteLine(i + " x " + multiplicand + " = " + listNumbers[i]);
            }

            Console.WriteLine();

            Console.WriteLine("ZELFGEKOZEN GETAL LIST:");
            for (i = 0; i <= 10; i++) {
                // Heeft maar 1 item
                listNumbers.Add(number * i);
                Console.WriteLine(i + " x " + number + " = " + listNumbers[i]);
            }

            // We write a Break
            Console.WriteLine();

            // Volgende is met een Hashtable
            Console.WriteLine("HASTABLE:");

            // We maken een nieuwe Hastable
            Hashtable hashtableNumbers = new Hashtable();

            for(i = 0; i <= 10; i++) {

                // Heeft 2 items, het eerste is i en het tweede is 7 * 0, 7 * 1, 7 * 2 ...
                hashtableNumbers.Add(i, multiplicand * i);
                Console.WriteLine(i + " x " + multiplicand + " = " + hashtableNumbers[i]);
            }
            
            // We write a break
            Console.WriteLine();

            /* Bij een hastable kunnen we niet nogmaals een anders getal toevoegen zoals bij een array en list 
            daarom heb ik een nieuwe Hastable moeten maken en deze hash genoemd om dit laatste te doen werken */

            Hashtable hashNumbers = new Hashtable();
            Console.WriteLine("ZELFGEKOZEN GETAL HASTABLE:");
            for(i = 0; i <= 10; i++) {

                // Heeft 2 items, het eerste is i en het tweede is 7 * 0, 7 * 1, 7 * 2 ...
                hashNumbers.Add(i, number * i);
                Console.WriteLine(i + " x " + number + " = " + hashNumbers[i]);
            }

            // We write a break
            Console.WriteLine();

            Console.WriteLine("Hello world!");

            // Resultaat moet opgeslagen worden in 3 verschillende datacollecties
            // Als alle elementen opgeslagen zijn in de datacollecties dien je elke datacollectie te overlopen en elk opgeslagen element af te drukken in de console.  
        }
    }
}
