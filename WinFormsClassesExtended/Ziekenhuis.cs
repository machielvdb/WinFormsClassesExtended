using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassesExtended
{
    public class Ziekenhuis
    {
        public List<Dokter> DokterLijst { get; set; }
        public Ziekenhuis()
        {
            DokterLijst = new List<Dokter>();
        }
    }
}
