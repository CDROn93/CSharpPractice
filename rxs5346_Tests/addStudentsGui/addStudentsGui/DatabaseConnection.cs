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
        
        public static void sqlConnectWithDb()
        {
            try
            {
                conn = new MySqlConnection(url + ProblemInfo.username + ProblemInfo.password+ProblemInfo.databaseName);
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
                conn = null;
            }
            if(rdr != null)
            {
                rdr.Close();
                rdr = null;
            }
        }
        public static Boolean checkIfDbExists()
        {
            try
            {
                conn = new MySqlConnection(url + ProblemInfo.username + ProblemInfo.password);
                conn.Open();
                String checkDb = "SHOW DATABASES LIKE '" + ProblemInfo.databaseName + "'"; //this shows the database= in the var 
                MessageBox.Show(checkDb);
                MySqlCommand cmd = new MySqlCommand(checkDb, conn);
                rdr = cmd.ExecuteReader();

                if (rdr.GetString(0) == null)
                {
                    MessageBox.Show("database doesnt exist");
                }
                else
                    MessageBox.Show("Database does exist");
            }
            catch(MySqlException)
            {
                MessageBox.Show("Issue Connecting");
            }
            finally
            {
                sqlDisconnect();
            }
            return true;
        }
    }
}
