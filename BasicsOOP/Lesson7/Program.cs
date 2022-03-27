using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(ACoder));
            ACoder aCoder = new ACoder("abcz");
            Console.WriteLine("Original text " + aCoder.Txt);
            aCoder.Encode();
            Console.WriteLine("Txt after encoding: " + aCoder.Txt);
            aCoder.Decode();
            Console.WriteLine("Txt after Decoding: " + aCoder.Txt);

            Console.WriteLine(typeof(BCoder));
            BCoder bCoder = new BCoder("abc");
            bCoder.Encode();
            Console.WriteLine("Txt after encoding: " + bCoder.Txt);
            bCoder.Decode();
            Console.WriteLine("Txt after Decoding: " + bCoder.Txt);
        }
    }
}
