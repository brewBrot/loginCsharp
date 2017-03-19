using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace LoginManagement
{
    class koneksi
   {
        public static MySqlConnection getConnection()
       {
         MySqlConnection kon = null;
         try
         {
             string skonString = "server=localhost ;database=masuk ;uid=root ;password=;";
             kon = new MySqlConnection(skonString);
         }
         catch (MySqlException sqlex)
         {
             
             throw new Exception(sqlex.Message.ToString());
         }
         return kon;

       }

    }
}
