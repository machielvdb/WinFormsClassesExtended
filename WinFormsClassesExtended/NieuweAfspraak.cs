using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClassesExtended
{
    public partial class NieuweAfspraak : Form
    {
        public NieuweAfspraak()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NieuweAfspraak_Load(object sender, EventArgs e)
        {
            dtpUur.Format = DateTimePickerFormat.Time;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Afspraak a = new Afspraak(dtpDatum.Value.Date, dtpUur.Value, tbReden.Text);
            foreach (Dokter doc in Ziekenhuisbeheer.ziekenhuis.DokterLijst)
            {
                if (doc.Naam == Ziekenhuisbeheer.huidigeDokter.Naam)
                {
                    Ziekenhuisbeheer.ziekenhuis.DokterLijst.Select(doc);
                }
            }
            Close();
        }
    }
}