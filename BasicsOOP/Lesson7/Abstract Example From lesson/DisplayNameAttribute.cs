using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Abstract_Example_From_lesson
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DisplayNameAttribute : Attribute
    {
        public DisplayNameAttribute(int a, string b, Type type)
        { 
            
        }
    }
}
