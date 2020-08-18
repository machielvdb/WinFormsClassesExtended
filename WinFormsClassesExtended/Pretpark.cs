using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Pretpark
    {
        public string Naam { get; set; }
        public List<Werknemer> WerknemerLijst { get; set; }
        public List<Attractie> AttractieLijst { get; set; }

        public Pretpark(string naam)
        {
            Naam = naam;
            WerknemerLijst = new List<Werknemer>();
            AttractieLijst = new List<Attractie>();
        }

        public Pretpark(Werknemer werknemer)
        {
            WerknemerLijst.Add(werknemer);
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
