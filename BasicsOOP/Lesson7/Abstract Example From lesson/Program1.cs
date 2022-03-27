using Lesson7.Abstract_Example;
using System;
using System.Collections.Generic;

namespace Lesson7
{
    class Program1
    {
        // Abstract class
        // All abstract method and properties must be overriden by inheritance class
        // Selad class mean that the class is final and nobody can inheritance from him
        // also you can declare sealed methods

        static void Main1(string[] args)
        {
            //Figure circle = new Circle();
            //Figure rectangle = new Rectangle();
            //Figure triangle = new Triangle();

            StringArrayWrapper arrayWrapper = new StringArrayWrapper(args);
            arrayWrapper.OnEnter += ArrayWrapper_OnEnter;

            arrayWrapper.ToList();

            /*
            B objB = new B();
            D objD = new D();

            // Error because a_abstarct and c_abstract is abstarct classes
            //A_Abstract objA = new A_Abstract();
            //C_Abstract objC = new C_Abstract();

            objB.a = 23;
            objB.b = 33;

            // No access
            //objB.d = 40;

            // has access to all of variables
            objD.a = 77;
            objD.b = 777;
            objD.c = 7777;
            objD.d = 77777;
            */



            Final final = new Final();
            int i = final.id;


            




        }

        private static string ArrayWrapper_OnEnter(object sender, EventArgs eventArgs)
        {
            return string.Empty;
        }
    }

    
    // Abstract figure
    delegate int MyDelegate(int a, int b); // example of delegate
    
    abstract class Figure
    {
        abstract public double Area();
        
        public abstract void Print();

        public abstract int IntProp
        {
            get;
            set;
        }

        public abstract int this[int index]
        {
            get;
            set;
        }

        public abstract event MyDelegate MyEvent;
    }


    // Area of Triangle
    class Triangle : Figure
    {
        public override int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int IntProp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
        public override event MyDelegate MyEvent;

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }


    // Area of Circle
    class Circle : Figure
    {
        public override int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int IntProp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override event MyDelegate MyEvent;

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }


    // Area of Rectangle
    class Rectangle : Figure
    {
        public override int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int IntProp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override event MyDelegate MyEvent;

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }


    // example of interface
    public abstract class Foo
    {
        public virtual void add()
        { 

        }
    }

    public interface IFoo
    {
        public int id { get; }
    }

    public interface IFinal : IFoo
    { 
    
    
    }
    public abstract class Bar
    {
        
    }

    public class Final : Foo, IFinal, IFoo
    {
        public int id 
        {
            get
            {
                return 10;
            }
        }
    }
}
