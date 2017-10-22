using System;

namespace opdrachtweek4
{
    class Program
    {

        // In de main worden onze methods gecalled geef willekeurig getal en uitvoeren fibonacci
        static void Main(string[] args)
        {

           geefWilleKeurigGetal();
           Console.WriteLine();
           uitvoerenFibonacci();
            
        } 

        /* Oefening 1 */
        private static void geefWilleKeurigGetal() {
        

                Console.WriteLine("Vul een getal in: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("De getal dat je invulde was {0}", number);

                Console.WriteLine();

                // We loopen eerst door alle getallen
                for(int i = 0; i < number; i++) {

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
                Console.WriteLine("De lengte die je invulde was {0}", number);

                Console.WriteLine();

                int x = 0;
                int y = 1;
                
                for(int i = 0; i < number; i++) {
                    int z = x + y;
                    Console.WriteLine(z); 
                    x = y;
                    y = z;
                }
            } 
        }
    }

