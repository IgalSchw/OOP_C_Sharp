using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class ACoder : ICoder
    {
        private string _txt = string.Empty;

        public ACoder(string txt)
        {
            _txt = txt;        
        }

        public string Txt => _txt;

        public string Decode()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (char item in _txt)
            {
                char c = item;

                if (c == 'a')
                    strBuilder.Append('Z');
                else if (c == 'A')
                    strBuilder.Append('z');
                else
                    strBuilder.Append(--c);           
            }

            _txt = strBuilder.ToString();

            return _txt;
        }

        public void Encode()
        {
            StringBuilder strBuilder = new StringBuilder();

            foreach (char item in _txt)
            {
                char c = item;

                if ((c > 'Z' && c < 'a') || c > 'z' || c < 'A')
                    throw new EncodingDecodingException("Wrong input please enter string that contains only alpahabet characters");
                else
                    if (c == 'Z')
                    strBuilder.Append('a');
                else if (c == 'z')
                    strBuilder.Append('A');
                else
                    strBuilder.Append(++c);
            }

            _txt = strBuilder.ToString();
        }
    }
}
