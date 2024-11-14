using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Addition : Binary
    {
        public Addition(Expression exp1, Expression exp2) : base(exp1, exp2)
        {
        }

        public override int EvaluateItself()
        {
            return this.expression1.EvaluateItself() + this.expression2.EvaluateItself();
        }

        public override string Format()
        {
            string result = "";
            for (int i = 0; i < this.expressionList.Count; i++)
            {
                result += this.expressionList[i].Format() + (i == this.expressionList.Count - 1 ? "" : " + ");
            }
            return result;
        }
    }
}
