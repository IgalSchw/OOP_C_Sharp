using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{    
    public interface ICoder
    {
        public string Txt { get; }
        public void Encode();
        public string Decode();
    }
}
