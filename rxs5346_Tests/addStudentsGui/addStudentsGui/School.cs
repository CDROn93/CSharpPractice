using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addStudentsGui
{
    class School
    {
        private static String SchoolName { get; set; }
        private static int NumPlacementsPerSchool { get; set; }
        private static int NumStudentsAssigned { get; set; }
        private static String Region { get; set; }
        public School()
        {
        }
        public School(String schoolName, int numPlacementsPerSchool, String region)
        {
            SchoolName = schoolName;
            NumPlacementsPerSchool = numPlacementsPerSchool;
            Region = region;

            NumStudentsAssigned = 0;
        }
    }
}
