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
            AfsprakenLijst = new List<Afspraak>();
        }

        public Dokter(Afspraak a)
        {
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

        public void AfspraakToevoegen(Afspraak a)
        {
            AfsprakenLijst.Add(a);
        }
    }
}
