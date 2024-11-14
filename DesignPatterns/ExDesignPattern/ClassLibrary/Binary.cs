using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Binary : Expression
    {
        protected Expression expression1;
        protected Expression expression2;
        protected List<Expression> expressionList = [];
        public Binary(Expression exp1, Expression exp2) 
        {
            this.expressionList.Add(this.expression1 = exp1);
            this.expressionList.Add(this.expression2 = exp2);
        }
    }
}
