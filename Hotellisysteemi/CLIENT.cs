using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellisysteemi
{
    // asiakashallintaa varten tehty luokka, jolla haetaan, luodaan, muokataan tai poistetaan asiakas.
    class CLIENT
    {
        CONNECT conn = new CONNECT();

        // Luodaan toiminta uuden asiakkaan lisäämistä varten
       public bool insertClient (String ema, String enimi, String snimi,  String katuo, String postin , String postit, String maat, String puhel, String salas)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `asiakkaat` (`email`, `etunimi`, `sukunimi`, `postiosoite`,`postinumero`,`postitoimipaikka`,`maa`,`puhelin`, `salasana`) VALUES (@ema, @fnm, @lnm, @str ,@pno, @ptr, @cnt, @phn, @pass)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@ema", MySqlDbType.VarChar).Value = ema;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = enimi;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = snimi;
            command.Parameters.Add("@str", MySqlDbType.VarChar).Value = katuo;
            command.Parameters.Add("@pno", MySqlDbType.VarChar).Value = postin;
            command.Parameters.Add("@ptr", MySqlDbType.VarChar).Value = postit;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = maat;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhel;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salas;

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
        
        // tee hakutoiminta koko asiakaskannalle
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `asiakkaat`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // tee hakutoiminta asiakkaan muokkausta varten

        public bool editClient( int id, String ema, String enimi, String snimi, String katuo, String postin, String postit, String maat, String puhel, String salas)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `asiakkaat` SET `etunimi`= @fnm, `sukunimi`= @lnm, `postiosoite`= @str, `postinumero`= @pno, `postitoimipaikka`= @ptr,`maa`= @cnt, `puhelin`= @phn, `salasana`= @pass  WHERE `asiakasID`=@cid";
            
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@ema", MySqlDbType.VarChar).Value = ema;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = enimi;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = snimi;
            command.Parameters.Add("@str", MySqlDbType.VarChar).Value = katuo;
            command.Parameters.Add("@pno", MySqlDbType.VarChar).Value = postin;
            command.Parameters.Add("@ptr", MySqlDbType.VarChar).Value = postit;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = maat;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhel;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salas;

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

        // tee toiminto asiakkaan poistamista varten

        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `asiakkaat`  WHERE `asiakasID`=@cid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // Annetaan muuttujille arvot
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

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
