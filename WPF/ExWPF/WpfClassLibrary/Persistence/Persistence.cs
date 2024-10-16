using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Persistence
{
    public abstract class Persistence
    {
        private bool hasData;
        public Persistence() 
        {
           this.hasData = false;
        }

        public bool HasData { get => hasData; set => hasData = value; }
    }
}
