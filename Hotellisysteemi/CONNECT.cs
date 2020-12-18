using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotellisysteemi
{
    // Tämä luokka tekee yhteyden ohjelman ja mysql-tietokannan välille
    class CONNECT
    {
        // oman sql.servirin tiedot ja tietokanta
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;user=hotr;password=hotr;database=hotelli");
        // otetaan yhteys 
        public MySqlConnection getConnection()
        {
            return connection;
        }

        // Avaa yhteyden
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Sulkee yhteyden
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
