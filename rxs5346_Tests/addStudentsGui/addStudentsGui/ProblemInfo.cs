using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addStudentsGui
{
    class ProblemInfo
    {
        public static String workingDirectory = System.Environment.CurrentDirectory;
	    public static String inputPath = workingDirectory + "\\data\\input\\";
	    public static String outputPath = workingDirectory + "\\data\\output\\";
	    public static int numSchools;
	    public static int numStudents;
	    public static int totalNumPlacements;
	    public static String username = "userid=root;";
	    public static String password = "password=test!;";
        public static String databaseName = "database=placeStudentsEducation";
	    public static Boolean logInSuccessful = true;
    }
}
