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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(addStudentCheck.Checked)
            {
                removeSchoolGroupBox.Visible = false;
                removeStudentGroupBox.Visible = false;
                addSchoolGroupBox.Visible = false;
                addStudentsGroupBox.Visible = true;
            }
        }

        private void removeStudentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(removeStudentCheck.Checked)
            {
                removeSchoolGroupBox.Visible = false;
                addSchoolGroupBox.Visible = false;
                addStudentsGroupBox.Visible = false;
                removeStudentGroupBox.Visible = true;
            }
        }

        private void addSchoolCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(addSchoolCheck.Checked)
                {
                  removeSchoolGroupBox.Visible = false;
                  addStudentsGroupBox.Visible = false;
                  removeStudentGroupBox.Visible = false;
                  addSchoolGroupBox.Visible = true;
                }
        }

        private void removeSchoolCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(removeSchoolCheck.Checked)
            {
                addSchoolGroupBox.Visible = false;
                removeStudentGroupBox.Visible = false;
                addStudentsGroupBox.Visible = false;
                removeSchoolGroupBox.Visible = true;
            }
        }

        
    }
}
