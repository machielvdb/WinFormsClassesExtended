using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public bool Geslacht { get; set; }

        public Werknemer(string naam, DateTime geboortedatum, bool geslacht)
        {
            Naam = naam;
            Geboortedatum = geboortedatum;
            Geslacht = geslacht;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
