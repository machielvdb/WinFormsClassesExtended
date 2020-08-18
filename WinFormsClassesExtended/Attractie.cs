using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Attractie
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public int MinLeeftijd { get; set; }
        public int MaxPersonen { get; set; }

        public Attractie(string naam, string kleur, int minleeftijd, int maxpersonen)
        {
            Naam = naam;
            Kleur = kleur;
            MinLeeftijd = minleeftijd;
            MaxPersonen = maxpersonen;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
