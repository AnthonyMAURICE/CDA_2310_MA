﻿using ClassVoiture;
namespace ConsoleVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture car = new Voiture();
            Voiture car2 = new Voiture("Nissan", "GT-R", 315, 6, 550);
            car2.StartCar();
            car2.Accelerate(115);
            car2.DecelerateCompletely();
            car2.Decelerate(15);
            car2.AccelerateAtMaxSpeed();
            Console.WriteLine(car2.ToString());
            car2.DecelerateCompletely();
            car2.StopCar();
            Console.WriteLine(car2.Honk());
        }
    }
}