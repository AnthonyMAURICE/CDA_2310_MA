namespace ClassVoiture
{
    public class Voiture
    {
        private string brand;
        private string model;
        private int maxSpeed;
        private double currentSpeed;
        private Moteur engine;
        private Dictionary<string, Roue> wheels = new Dictionary<string, Roue>();

        public string Brand { get => brand; }
        public string Model { get => model; }
        public int MaxSpeed { get => maxSpeed; }
        public double CurrentSpeed { get => currentSpeed; }

        public Voiture()
        {
            this.brand = "Lada";
            this.model = "Jigouli";
            this.maxSpeed = 142;
            this.engine = new Moteur(4, 65);

        }

        public Voiture(string brand, string model, int maxSpeed, int cylinders, int power)
        {
            this.brand = brand;
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.engine = new Moteur(cylinders, power);

        }

        public bool StartCar()
        {
            bool hasStarted;
            if (!this.engine.Started)
            {
                this.engine.Start();
                hasStarted = true;
            }
            else
            {
                hasStarted = false;
            }
            return hasStarted;
        }

        public bool StopCar()
        {
            bool hasStoped;
            if (this.engine.Started && this.currentSpeed == 0)
            {
                this.engine.Stop();
                hasStoped = true;
            }
            else
            {
                hasStoped = false;
            }
            return hasStoped;
        }

        /*
        public double Accelerate(Roues à rajouter)
        {
 
        }

        public double Decelerate(Roues à rajouter)
        {
            
        }
        */

        public string Honk()
        {
            return "Honk ! Honk !";
        }

        public override string ToString()
        {
            return this.brand + " " + this.model + ", " + 
                (!this.engine.Started ? "éteinte " : "allumée ") + 
                (this.currentSpeed > 0 ? "roulant à " + this.currentSpeed + " km/h" : "à l'arrêt");
        }
    }
}