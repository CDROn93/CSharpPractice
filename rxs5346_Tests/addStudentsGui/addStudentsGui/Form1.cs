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

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if(nameOfStudentAddedBox.Text == "")
            {
                MessageBox.Show("You must atleast enter a student name to place the student in the registry");
                nameOfStudentAddedBox.BackColor = Color.Red;
            }
            else
            {
                nameOfStudentAddedBox.BackColor = Color.White;
                String studentName = replaceSpace(nameOfStudentAddedBox.Text);
                String firstRegion = replaceSpace(firstRegionBox.Text);
                String secondRegion = replaceSpace(secondRegionBox.Text);
                String thirdRegion = replaceSpace(thirdRegionBox.Text);
                String fourthRegion = replaceSpace(fourthRegionBox.Text);
                String fifthRegion = replaceSpace(fifthRegionBox.Text);
                String sixthRegion = replaceSpace(sixthRegionBox.Text);
                String firstWildCard = replaceSpace(firstWildCardBox.Text);
                String secondWildCard = replaceSpace(secondWildCardBox.Text);
                String thirdWildCard = replaceSpace(thirdWildCardBox.Text);
                nameOfStudentAddedBox.Text = "";
                firstRegionBox.Text = "";
                secondRegionBox.Text = "";
                thirdRegionBox.Text = "";
                fourthRegionBox.Text = "";
                fifthRegionBox.Text = "";
                sixthRegionBox.Text = "";
                firstWildCardBox.Text = "";
                secondWildCardBox.Text = "";
                thirdWildCardBox.Text = "";
            }
           

        }

       

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            if(nameOfStudentToRemoveBox.Text == "")
            {
                MessageBox.Show("You must enter a student to remove");
                nameOfStudentToRemoveBox.BackColor = Color.Red;
            }
            else
            {
                String studentToRemoveName = replaceSpace(nameOfStudentToRemoveBox.Text);
                nameOfStudentToRemoveBox.BackColor = Color.White;
                nameOfStudentToRemoveBox.Text = "";
            }
          
        }

       

        private void addSchoolButton_Click(object sender, EventArgs e)
        {
            if(nameOfSchoolToAddBox.Text == "" || numberOfPlacementsBox.Text == "" || regionOfSchoolBox.Text == "")
            {
                MessageBox.Show("You must fill out all of the parts of the form to continue with adding a school");
                if(nameOfSchoolToAddBox.Text=="")
                {
                    nameOfSchoolToAddBox.BackColor = Color.Red;

                }
                if(numberOfPlacementsBox.Text=="")
                {
                    numberOfPlacementsBox.BackColor = Color.Red;
                }
                if(regionOfSchoolBox.Text == "")
                {
                    regionOfSchoolBox.BackColor = Color.Red;
                }
            }
            else
            {
                
                String schoolName = replaceSpace(nameOfSchoolToAddBox.Text);
                nameOfSchoolToAddBox.BackColor=Color.White;
                int numberOfPlacements=0;
                bool parseIntFlag = Int32.TryParse(numberOfPlacementsBox.Text, out numberOfPlacements);
                if(parseIntFlag)
                {
                    numberOfPlacementsBox.BackColor=Color.White;
                     String regionOfSchool = (regionOfSchoolBox.Text);
                    regionOfSchoolBox.BackColor=Color.White;
                    nameOfSchoolToAddBox.Text = "";
                    numberOfPlacementsBox.Text = "";
                    regionOfSchoolBox.Text = "";

                }
                else
                {
                    MessageBox.Show("You must input only a number for the number of placements");
                    numberOfPlacementsBox.BackColor=Color.Red;
                }
             
               
            }
           
        }

       

        private void removeSchoolButton_Click(object sender, EventArgs e)
        {
            if(schoolNameToRemoveBox.Text == "")
            {
                MessageBox.Show("You must specify which school to remove");
                schoolNameToRemoveBox.BackColor = Color.Red;

            }
            else
            {
                String nameOfSchoolToRemove = replaceSpace(schoolNameToRemoveBox.Text);
                schoolNameToRemoveBox.BackColor = Color.White;
            }
            
        }

        //this is to remove the space within input,  mysql doesnt like to process spaces...
        public String replaceSpace(String stringIn)
        {
            String outString = stringIn.Replace(" ", "_");
            return outString;
        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            DatabaseConnection.sqlConnect();
        }
    }
}
