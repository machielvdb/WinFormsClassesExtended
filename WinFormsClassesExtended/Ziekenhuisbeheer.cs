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
    public partial class Ziekenhuisbeheer : Form
    {
        public static Ziekenhuis ziekenhuis = new Ziekenhuis();
        public List<string> naamLijst = new List<string>() { "Geeraerd", "Dekorte", "Demessemaeker" };
        public static Dokter huidigeDokter;
        public Ziekenhuisbeheer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnNieuweAfspraak_Click(object sender, EventArgs e)
        {
            NieuweAfspraak f = new NieuweAfspraak();
            f.Show();
        }

        private void ToonAfspraken()
        {
            huidigeDokter = lbDokters.SelectedItem as Dokter;
            foreach (var item in ziekenhuis.DokterLijst)
            {
                if (huidigeDokter == item)
                {
                    lbAfspraken.DataSource = item.AfsprakenLijst;
                }
            }
        }

        private void Ziekenhuisbeheer_Load(object sender, EventArgs e)
        {
            foreach (var item in naamLijst)
            {
                Dokter d = new Dokter(item);
                ziekenhuis.DokterLijst.Add(d);
            }
            lbDokters.DataSource = ziekenhuis.DokterLijst;

            btnNieuweAfspraak.Enabled = false;
        }

        private void lbDokters_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNieuweAfspraak.Enabled = true;
            ToonAfspraken();
        }
    }
}