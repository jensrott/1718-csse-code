using System;

namespace week07
{
    public class Medewerker : Persoon
    {
        // Velden
        private string medewerkernummer;
        private string email;
        private string login;
        private string wachtwoord;
        private Adres campusAdres;

        // Properties
        public String Medewerkernummer { get => medewerkernummer; set => medewerkernummer = value; }
        public String Email { get => email; set => email = value; }
        public String Login { get => login; set => login = value; }
        public String Wachtwoord { get => wachtwoord; set => wachtwoord = value; }
        public Adres CampusAdres { get => campusAdres; set => campusAdres = value; }

        public Medewerker()
        {}
        
        // Argumenten mooier maken door een array mee te geven.
        public Medewerker(string voornaam, string achternaam, string priveEmail, 
        Geslacht geslacht, Adres woonadres, string gsm, DateTime geboortedatum, 
        string geboorteplaats, Adres campus)
        {
            // Properties van basisklasse aanroepen om een waarde toe te kennen.
            base.Voornaam = voornaam;
            base.Naam = achternaam;
            base.Email = priveEmail;
            base.Geslacht = geslacht;
            base.Woonplaats = woonadres;
            base.Gsm = gsm;
            base.Geboortedatum = geboortedatum;
            base.Geboorteplaats = geboorteplaats;
            // Propertes van de subklasse.
            this.CampusAdres = campus;
        }

        public override Int32 getLeeftijd()
        {
            DateTime zero = new DateTime(1,1,1);
            TimeSpan ts = DateTime.Now - this.Geboortedatum;
            return (zero + ts).Year;
        }
    }
}