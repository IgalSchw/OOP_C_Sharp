using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public class EncodingDecodingException : Exception
    {
        private string ErrorDescripion = string.Empty;

        public EncodingDecodingException(string message) : base(message)
        {
            //Console.WriteLine(message);
        }
    }
}
