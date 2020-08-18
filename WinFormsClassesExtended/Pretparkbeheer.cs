using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClassesExtended
{
    public partial class Pretparkbeheer : Form
    {
        public static Pretpark lalaland = new Pretpark("Lalaland");
        public Pretparkbeheer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Pretparkbeheer_Load(object sender, EventArgs e)
        {
            lblNaam.Text = lalaland.ToString();
        }

        private void btnWerknemers_Click(object sender, EventArgs e)
        {
            Personeelbeheer f = new Personeelbeheer();
            f.Show();
            Close();
        }

        private void btnAttracties_Click(object sender, EventArgs e)
        {
            Attractiebeheer f = new Attractiebeheer();
            f.Show();
            Close();
        }
    }
}
