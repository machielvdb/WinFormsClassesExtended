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
    public partial class NieuweAttractie : Form
    {
        public NieuweAttractie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            int maxPers, minLeeftijd;
            if (tbNaam.Text == string.Empty || tbKleur.Text == string.Empty || tbMinLeeftijd.Text == string.Empty || tbMaxPersonen.Text == string.Empty)
            {
                MessageBox.Show("Gelieve alle velden in te vullen.");
            }

            else if (!int.TryParse(tbMaxPersonen.Text, out maxPers) || !int.TryParse(tbMinLeeftijd.Text, out minLeeftijd))
            {
                MessageBox.Show("Gelieve geldige input te geven.");
            }

            else
            {
                Attractie a = new Attractie(tbNaam.Text, tbKleur.Text, maxPers, minLeeftijd);
                Pretparkbeheer.lalaland.AttractieLijst.Add(a);
                Attractiebeheer f = new Attractiebeheer();
                f.Show();
                Close();
            }
        }
    }
}
