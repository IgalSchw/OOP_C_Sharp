using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson2_ClassRoles
{
    public class FileHelper
    {
        public static string FilePath = Environment.CurrentDirectory + @"\Workers Details.txt";
        public static string FilePathEmails = Environment.CurrentDirectory + @"\Workers Details Emails.txt";

        public static List<string> ReadFile(string path)
        {
            String line;
            List<string> strList = new List<string>();

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);

                //Read the first line of text
                line = sr.ReadLine();

                do
                {
                    strList.Add(line);
                    line = sr.ReadLine();
                }
                while (line != null);
                
                //close the file
                sr.Close();
                
                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return strList;
        }

        public static void CreateFile(string Destpath, List<string> rows)
        {
            string strMail = string.Empty;
            
            string[] strRows = rows.ToArray();
            //string[] arrStr = new string[2];

            // Delete file before create new
            if (File.Exists(Destpath))
            {
                File.Delete(Destpath);
            }

            foreach (var row in strRows)
            {
                // split solution
                /*
                arrStr = row.Split("&");
                arrStr[0] = arrStr[0].TrimStart().TrimEnd(); // ФИО
                arrStr[1] = arrStr[1].TrimStart().TrimEnd(); // адресом электронной почты
                */

                strMail = row; 
                SearchMail(ref strMail);

                using (StreamWriter sw = File.AppendText(Destpath))
                {
                    sw.WriteLine(strMail);
                }
            }
        }

        private static void SearchMail(ref string s)
        {
            int targetIndex = s.IndexOf('@');
            int lastIndex = s.Length; // last index of string row

            int StartCount = targetIndex;

            while (s[StartCount] != ' ')
            {
                StartCount--;
            }

            s = s.Substring(StartCount, lastIndex - StartCount);
        }
    }
}
