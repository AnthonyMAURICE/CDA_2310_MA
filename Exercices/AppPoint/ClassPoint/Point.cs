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
    }
}