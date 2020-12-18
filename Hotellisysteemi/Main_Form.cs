using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellisysteemi
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
        private void Main_FormClosing(object sender,FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseAsiakkaitaForm manageCF = new HallitseAsiakkaitaForm();
            manageCF.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseHuoneitaForm manageRF = new HallitseHuoneitaForm();
            manageRF.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseVarauksiaForm manageRSVF = new HallitseVarauksiaForm();
            manageRSVF.ShowDialog();
        }

        private void lisävalikkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
