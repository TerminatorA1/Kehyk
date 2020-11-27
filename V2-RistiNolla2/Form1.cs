using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tekijä Atte Vanhatalo

namespace V2_RistiNolla2
{
    public partial class RistiNolla : Form
    {
        bool vuoro = true; // vuoro määrittelee pelivuoron, true on X:n vuoro ja false on O:n vuoro 
        int vuoroLaskuri = 0; // vuorolaskuri kertoo montako kertaa valinta on tehty

        public RistiNolla()
        {
            InitializeComponent();
        }

        private void tekijäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Atte Vanhatalo", "Tekijä");
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Poistuminen ohjelmasta
        }

        private void RistiNolla_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)// X/O klikkaus ja tuloksen anto napille
        {
            Button b = (Button)sender;
            if (vuoro)
                b.Text = "X";
            else
                b.Text = "O";
            vuoro = !vuoro;
            b.Enabled = false;
            vuoroLaskuri++;    
            tarkistaVoittaja();
        }
        private void tarkistaVoittaja() // Voittajan tarkistus
        {
            bool voittajaOn = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) // tarkistus onko vaakarivillä kaikki merkit samoja
                voittajaOn = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                voittajaOn = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                voittajaOn = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) // tarkistus onko pystyrivillä kaikki merkit samoja
                voittajaOn = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                voittajaOn = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                voittajaOn = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) // tarkistus onko vinorillä kaikki merkit samoja
                voittajaOn = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                voittajaOn = true;

            if (voittajaOn)
            {
                napitPois(); // kutsu napit pois metodiin

                String voittaja = "";
                if (vuoro)
                    voittaja = "O";
                else
                    voittaja = "X";
                MessageBox.Show(voittaja + " on voittanut!", "Onnittelut voittajalle");
            }
            else
            {
                if (vuoroLaskuri == 9)
                    MessageBox.Show("Tasuri", "Ei voittajaa");
            }
        }    
            private void napitPois() // laitetaan napit pois päältä
            {
                try
                {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                }
                catch { }



            }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e) // tyhjätään peli, uutta peliä varten
        {
            vuoro = true;
            vuoroLaskuri = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}
