namespace ClassLibrary
{
    public abstract class Expression
    {
        public Expression()
        {

        }

        public abstract int EvaluateItself();
        public abstract string Format();
    }
}
