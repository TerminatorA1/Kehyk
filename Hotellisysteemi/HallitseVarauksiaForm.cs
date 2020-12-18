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
    public partial class HallitseVarauksiaForm : Form
    {
        public HallitseVarauksiaForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();

        // haetaan tiedot kenttiin varaussivustolle
        private void HallitseVarauksiaForm_Load(object sender, EventArgs e)
        {
            // näyttää huonetyypit
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "huonetyypit"; // label, huonetyypit?
            comboBoxRoomType.ValueMember = "huonetyyppiID"; // category_id, huonetyyppi?
            
            // näyttää huoneet valitun tyypin mukaisesti
            // int tyyppi = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            comboBoxHnumero.DataSource = room.roomByType(1);
            comboBoxHnumero.DisplayMember = "hnumero";
            comboBoxHnumero.ValueMember = "hnumero";

            // näyttää kaikki varaukset datagridistä
            dataGridView3.DataSource = reservation.getAllReserv();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxVarausID.Text = "";
            textBoxAsiakasID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;


        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // näyttää huoneet valitun tyypin mukaisesti
                int tyyppi = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxHnumero.DataSource = room.roomByType(tyyppi);
                comboBoxHnumero.DisplayMember = "hnumero";
                comboBoxHnumero.ValueMember = "hnumero";
            }catch(Exception)
            {
                // ei toimintaa
            }
        }

        // Uuden varauksen tekeminen
        private void buttonAddReserv_Click(object sender, EventArgs e)
        {
            try
            {

                int asiakasN = Convert.ToInt32(textBoxAsiakasID.Text);
                int huoneN = Convert.ToInt32(comboBoxHnumero.SelectedValue);
                DateTime paivaIn = dateTimePickerIN.Value;
                DateTime paivaOut = dateTimePickerOUT.Value;

                // Päiväyksen tarkistus onko varaus => tänään ja onko lähtöpäivä > tulopäivä
                if (paivaIn.Day < DateTime.Now.Day)
                {
                    MessageBox.Show("Lähtöpäivä ei voi olla menneisyydessä", "Varausaikatarkistus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (paivaOut.Day < paivaIn.Day)
                {
                    MessageBox.Show("Lähtöpäivä ei voi olla ennen tulopäivää", "Varausaikatarkistus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(huoneN, asiakasN, paivaIn, paivaOut))
                    {
                        room.setRoomFree(huoneN, "Ei");
                        dataGridView3.DataSource = reservation.getAllReserv();
                        MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen teko", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen lisäys ei onnistunut", "Varauksen teko", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Virheilmoitus",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {

            try
            {
                int varausID = Convert.ToInt32(textBoxVarausID.Text);
                int asiakasN = Convert.ToInt32(textBoxAsiakasID.Text);
                int huoneN = Convert.ToInt32(comboBoxHnumero.SelectedValue);
                DateTime paivaIn = dateTimePickerIN.Value;
                DateTime paivaOut = dateTimePickerOUT.Value;

                // Päiväyksen tarkistus onko varaus => tänään ja onko lähtöpäivä > tulopäivä
                if (paivaIn < DateTime.Now)
                {
                    MessageBox.Show("Lähtöpäivä ei voi olla menneisyydessä", "Varausaikatarkistus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (paivaOut < paivaIn)
                {
                    MessageBox.Show("Lähtöpäivä ei voi olla ennen tulopäivää", "Varausaikatarkistus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.editReserv(varausID, huoneN, asiakasN, paivaIn, paivaOut))
                    {
                        room.setRoomFreeToNo(huoneN);
                        MessageBox.Show("Varaus muokattu onnistuneesti", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen muokkaus ei onnistunut", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virheilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // haetaan datagridistä valitun varauksen tiedot oikeisiin kenttiin
            textBoxVarausID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            int huoneN = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value.ToString());
            comboBoxRoomType.SelectedValue = room.getRoomType(huoneN);
            comboBoxHnumero.SelectedValue = huoneN;
            textBoxAsiakasID.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        // Tehdään toiminto, jolla poistetaan varaus
        private void buttonRemoveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = Convert.ToInt32(textBoxVarausID.Text);
                int huoneN = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value.ToString());

                if (reservation.removeReserv(varausID))
                {
                    dataGridView3.DataSource = reservation.getAllReserv();
                    room.setRoomFree(huoneN, "Kyllä");
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virheilmoitus varauksen poistossa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        



    // ongelma sql komennossa ALTER TABLE huoneet ADD CONSTRAINT fk_type_id (htyyppi) REFERENCES huonetyyppi (huoneet) ON UPDATE CASCADE ON DELETE CASCADE 
    // ja ALTER TABLE varaukset ADD CONSTRAINT fk_room_number FOREIGN KEY (huoneN) REFERENCES huoneet (hnumero) ON UPDATE CASCADE ON DELETE CASCADE
    // ALTER TABLE varaukset ADD CONSTRAINT fk_client_id FOREIGN KEY (asiakasN) REFERENCES asiakkaat (asiakasID) ON UPDATE CASCADE ON DELETE CASCADE, onnistui
}
}

