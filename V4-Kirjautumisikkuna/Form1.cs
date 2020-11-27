using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V4_Kirjautumisikkuna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KirjauduPainike_Click(object sender, EventArgs e)
        {
            String kayttaja = KayttajaTB.Text;
            String salasana = SalasanaTB.Text;
            if(kayttaja == "avanhatalo" && salasana == "Keuda")
            {
                this.Hide();
                Paaikkuna paa = new Paaikkuna();
                paa.Show();
            }
            else
            {
                MessageBox.Show("Käyttäjätunnus tai salasana on väärin", "Virheilmoitus");
            }
        }
    }
}
