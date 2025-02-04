using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Colors
    {
        private int red ;
        private int green;
        private int blue;

        public Colors()
        {
            this.red = 255;
            this.green = 255;
            this.blue = 255;
        }

        public Colors (Colors colorToClone)
        {
            this.red = colorToClone.red;
            this.green = colorToClone.green;
            this.blue = colorToClone.blue;
        }

        public int Red { get => red; set => red = value; }
        public int Green { get => green; set => green = value; }
        public int Blue { get => blue; set => blue = value; }

    }
}
