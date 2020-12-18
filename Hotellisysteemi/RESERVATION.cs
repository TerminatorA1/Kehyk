using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellisysteemi
{
    class RESERVATION
    {

        CONNECT conn = new CONNECT();

        // Hae kaikki varaukset
        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `varaukset`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // luodaan toiminto, jolla lisätään uusi varaus

        public bool addReservation(int numero, int asiakasN, DateTime paivaIn, DateTime paivaOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `varaukset` (`huoneN`, `asiakasN`, `paivaIn`, `paivaOut`) VALUES (@rnm, @cid, @din, @dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasN;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = paivaIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaOut;

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
        // tehdään toiminto, jolla muokataan valitun varauksen tietoja
        public bool editReserv(int varausID, int numero, int asiakasN, DateTime paivaIn, DateTime paivaOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `varaukset` SET `huoneN`= @rnm, `asiakasN`= @cid, `paivaIn`= @din,  `paivaOut`= @dout WHERE `varausID`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varausID;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasN;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = paivaIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaOut;
            


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
        // Tehdään toiminto, jolla poistetaan varaus
        public bool removeReserv(int varaus)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `varaukset`  WHERE `varausID`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varaus;

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
