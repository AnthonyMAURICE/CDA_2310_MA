namespace ClassPoint
{
    public class Point
    {
        private double x;
        private double y;

        public Point()
        {
            this.x = 10;
            this.y = 10;
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
            return "Abscisse : " + X + ", Ordonnées : " + Y;
        }

        public void Deplacer(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        protected double Symetrique(double _coordonees)
        {
            return _coordonees *= -1;
        }

        public void SymetriqueOrdonees()
        {
            this.Y = Symetrique(Y);
        }

        public void SymetriqueAbscisse()
        {
            this.X = Symetrique(X);
        }

        public void SymetriqueOrigine()
        {
            this.X = Symetrique(X);
            this.Y = Symetrique(Y);
        }

        public void Permuter()
        {
            (X, Y) = (Y, X);
        }
    }
}