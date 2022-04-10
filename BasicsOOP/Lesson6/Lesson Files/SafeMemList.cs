using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lesson6
{
    /// <summary>
    ///  Example class of generic type
    /// </summary>

    // only refrernces type class (aslo we can write a specific class) or val type exa. struct
    public abstract class SafeMemList<TItem, TCollection> // type  T...
        where TItem : class, IItem  //, new()
        where TCollection : IReadOnlyCollection<TItem>
    {
        public SafeMemList(TCollection collection)
        {
            //IReadOnlyCollection<int> aa;
            IReadOnlyList<int> aa = new List<int>();
        }
        
        private TItem _val;
        
        public void Add(TItem val)
        {
            //TItem item = new TItem();
            _val = val;
        }
        public TItem Get()
        {
            return _val;
        }

        public abstract void Delete();
    }

    public abstract class SuperSafeMemList<TItem, TCollection> : SafeMemList<TItem, TCollection>
        where TItem : class, IItem  //, new()
        where TCollection : IReadOnlyCollection<TItem>
    {
        public SuperSafeMemList(TCollection collection) : base(collection)
        { 
            
        }

        // class and method sealed work much more faster
        // Final Logic and method other inheritance class not se it
        // final class avery inheritance class not inheritant this method
        public sealed override void Delete()
        {

        }
    }

    public class FinalSafeMemList<TItem, TCollection> : SuperSafeMemList<TItem, TCollection>
        where TItem : class, IItem  //, new()
        where TCollection : IReadOnlyCollection<TItem>
    {
        public FinalSafeMemList(TCollection collection) : base(collection)
        {

        }

    }
}
