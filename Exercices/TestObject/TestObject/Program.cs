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

            Animal anim1 = new("chose");
            Animal anim2 = new("bestiole");
            Animal anim3 = new("animal");
            Animal anim4 = new("truc");

            List<Animal> animals = new List<Animal>();

            animals.Add(anim1);
            animals.Add(anim2);
            animals.Add(anim3);
            animals.Add(anim4);

            AddingAnims(animals);

            static void AddingAnims(List<Animal> _list)
            {

                foreach (Animal anim in _list)
                {
                    Console.WriteLine(anim.species);
                }

                _list = _list.OrderBy(order => order.species).ToList();
                foreach (Animal anim in _list)
                {
                    Console.WriteLine(anim.species);
                }
            }
        }
    }
}