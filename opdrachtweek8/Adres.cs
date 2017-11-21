using System;

namespace week07
{

public class Adres
{
    // Velden van de klasse Adres.
    private string straat;
    private int huisnummer;
    private string postbus;
    private Postcode postcode;
    private string telefoonnummer;

    // Constructor met 5 argumenten.
    public Adres(string straat, int nummer, string box, Postcode Postcode, string tel)
    {
      this.huisnummer = nummer;
      this.postbus = box;
      this.postcode = postcode;
      this.straat = straat;
      this.telefoonnummer = tel;
    }

    // Properties
    public String Straat { get => straat; set => straat = value; }
    public Int32 Huisnummer { get => huisnummer; set => huisnummer = value; }
    public String Postbus { get => postbus; set => postbus = value; }
    public Postcode Postcode { get => postcode; set => postcode = value; }
    public String Telefoonnummer { get => telefoonnummer; set => telefoonnummer = value; }
    }
}