using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace FileIO
{
    public class MySettings
    {
        public int MyNumber { get; set; }
        public string MyString { get; set; }

        public void Save()
        {
            //two different ways of doing file out... xml file and textfile
            //this causes the dispose method (closest to destructor)
            using (Stream stream = File.Create(SettingsFile)) //overwrites if the file does exist
            // using(StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            //{
            //  writer.WriteLine(MyNumber);
            //writer.WriteLine(MyString);

            //}
            {
                XmlSerializer ser = new XmlSerializer(this.GetType()); //serializes public properties
                ser.Serialize(stream, this);
            }

        }
        public static MySettings Load()
        {
            //two different ways, xml read and file read 
           if(!File.Exists(SettingsFile)) 
           {
               return DefaultSettings;
           }
           using (Stream stream = File.OpenRead(SettingsFile))
         
          // using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
           //{

             //  try
               //{


                 //  String firstLine = reader.ReadLine();
                   //String secondLine = reader.ReadLine();


                  // reader.Close();
                   //stream.Close();
                   //return new MySettings
                  // {
                    //   MyNumber = int.Parse(firstLine),
                      // MyString = secondLine,
                   //};
               //}
              // catch (FormatException x)
              // {
                   //if settingsFile is corrupt
                //   stream.Close();
                   //File.Delete(SettingsFile);
                   //throw new ApplicationException("Oops", x);
                 //  return DefaultSettings;
               //}
           //}
           {//using statement from above
               try
               {

                   XmlSerializer ser = new XmlSerializer(typeof(MySettings));
                   return (MySettings)ser.Deserialize(stream);
               }
               catch (InvalidOperationException x)
               {
               // if settingsFile is corrupt
                   stream.Close();
                File.Delete(SettingsFile);
                //throw new ApplicationException("Oops", x);
                  return DefaultSettings;
                }
           }

           
        }

        private static String SettingsFolder
        {
            get
            {
                String folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); //bunch of different special folders, this is the appdata folder
                folder = Path.Combine(folder, "MyCompany");
                folder = Path.Combine(folder, "MyApp");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }

        }
        private static String SettingsFile
        {
            get
            {
                //return Path.Combine(SettingsFolder, "settings.txt");
                return Path.Combine(SettingsFolder, "Settings.xml");
            }
        }
        private static MySettings DefaultSettings
        {
            get
            {
                return new MySettings
                {
                    MyNumber=0,
                    MyString = "",
                };

            }
        }
    }
}
