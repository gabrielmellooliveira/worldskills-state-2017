using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Util
{
    class CreateDataBase
    {
        public static void create()
        {
            // User: root
            // Password: root

            /*DBConnectioin dBConnectioin = new DBConnectioin();

            dBConnectioin.hostName = "localhost";

            dBConnectioin.baseName = "oc2018";

            dBConnectioin.loginName = "root";

            dBConnectioin.passWord = "root";

            dBConnectioin.Write();*/

            /*string connStr = "server=localhost;user=root;port=3306;password=root;";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `OC2017`;";
                cmd.ExecuteNonQuery();
            }*/
        }
    }
}
