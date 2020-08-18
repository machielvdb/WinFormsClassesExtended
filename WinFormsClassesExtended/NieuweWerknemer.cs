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
    public partial class NieuweWerknemer : Form
    {
        public NieuweWerknemer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private bool ReturnGeslacht()
        {
            if (rbMan.Checked)
                return true;
            else return false;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text == string.Empty || (rbMan.Checked == false && rbVrouw.Checked == false))
            {
                MessageBox.Show("Gelieve alle velden correct in te vullen.");
            }

            else
            {
                try
                {
                    Werknemer nieuweWerknemer = new Werknemer(tbNaam.Text, dtpDatum.Value.Date, ReturnGeslacht());
                    Pretparkbeheer.lalaland.WerknemerLijst.Add(nieuweWerknemer);
                    Personeelbeheer p = new Personeelbeheer();
                    p.Show();
                    Close();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
