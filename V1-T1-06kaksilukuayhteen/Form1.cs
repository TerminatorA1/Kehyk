using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1_T1_06kaksilukuayhteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YhteenlaskuLabel_Click(object sender, EventArgs e)
        {

        }

        private void YhteenlaskuPainike_Click(object sender, EventArgs e)
        {
            int luku1, luku2, summa;
            luku1 = 0;
            luku2 = 0;
            summa = 0;
            try
            {
                luku1 = int.Parse(Luku1tekstilaatikko.Text);
            }
            catch
            {
                YhteenlaskuLabel.Text = "Anna vain numeroina kokonaislukuja";
                Luku1tekstilaatikko.Text = "";
                Luku1tekstilaatikko.Focus();
            }
            try
            {
                luku2 = int.Parse(Luku2tekstilaatikko.Text);
            }
            catch
            {
                YhteenlaskuLabel.Text = "Anna vain numeroina kokonaislukuja";
                Luku2tekstilaatikko.Text = "";
                Luku2tekstilaatikko.Focus();
            }
            summa = luku1 + luku2;
            YhteenlaskuLabel.Visible = true;
            YhteenlaskuLabel.Text = ("" + summa);
        }

        private void Luku1tekstilaatikko_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
