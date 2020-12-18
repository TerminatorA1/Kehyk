using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3_Laskin
{
    public partial class Form1 : Form
    {
        // Tehdään laskimen tarvitsemat muuttujat
        Double tulos = 0;
        String toiminto = "";
        bool toimintoSuoritettu = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)

        {
            if (( textBoxResult.Text == "0") || (toimintoSuoritettu))
                textBoxResult.Clear();
                // tarkistetaan onko toiminto
                toimintoSuoritettu = false;
                // otetaan nappien (numerot) tiedot käyttöön ja näytetään Result-tekstiboxissa
                Button button = (Button)sender;

                if(button.Text == ".")
                {
                    if (!textBoxResult.Text.Contains("."))
                        textBoxResult.Text = textBoxResult.Text + button.Text;
                }
                else
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }

            private void operator_click(object sender, EventArgs e)
            {
                // otetaan nappien (operaattorit) tiedot käyttöön 
                Button button = (Button)sender;

                if (tulos != 0)
                {
                    buttonTotal.PerformClick();
                    toiminto = button.Text;
                    labelNykyinenTilanne.Text = tulos + " " + toiminto;
                    toimintoSuoritettu = true;

                }
                else
                {

                    toiminto = button.Text;
                    tulos = Double.Parse(textBoxResult.Text);
                    labelNykyinenTilanne.Text = tulos + " " + toiminto;
                    toimintoSuoritettu = true;
                }
            }

            // Tyhjennysnapit
            private void buttonClearErase_Click(object sender, EventArgs e)
            {
                textBoxResult.Text = "0";
            }

            private void buttonClear_Click(object sender, EventArgs e)
            {
                textBoxResult.Text = "0";
                tulos = 0;
            }

            private void buttonTotal_Click(object sender, EventArgs e)
            {
                   // tehdään laskutoiminnat ja tulos = napille
                switch (toiminto)
                {
                    case "+":
                        textBoxResult.Text = (tulos + Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "-":
                        textBoxResult.Text = (tulos - Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "*":
                        textBoxResult.Text = (tulos * Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        textBoxResult.Text = (tulos / Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    default:
                        break;
                }
            tulos = Double.Parse(textBoxResult.Text);
            labelNykyinenTilanne.Text = "";
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
