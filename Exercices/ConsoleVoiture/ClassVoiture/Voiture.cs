namespace ClassVoiture
{
    public class Voiture
    {
        private string brand;
        private string model;
        private int maxSpeed;
        private double currentSpeed;
        private Moteur engine;
        private Roue wheel = new Roue();
        private Dictionary<string, Roue> wheels;

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
            this.wheels = new Dictionary<string, Roue>(){
                {"Avt_Gauche", wheel},
                {"Avt_Droite", wheel},
                {"Arr_Gauche", wheel},
                {"Arr_Droite", wheel}
            };
        }

        public Voiture(string brand, string model, int maxSpeed, int cylinders, int power) : this()
        {
            this.brand = brand;
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.engine = new Moteur(cylinders, power);
        }

        public bool StartCar()
        {
            if (!this.engine.Started)
            {
                this.engine.Start();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StopCar()
        {
            if (this.engine.Started && this.currentSpeed == 0)
            {
                this.engine.Stop();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Accelerate(double _amount)
        {
            if (this.engine.IncreaseSpeed(this.currentSpeed, this.maxSpeed))
            {
                if(this.currentSpeed + _amount > this.maxSpeed)
                {
                    this.currentSpeed = this.maxSpeed;
                }
                else
                {
                    this.currentSpeed += _amount;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Decelerate(double _amount)
        {
            if (this.engine.DecreaseSpeed(this.currentSpeed))
            {
                if (this.currentSpeed - _amount < 0)
                {
                    this.currentSpeed = 0;
                }
                else
                {
                    this.currentSpeed -= _amount;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AccelerateAtMaxSpeed()
        {
            return this.Accelerate(this.maxSpeed);
        }

        public bool DecelerateCompletely()
        {
            return this.Decelerate(this.currentSpeed);
        }

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