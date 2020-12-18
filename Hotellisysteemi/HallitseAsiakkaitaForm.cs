using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellisysteemi
{
    public partial class HallitseAsiakkaitaForm : Form
    {
        CLIENT client = new CLIENT();
        public HallitseAsiakkaitaForm()
        {
            InitializeComponent();
        }
        private void HallitseAsiakkaitaForm_Load_1(object sender, EventArgs e)
        {
            dataGridView3.DataSource = client.getClients(); // haetaan asiakastiedot datagridistä
        }
        

        // tekstikenttien tyhjäys nappi
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBoxID.Text = "";
            textBoxEtunimi.Text = "";
            textBoxSukunimi.Text = "";
            textBoxKatuosoite.Text = "";
            textBoxPostinumero.Text = "";
            textBoxPostitoimipaikka.Text = "";
            textBoxMaa.Text = "";
            textBoxPuhelin.Text = "";
            textBoxSalasana.Text = "";
            
        }
        // uusi asiakas nappi ja muuttujat/toiminnat
        private void buttonNew_Click(object sender, EventArgs e)
        {
            String ema = textBoxID.Text;
            String enimi = textBoxEtunimi.Text;
            String snimi = textBoxSukunimi.Text;
            String katuo = textBoxKatuosoite.Text;
            String postin = textBoxPostinumero.Text;
            String postit = textBoxPostitoimipaikka.Text;
            String maat = textBoxMaa.Text;
            String puhel = textBoxPuhelin.Text;
            String salas = textBoxSalasana.Text;

            // kenttien tarkistus (osa ei pakollisia)
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhel.Trim().Equals(""))
            {
                MessageBox.Show("Pakollisia kenttiä puuttuu", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(ema, enimi, snimi, katuo, postin, postit, maat, puhel, salas);

                if (insertClient)
                {
                    dataGridView3.DataSource = client.getClients();
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uuden asiakkaan lisäys ei onnistunut", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void HallitseAsiakkaitaForm_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = client.getClients();
        }

        // muokkaa asiakasta nappi ja sen muuttujat/toiminnat
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            String ema = textBoxID.Text;
            String enimi = textBoxEtunimi.Text;
            String snimi = textBoxSukunimi.Text;
            String katuo = textBoxKatuosoite.Text;
            String postin = textBoxPostinumero.Text;
            String postit = textBoxPostitoimipaikka.Text;
            String maat = textBoxMaa.Text;
            String puhel = textBoxPuhelin.Text;
            String salas = textBoxSalasana.Text;

            // kenttien tarkistus (osa ei pakollisia)
            try
            {
                id = Convert.ToInt32(textBox1.Text);
                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhel.Trim().Equals(""))
                {
                    MessageBox.Show("Pakollisia kenttiä puuttuu", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = client.editClient(id, ema, enimi, snimi, katuo, postin, postit, maat, puhel, salas);

                    if (insertClient)
                    {
                        dataGridView3.DataSource = client.getClients();
                        MessageBox.Show("Asiakas muokattu onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uuden asiakkaan muokkaus ei onnistunut", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       

        }

        // asiakkaan poisto nappi ja toiminnat
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox1.Text);

                if(client.removeClient(id))
                {
                    dataGridView3.DataSource = client.getClients();
                    MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // lopuksi tyhjätään valinta kentät
                    buttonRemove.PerformClick();
                }
                else
                {
                    MessageBox.Show("Asiakkaan poisto ei onnistunut", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        // Tämä toiminta tuo datagridin valitusta kohdasta tiedot lomakkeen tekstikenttiin
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBoxID.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBoxEtunimi.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBoxSukunimi.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBoxKatuosoite.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBoxPostinumero.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            textBoxPostitoimipaikka.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            textBoxMaa.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            textBoxPuhelin.Text = dataGridView3.CurrentRow.Cells[11].Value.ToString();
            textBoxSalasana.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
