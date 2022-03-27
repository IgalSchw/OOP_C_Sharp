using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    // declation of delegate function
    public delegate string Notification(object sender, EventArgs eventArgs);

    // example of interfcae
    interface IArrayWrapper
    {
        //void Foo();
        //void Bar();
    }

    public class ArrayWrapper<TItem> : IArrayWrapper
    {
        private List<string> _index = new List<string>();

        // appearence of delegetae declaration member
        public event Notification OnEnter;

        public virtual List<string> ToList()
        {
            return new List<string>(); 
        }

        public virtual TItem this[int index]
        {
            get
            {
                return this[index];
            }

            set
            {
                this[index] = value;
            }
        }
        
        public void Add(string text)
        {
            _index.Add(text);

            if (OnEnter is null)
            {
                return;
            }

            OnEnter(this, EventArgs.Empty);
        }

        // example using modifiers in abstract class

        //public abstract void Bar();

        //protected abstract string FormatName();

        //internal abstract int count();
    }

    public sealed class StringArrayWrapper : ArrayWrapper<string>
    {
        private readonly string[] _args;

        // override or new
        public override List<string> ToList()
        {            
            return new List<string>();
        }

        public StringArrayWrapper(string[] args)
        {
            _args = args;
        }

        public override string this[int index] 
        {
            get
            {
                return _args[index];            
            }
            set
            {
                _args[index] = value;            
            }
        }
    }
}
