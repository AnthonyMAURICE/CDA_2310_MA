using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCratesProd
{
    public class ProdLine
    {
        private Dictionary<string, Production> prods;

        public Dictionary<string, Production> Prods { get => prods; set => prods = value; }

        public event EventHandler ProdAdded;

        public ProdLine() 
        {
            this.prods = new Dictionary<string, Production>();
        }

        public void CreateProd(string identifier)
        {
            int maxCrates;
            switch (identifier)
            {
                case "A":
                    maxCrates = 100;
                    break;
                case "B":
                    maxCrates = 25000;
                    break;
                case "C":
                    maxCrates = 120000;
                    break;
                default:
                    maxCrates = 10000;
                    break;
            }
            if (!prods.ContainsKey("prod" + identifier))
            {
                this.prods.Add("prod" + identifier, new Production(identifier, maxCrates));
                this.ProdAdded?.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
