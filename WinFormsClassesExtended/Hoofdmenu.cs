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
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            Pretparkbeheer f = new Pretparkbeheer();
            f.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            Ziekenhuisbeheer f = new Ziekenhuisbeheer();
            f.Show();
        }
    }
}
