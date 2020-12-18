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
    public partial class HallitseHuoneitaForm : Form
    {
        public HallitseHuoneitaForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();

        private void HallitseHuoneitaForm_Load(object sender, EventArgs e) // haetaan kenttiin tiedot 
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "huonetyypit";
            comboBoxRoomType.ValueMember = "huonetyyppiID";

            dataGridView3.DataSource = room.getRooms();

        }
        // Lisää huone toiminnot
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            
            int tyyppi = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string rpuhelin = textBoxPuhelin.Text;
            string vapaa = "";

            try
            {
                int numero = Convert.ToInt32(textBoxHuoneNumero.Text);


                if (radioButtonYes.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (radioButtonNo.Checked)
                {
                    vapaa = "Ei";
                }

                if (room.addRoom(numero, tyyppi, rpuhelin, vapaa))
                {
                    dataGridView3.DataSource = room.getRooms();
                    MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen lisäys ei onnistunut", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huonenumerossa virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // Muokkaa huonetta toiminnot
        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            
            int tyyppi = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String rpuhelin = textBoxPuhelin.Text;
            String vapaa ="";

            try
            {
                int numero = Convert.ToInt32(textBoxHuoneNumero.Text);
                if (radioButtonYes.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (radioButtonNo.Checked)
                {
                    vapaa = "Ei";
                }

                if (room.editRoom(numero, tyyppi, rpuhelin, vapaa))
                {
                    dataGridView3.DataSource = room.getRooms();
                    MessageBox.Show("Huoneen tiedot päivitetty onnistuneesti", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen tietojen päivitys ei onnistunut", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huonenumerossa virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
        // Poista huone toiminto
        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {


                int numero = Convert.ToInt32(textBoxHuoneNumero.Text);

                if (room.removeRoom(numero))
                {
                    dataGridView3.DataSource = room.getRooms();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen poisto ei onnistunut", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huonenumerossa virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxHuoneNumero.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxPuhelin.Text = "";
            radioButtonYes.Checked = true;

        }

        // Näytä valitun datagrid kohdan tiedot ruuduissa
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHuoneNumero.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView3.CurrentRow.Cells[2].Value;
            textBoxPuhelin.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();

            string vapaa = dataGridView3.CurrentRow.Cells[4].Value.ToString();

            if (vapaa.Equals("Kyllä"))
            {
                radioButtonYes.Checked = true;
            }
            else if(vapaa.Equals("Ei"))
                {
                radioButtonNo.Checked = true;
                }

        }
    }
}
