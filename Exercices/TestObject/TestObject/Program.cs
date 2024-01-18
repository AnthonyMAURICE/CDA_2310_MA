namespace TestObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Animal("Humain");
            Animal cat = new Animal("Chat");
            Animal platypus = new Animal("Ornithorynque");

            human.eat();
            human.move();
            cat.eat();
            cat.move();
            platypus.eat();
            platypus.move();
        }
    }
}