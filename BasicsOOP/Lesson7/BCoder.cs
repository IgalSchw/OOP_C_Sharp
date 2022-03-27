using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class BCoder : ICoder
    {
        private string _txt = string.Empty;

        public BCoder(string txt)
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

                if (c >= 'a' && c <= 'z')
                {
                    int first = 'a';
                    int last = 'z';

                    int i = (Int32)c;

                    int total = last - i;

                    total = total + first;

                    strBuilder.Append((char)total);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    int first = 'A';
                    int last = 'Z';

                    int i = (Int32)c;

                    int total = last - i;

                    total = total + first;

                    strBuilder.Append((char)total);
                }          
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

                if (c >= 'a' && c <= 'z')
                {
                    int first = 'a';
                    int last = 'z';

                    int i = (Int32)c;

                    int total = first - i;

                    total = total + last;

                    strBuilder.Append((char)total);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    int first = 'A';
                    int last = 'Z';

                    int i = (Int32)c;

                    int total = first - i;

                    total = total + last;

                    strBuilder.Append((char)total);
                }
                else
                    throw new EncodingDecodingException("Wrong input please enter string that contains only alpahabet characters");
            }

            _txt = strBuilder.ToString();

        }
    }
}
