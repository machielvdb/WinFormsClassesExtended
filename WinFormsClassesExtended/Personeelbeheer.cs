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
    public partial class Personeelbeheer : Form
    {
        public Personeelbeheer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            NieuweWerknemer f = new NieuweWerknemer();
            f.Show();
            Close();
        }

        private void Personeelbeheer_Load(object sender, EventArgs e)
        {
            lbWerknemers.DataSource = Pretparkbeheer.lalaland.WerknemerLijst;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Werknemer werknemer = lbWerknemers.SelectedItem as Werknemer;
            lblNaam.Text = werknemer.Naam;
            if (werknemer.Geslacht)
                lblGeslacht.Text = "Man";
            else
                lblGeslacht.Text = "Vrouw";
            lblDatum.Text = werknemer.Geboortedatum.ToShortDateString();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Werknemer werknemer = lbWerknemers.SelectedItem as Werknemer;
            foreach (Werknemer w in Pretparkbeheer.lalaland.WerknemerLijst)
            {
                if (w == werknemer)
                {
                    Pretparkbeheer.lalaland.WerknemerLijst.Remove(w);
                }
            }
        }
    }
}
