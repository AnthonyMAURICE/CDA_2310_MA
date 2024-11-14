using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Integer : Expression
    {
        private int value;
        public Integer(int _value) 
        {
            this.value = _value;
        }

        public int Value { get => value; set => this.value = value; }

        public override int EvaluateItself()
        {
            return this.value;
        }

        public override string Format()
        {
            return this.value.ToString();
        }
    }
}
