using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addStudentsGui
{
    public partial class loginForm : Form
    {
       
        public loginForm()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //check if logged in to database
            Boolean loggedInFlagLocal = false;
            loggedInFlagLocal = true;
            if(loggedInFlagLocal == true)
            {
              
                Form1 loadForm = new Form1();
                loadForm.Show();
                this.Hide();
                
            }
        }

       
    }
}
