using System;
// Nodig voor threads te kunnen gebruiken
using System.Threading;

delegate int NumberReached(int x);

namespace opdrachtweek11
{
    class Program
    {

        /* Ik heb een poging geworpen om deze oefening te proberen maken
           maar zoals u kunt zien is dit niet honder procent gelukt. */

        /* EVENTS */
        event NumberReached MyEvent;
       

        
    

        // Subscriben naar onze events
        public Program()
        {
            this.MyEvent += new NumberReached(printData);

        }

        static void Main(string[] args)
        {

            /* THREADS */


            Thread thread1 = new Thread(RandomNumberInput);
            thread1.Start();

            Thread thread2 = new Thread(LoopNumbers);
            thread2.Start();

            Thread thread3 = new Thread(RandomNumberUntilMax);
            thread3.Start();

            Thread thread4 = new Thread(AskForUserInput);
            thread4.Start();
           
            // Instanties maken van de delegates voor Maxnumber
            NumberReached nc = new NumberReached(MaxNumber);

            

            
    
            // Instantie van de program Method
            Program p1 = new Program();
            p1.AskForUserInput();
            

        }

        /* EVENTHANDLER */ 
        private static void newHandler(object sender, ConsoleCancelEventArgs e)
        {
        Console.WriteLine("test");
        Console.WriteLine("ingedrukte toets: {0}", e.SpecialKey);
        e.Cancel = true;
        }

        /* METHODS */

        public void AskForUserInput() {
            Console.WriteLine("Enter a max number");
            int Maxnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you entered was {0}", Maxnumber);
            int[] numberCollection = new int[Maxnumber];
            
        }

        public static void RandomNumberInput() 
        {

        }

        public static void LoopNumbers(int[] numberCollection)
        {
            // Numbers is een array
            for(int i = 0; i < numberCollection.Length; i++) {
                Console.WriteLine("{}");
            }
        }

        public Random randnum = new Random();
        public void RandomNumberUntilMax(int MaxNumber) 
        {

            // Het maxnummer moeten we dan weten
            for(int j = 0; j <= MaxNumber; j++) {
                int randNo = randnum.Next(0, MaxNumber);
                Console.WriteLine(randNo);
            }
        }

        

        // Gegevens zoals timestamp, thread en getal worden in deze method getoond
        // Als het maximnummer word geraakt
        public static int printData(int MaxNumber) 
        {

            Console.WriteLine(DateTime.Now);
            return MaxNumber; 


        }
    }
}


