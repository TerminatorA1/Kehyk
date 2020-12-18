using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellisysteemi
{
    // tässä luokassa hallitsemme huoneita
    class ROOM
    {
        CONNECT conn = new CONNECT();
        // luodaan toiminto, jolla listataan huone tyypit
        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `huonetyyppi`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }
        // luodaan toiminto, jolla listataan tyypin mukaiset huoneet
               public DataTable roomByType(int tyyppi)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `huoneet` WHERE `htyyppi`=@typ", conn.getConnection()); // Huonevarattu lisäystarkistus ei onnistunut
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = tyyppi;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // luodaan toiminto, jolla haetaan huonetyyppiID
        public int getRoomType(int hnumero)
        {
            MySqlCommand command = new MySqlCommand("SELECT `htyyppi` FROM `huoneet` WHERE `hnumero`=@num", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = hnumero;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return Convert.ToInt32(table.Rows[0][0].ToString());
        }


        // luodaan toiminto, jolla muutetaan huoneen varaustilanne hvapaa, Kyllä -> Ei, ei toimi halutusti, tarkistetaan myöhemmin 17.12. 14.18
        public bool setRoomFreeToNo(int hnumero)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `huoneet` SET `hvapaa`=2  WHERE `hnumero`=@num", conn.getConnection()); // Huonevarattu lisäystarkistus ei onnistunut
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = hnumero;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
            
        }

        // luodaan toiminto, jolla muutetaan huoneen varaustilanne hvapaa, Kyllä -> 
        public bool setRoomFree(int hnumero, String Yes_or_No)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `huoneet` SET `hvapaa`=@yes_no  WHERE `hnumero`=@num", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = hnumero;
            command.Parameters.Add("@yes_no", MySqlDbType.VarChar).Value = Yes_or_No;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }


        // luodaan toiminto, jolla lisätään uusi huone

        public bool addRoom(int numero, int tyyppi, String rpuhelin, String vapaa)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `huoneet` (`hnumero`, `htyyppi`, `hpuhelin`, `hvapaa`) VALUES (@num, @tp, @rphn, @fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            command.Parameters.Add("@rphn", MySqlDbType.VarChar).Value = rpuhelin;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;
            
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

        // tehdään toiminto, jolla haetaan huoneiden tiedot

        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `huoneet`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // tehdään toiminto, jolla muokataan huoneen tietoja
        public bool editRoom(int numero, int tyyppi, String rpuhelin, String vapaa)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `huoneet` SET `htyyppi`= @tp, `hpuhelin`= @rphn, `hvapaa`= @fr WHERE `hnumero`=@num";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            command.Parameters.Add("@rphn", MySqlDbType.VarChar).Value = rpuhelin;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;
            

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // Tehdään toiminto, jolla poistetaan huone
        public bool removeRoom(int numero)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `huoneet`  WHERE `hnumero`=@num";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            conn.openConnection();
            
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

            
        }
        

    }
}
