using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Abstract_Example
{
    internal abstract class A_Abstract
    {
        public int a;
    }

    internal class B : A_Abstract
    {
        public int b;
    }

    internal abstract class C_Abstract : B
    {
        public int c;
    }

    internal class D : C_Abstract
    {
        public int d;
    }
}
