using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addStudentsGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
            
            //NEED TO CLOSE THE LOGIN FORM WHEN CLOSING THE APPLICATION>.... not just hide it... memmory leak
        }
    }
}
