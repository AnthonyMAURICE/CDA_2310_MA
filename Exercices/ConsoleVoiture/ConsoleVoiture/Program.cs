using ClassVoiture;
namespace ConsoleVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture car = new Voiture();
            Console.WriteLine(car.ToString());
            car.StartCar();
            Console.WriteLine(car.ToString());
            car.Accelerate(150);
            Console.WriteLine(car.ToString());
            car.Decelerate(30);
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.Honk());
        }
    }
}