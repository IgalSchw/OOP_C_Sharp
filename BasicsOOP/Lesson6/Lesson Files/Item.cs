using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class Item : IItem
    {
        public static int NewObjectId = -1;
        
        private int _Id { get; set; }
        private string _name { get; set; } 


        protected Item()
        {
            Id = NewObjectId;
        }

        public int Id
        {
            get => _Id;
            set => _Id = value;
        }

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
    }
}
