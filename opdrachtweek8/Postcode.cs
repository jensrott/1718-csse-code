using System;

namespace week07
{
    public struct Postcode
    {
        private string gemeente;
        private int postcode;
        private string provincie;
        private bool isDeelgmeente;

        public Postcode(string gemeente, int postcode) : this(gemeente, false, postcode, "Onbekend")
        {
        }

        public Postcode(string gemeente, bool deelgemeente, int postcode, string provincie)
        {
            this.isDeelgmeente = deelgemeente;
            this.gemeente = gemeente;
            this.postcode = postcode;
            this.provincie = provincie;
        }

        public String Gemeente { get => gemeente; set => gemeente = value; }
        // Naam gewijzigd van Postcode naar Postnummer.
        // error CS0542: 'Postcode': member names cannot be the same as their enclosing type
        public Int32 Postnummer { get => postcode; set => postcode = value; }
        public String Provincie { get => provincie; set => provincie = value; }
        public Boolean IsDeelgmeente { get => isDeelgmeente; set => isDeelgmeente = value; }
    }
}