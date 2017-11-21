using System;

namespace week07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Het aanmaken van een instantie van het type Postcode.
            Postcode postcode1 = new Postcode("Mariakerke", 9030);
            // Het aanmaken van een instantie van het type Adres.
            Adres adres1 = new Adres("Industrieweg", 232, "", postcode1, "092348600");
            // Het aanmaken van een instantie van het type Persoon.
            // DateTime date1 = new DateTime(2015, 9, 1);
            Persoon persoon1 = new Persoon();
            persoon1.Voornaam = "Kristof";
            persoon1.Naam = "Raes";
            // Geslacht is nu "Man", niet "Onbekend".
            persoon1.Geslacht = Geslacht.Man;
            // Het aanmaken van een instantie van het type Medewerker.
            // Medewerker medewerker1 = new Medewerker();
            //medewerker1.

            // Het aanmaken van een instantie van het type Student.
            //Student student1 = new Student();
            //student1.

            Medewerker medewerker1 = new Medewerker();
            DateTime gb1 = new DateTime(2015, 9, 1);
            medewerker1.Geboortedatum = new DateTime(1986, 03, 1);
            Console.WriteLine("Leeftijd is: {0}", medewerker1.getLeeftijd());
        }
    }
}
