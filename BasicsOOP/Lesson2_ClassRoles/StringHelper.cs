using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_ClassRoles
{
    public class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] strTemp = s.ToCharArray();
            string reverse = string.Empty;

            for (int i = strTemp.Length - 1; i >=0 ; i--)
            {
                reverse += strTemp[i];
            }

            return reverse;
        }
    }
}
