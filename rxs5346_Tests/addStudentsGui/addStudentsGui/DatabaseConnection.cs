using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addStudentsGui
{
    public class DatabaseConnection
    {
       static MySqlConnection conn = null;
        static MySqlDataReader rdr = null;
        static string url = "server=localhost;";
        
        public static void sqlConnect()
        {
            try
            {
                conn = new MySqlConnection(url + ProblemInfo.username + ProblemInfo.password + ProblemInfo.databaseName);
                conn.Open();
                MessageBox.Show("My SQL Version " + conn.ServerVersion);
            }
            catch(MySqlException)
            {
                MessageBox.Show("ISSUE CONNECTING");
            }
            finally
            {
                sqlDisconnect();
            }
        }
        public static void sqlDisconnect()
        {
            if(conn != null)
            {
                conn.Close();
                MessageBox.Show("Disconnected");
                conn = null;
            }
        }
    }
}
