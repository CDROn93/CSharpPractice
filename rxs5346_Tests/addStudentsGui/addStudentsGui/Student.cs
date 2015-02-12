using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addStudentsGui
{
    class Student
    {
        private static string Name { get; set; }
        private static string FirstRegion { get; set; }
        private static string SecondRegion { get; set; }
        private static string ThirdRegion { get; set; }
        private static string FourthRegion { get; set; }
        private static string FifthRegion { get; set; }
        private static string SixthRegion { get; set; }
        private static string FirstWildCard { get; set; }
        private static string SecondWildCard { get; set; }
        private static string ThirdWildCard { get; set; }
        private static Boolean IsAssigned { get; set; }
        private static String AssignedSchool { get; set; }

        public Student()
        {

        }
        public Student (String name)
        {
            Name = name;
            FirstRegion = null;
            SecondRegion = null;
            ThirdRegion = null;
            FourthRegion = null;
            FifthRegion = null;
            SixthRegion = null;
            FirstWildCard = null;
            SecondWildCard = null;
            ThirdWildCard = null;
            IsAssigned = false;
            AssignedSchool = null;
        }
        public Student(String name, String firstRegion, String secondRegion, String thirdRegion, String fourthRegion, String fifthRegion, String sixthRegion,
            String firstWildCard, String secondWildCard, String thirdWildCard)
        {
            Name = name;
            FirstRegion = firstRegion;
            SecondRegion = secondRegion;
            ThirdRegion = thirdRegion;
            FourthRegion = fourthRegion;
            FifthRegion = fifthRegion;
            SixthRegion = sixthRegion;
            FirstWildCard = firstWildCard;
            SecondWildCard = secondWildCard;
            ThirdWildCard = thirdRegion;
            IsAssigned = false;
            AssignedSchool = null;

        }
        

    }
}
