using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Afspraak
    {
        public DateTime Datum { get; set; }
        public DateTime Uur { get; set; }
        public string Reden { get; set; }

        public Afspraak(DateTime datum, DateTime uur, string reden)
        {
            Datum = datum;
            Uur = uur;
            Reden = reden;
        }

        public override string ToString()
        {
            return Reden;
        }
    }
}