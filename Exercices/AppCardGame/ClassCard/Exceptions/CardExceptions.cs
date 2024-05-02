using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCard.Exceptions
{
    public class CardExceptions : Exception
    {
        public CardExceptions(string message) : base(message) { }
        public static void NotValidCardValue(int _power, int _defense)
        {
            if(_power <= 2 && _defense <= 2 && (_power + _defense != 12))
            {
                throw new CardExceptions("Valeurs de puissance et/ou défense non valides !");
            }
        }
    }
}
