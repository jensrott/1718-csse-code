using System;

namespace week07
{

  // Enumenation
  public enum Geslacht
  {
      Onbekend,
      Man,
      Vrouw
  }

  public class Persoon
  {
    private string voornaam;
    private string naam;
    private Int32 leeftijd;
    private Geslacht geslacht;
    private Adres woonplaats;
    private string email;
    private string gsm;
    private DateTime geboortedatum;
    private string geboorteplaats;

    // Default constructer, als er geen parameter is meegegeven is het standaard onbekend.
    public Persoon()
    {
      this.geslacht = Geslacht.Onbekend;
    }

    public Persoon(string naam, string voornaam, Geslacht geslacht = Geslacht.Onbekend)
    {
        this.naam = naam;
        this.voornaam = voornaam;
    }

    public String Voornaam { get => voornaam; set => voornaam = value; }
    public String Naam { get => naam; set => naam = value; }
    public String Email { get => email; set => email = value; }
    public Int32 Leeftijd { get => leeftijd; set => leeftijd = value; }
    public Geslacht Geslacht { get => geslacht; set => geslacht = value; }
    public Adres Woonplaats { get => woonplaats; set => woonplaats = value; }
    public String Gsm { get => gsm; set => gsm = value; }
    public DateTime Geboortedatum { get => geboortedatum; set => geboortedatum = value; }
    public String Geboorteplaats { get => geboorteplaats; set => geboorteplaats = value; }

    // CreateAhsMail methode maken

    public virtual Int32 getLeeftijd()
    {
      DateTime zero = new DateTime(1,1,1);
      TimeSpan ts = DateTime.Now - this.Geboortedatum;
      return (zero + ts).Year;
    }   
  }
}