namespace ClassPoint
{
    public class Point
    {
        private double x;
        private double y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return "Abscisse : " + this.X + ", Ordonnées : " + this.Y;
        }

        public void Deplacer(double _x, double _y)
        {
            this.X = _x;
            this.Y = _y;
        }

        public Point SymetrieAxeOrdonees()
        {
            return new Point(this.X, this.Y * -1);
        }

        public Point SymetrieAxeAbscisse()
        {
            return new Point(this.X * -1, this.Y);
        }

        public Point SymetrieOrigine()
        {
            return new Point(this.X * -1, this.Y * -1);
        }

        public void Permuter()
        {
            (this.X, this.Y) = (this.Y, this.X);
        }
    }
}