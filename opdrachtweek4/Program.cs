using System;

namespace opdrachtweek4
{
    class Program
    {


        // In de main worden onze methods gecalled geef willekeurig getal en uitvoeren fibonacci
        static void Main(string[] args)
        {
            // 
            geefWilleKeurigGetal();
            uitvoerenFibonacci();
            
        } 

        private static void geefWilleKeurigGetal() {
            /* Oefening 1 */
            
            int number;
            Console.WriteLine("Enter a number between 0 en 100");
            number = Convert.ToInt32(Console.ReadLine());

            if(number > 100) {
                Console.WriteLine("Geen geldig nummer! : Je vulde het getal {0} in " , number);
                Console.WriteLine("Vul een ander nummer in! ");
            } else {
                Console.WriteLine("Het nummer dat je invulde was: {0}", number);
            }
                // Nu loopt hij gewoon het aantal keren dat het number is opgegeven bv. 8 dus loop hij 9 keer
                for(int i = 1; i <= number; i++) {
                   if(number % 1 == 0 && number != i && i != 1) {
                       Console.WriteLine("Het getal: {0} is een priemgetal", number);
                       break;
                   } else {
                       Console.WriteLine("Het getal: {0} is geen priemgetal", number);
                   }
                } 
        }

        private static void uitvoerenFibonacci() {

        }


        }

         // Het blijft loopen tot het uiteindelijke wel of niet een priemgetal wordt dus is niet juist
               /* for(int i = 2; i < number; i++) {
                    if(number % i == 0) {
                        Console.WriteLine("Het getal: {0} is een priemgetal", number);
                    } else {
                        Console.WriteLine("Het getal: {0} is geen priemgetal", number);
                    }
                } */  
    }

