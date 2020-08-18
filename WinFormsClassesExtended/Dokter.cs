using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Dokter
    {
        public string Naam { get; set; }
        public List<Afspraak> AfsprakenLijst { get; set; }

        public Dokter(string naam)
        {
            Naam = naam;
        }

        public Dokter(Afspraak a)
        {
            AfsprakenLijst = new List<Afspraak>();
            AfsprakenLijst.Add(a);
        }

        public Dokter(string naam, Afspraak a)
        {
            AfsprakenLijst = new List<Afspraak>();
            AfsprakenLijst.Add(a);
            Naam = naam;
        }

        public override string ToString()
        {
            return Naam;
        }

        public Dokter()
        {

        }
    }
}
