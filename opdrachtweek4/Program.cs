using System;

namespace opdrachtweek4
{
    class Program
    {


        // In de main worden onze methods gecalled geef willekeurig getal en uitvoeren fibonacci
        static void Main(string[] args)
        {

            geefWilleKeurigGetal();
            uitvoerenFibonacci();
            
        } 

        /* Oefening 1 */
        private static void geefWilleKeurigGetal() {

            // Het nummer dat we zelf hebben gekozen.
            int number;

            // Boolean noPrimes.
            bool boolPrimeNumber = false;

            // We krijgen 10 trials.
            int maximTrials = 10;

            // Vraag voor user input.
            Console.WriteLine("Enter a number between 0 en 100: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Als het nummer groter is dan 100, vraag dan aan de user om een ander nummer in te vullen.
            if(number > 100) {
                Console.WriteLine("Geen geldig nummer! : Je vulde het getal {0} in " , number);

                // We loopen door het maximTrails, als het resultaat nog altijd niet juist is dan stellen we de vraag opnieuw. 
                for (int j = 0; j < maximTrials; j++) {
                    Console.WriteLine("Vul een ander nummer in!: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    // Als het nummer dan kleiner is dan nul stopt de for loop en gaan we gewoon verder.
                if(number < 100) {
                    break;
                }
            }   
            
            // Als het nummer tussen 0 en 100 is wordt het volgende uitgevoerd.
            } else {
                Console.WriteLine("Het nummer dat je invulde was: {0} ", number);
            }

            // We write a break
            Console.WriteLine();
            
                // We doen number - 1 want als we het getal number zouden doen dan zou het nummer altijd deelbaar zijn door zichzelf.
                for(int i = 2; i <= number - 1; i++) {

                // Als het nummer geen priemgetal is dan zetten we boolPrimeNumber gelijk aan true en stoppen we de loop.
                if(number % i == 0) {
                    Console.WriteLine("Geldig nummer! Het getal: {0} is geen priemgetal ", number);
                    boolPrimeNumber = true;
                    break;
                    }
                }       
    
                // Als boolPrimeNumber false is dan zijn we zeker dat het geen priemgetal is dus is het WEL een priemgetal.
                if(boolPrimeNumber == false) {       
                    Console.WriteLine("Geldig nummer! Het getal: {0} is een priemgetal ", number);
                }  
            }

        /* Oefening 2 */
        private static void uitvoerenFibonacci() {

        }


        }
    }

