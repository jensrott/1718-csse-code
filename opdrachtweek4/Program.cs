using System;

namespace opdrachtweek4
{
    class Program
    {

        // In de main worden onze methods gecalled geef willekeurig getal en uitvoeren fibonacci
        static void Main(string[] args)
        {

           berekenPriemGetal();
           Console.WriteLine();
           uitvoerenFibonacci();
            
        } 

        /* Oefening 1 */
        private static void berekenPriemGetal() {

                // boolean correctNumber wordt gebruikt als flag
                bool correctNumber = false;
                int number;


                // Do while loop om een getal onder 100 op te vragen, zodat we geen verkeerde input kunnen geven
                
                // Doe dit allemaal zolang de boolean correctNumber = false.
                do {
                    Console.WriteLine("Vul een getal in: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Het getal dat je invulde was {0}", number);
                
                    // Writing a line break
                    Console.WriteLine();


                    if (number > 100) {
                        Console.WriteLine("Niet Correct : Vul een getal onder 100 in");
                        number = Convert.ToInt32(Console.ReadLine());

                        if(number < 100) {
                            Console.WriteLine("Correct : Priemgetallen worden berekend");
                            correctNumber = true;
                        }

                    } else if(number < 100) { 
                        Console.WriteLine("Correct : Priemgetallen worden berekend");
                        correctNumber = true;
                    }

                } while (correctNumber == false);

                // Als het nummer kleiner is dan 100, correctNumber = true dan gebeurd alles hieronder
                // We loopen eerst door alle getallen
                for(int i = 0; i <= number; i++) {

                    if (i % 2 == 0) {
                        // Uitzondering voor het getal 2
                        if (i == 2) {
                                Console.WriteLine(i + " is een priemgetal");
                        } else { 
                                Console.WriteLine(i + " is geen priemgetal.");
                        } 

                    } 

                    else {
                        // Uitzondering voor het getal 1
                        if (i == 1) {
                                Console.WriteLine(i + " is geen priemgetal");
                        } else { 
                                Console.WriteLine(i + " is een priemgetal.");
                        }
                    }    
                }
            }  

        /* Oefening 2 */
            private static void uitvoerenFibonacci() {

                Console.WriteLine("Vul de lengte in van de sequence");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("De lengte die je invulde was: {0} ", number);

                Console.WriteLine();

                int x = 0;
                int y = 1;
                
                for(int i = 0; i < number; i++) {
                    // We starten met 0 
                    int z = x;
                    // Het volgende getal is dan 1
                    x = y;
                    // De getallen die naast elkaar staan worden altijd opgeteld 0 + 1 wordt 1
                    // De getallen schuiven op en de loop gaat altijd door op dezelfde manier
                    y = z + y;
                    Console.WriteLine(z); 
                }
            } 
        }
    }

