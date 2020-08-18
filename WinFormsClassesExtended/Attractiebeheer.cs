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
    public partial class Attractiebeheer : Form
    {
        public Attractiebeheer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            NieuweAttractie f = new NieuweAttractie();
            f.Show();
            Close();
        }

        private void Attractiebeheer_Load(object sender, EventArgs e)
        {
            lbAttracties.DataSource = Pretparkbeheer.lalaland.AttractieLijst;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Attractie attr = lbAttracties.SelectedItem as Attractie;
            lblNaam.Text = "Naam: " + attr.Naam;
            lblKleur.Text = "Kleur: " + attr.Kleur;
            lblMaxLeetijd.Text = "Max pers: " + attr.MaxPersonen.ToString();
            lblMinLeeftijd.Text = "Min leeft: " + attr.MinLeeftijd.ToString();
        }
    }
}