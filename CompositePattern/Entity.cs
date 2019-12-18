using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Entity : ICompositble
    {
        public int Value { get; set; }

        public Entity(int value = 1)
        {
            Value = value;
        }

        public bool IsComposite()
        {
            return false;
        }

        public virtual int Operation()
        {
            return Value;
        }
    }
}
