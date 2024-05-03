using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCard
{
    public class CardFamily
    {

        private string name;
        private string desc;
        private string elem;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Desc { 
            get { return desc; }
            set { desc = value; }
        }
            
        public string Elem
        {
            get { return elem; }
            set { elem = value; }
        }

        public CardFamily(string _name, string _desc, string _elem)
        {
            this.name = _name;
            this.desc = _desc;
            this.elem = _elem;
        }
    }

    

}
