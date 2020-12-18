using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // lisätty mysql-luokka


namespace Hotellisysteemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // tehdään lähetysnapille toiminnat, yhteys mysql kantaan 
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `asiakkaat` WHERE `email`=@email AND `salasana`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // tarkistetaan onko annetut arvot tietokannassa
            if (table.Rows.Count > 0)
            {
                // Piilotetaan kirjautumissivu ja siirrytään pääsivulle
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();

            }
            else // loppuosa tekee ilmoitukset jos annetut tunnukset ovat tyhjiä tai väärin
            {
                if(textBoxUsername.Text.Trim().Equals(""))
                    {
                    MessageBox.Show("Lisää käyttäjätunnuksesi", "Tyhjä sähköpostiosoite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else if (textBoxPassword.Text.Trim().Equals(""))
                    {
                    MessageBox.Show("Lisää salasanasi", "Tyhjä salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                {
                    MessageBox.Show("Sähköpostiosoitteesi ja/tai salasanasi on väärin", "Väärät tunnukset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
