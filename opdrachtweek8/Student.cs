using System;

namespace week07
{
  public class Student : Persoon , IAccount
  {
    // Velden
    private string studentnummer;
    private string email;
    private string login;
    private string wachtwoord;

    // Properties
    public String Studentnummer { get => studentnummer; set => studentnummer = value; }
    public String Email { get => email; set => email = value; }
    public String Login { get => login; set => login = value; }
    public String Wachtwoord { get => wachtwoord; set => wachtwoord = value; }

    public Student()
    {}
public Student(string voornaam, string achternaam, string priveEmail, 
    Geslacht geslacht, Adres woonadres, string gsm, DateTime geboortedatum, 
    string geboorteplaats)
    {
      // Properties van basisklasse aanroepen om een waarde toe te kennen.
      base.Voornaam = voornaam;
      base.Naam = achternaam;
      base.Email = priveEmail;
      base.Geslacht = Geslacht;
      base.Woonplaats = woonadres;
      base.Gsm = gsm;
      base.Geboortedatum = geboortedatum;
      base.Geboorteplaats = geboorteplaats;
      // Propertes van de subklasse.
      //this.email = schoolEmail;
    }

    public Student(string naam, string voornaam) : base(naam, voornaam)
    {}

    // Dit is de oplossing van de error:
    // Student does not implement interface member 'IAccount.getLeeftijd()'
      public override Int32 getLeeftijd()
    {
      DateTime zero = new DateTime(1,1,1);
      TimeSpan ts = DateTime.Now - this.Geboortedatum;
      return (zero + ts).Year;
    }  
  }
}