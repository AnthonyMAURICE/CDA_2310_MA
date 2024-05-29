﻿namespace ClassVoiture
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
                {"Arr_Droite", wheel }
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


        public bool IncreaseSpeed(double _increasing)
        {
            if (this.engine.Started)
            {
                if(_increasing < 0)
                {
                    this.currentSpeed = this.currentSpeed + _increasing < 0 ? 0 : this.currentSpeed + _increasing;
                }
                else
                {
                    this.currentSpeed = this.currentSpeed + _increasing > this.maxSpeed ? this.maxSpeed : this.currentSpeed + _increasing;
                }
                    
                    this.CalcWheelTurn();
                    return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool DecreaseSpeed(double _decreasing)
        {
            return this.IncreaseSpeed(_decreasing < 0 ? _decreasing : -_decreasing);
        }

        public bool IncreaseAtMaxSpeed()
        {
            if (this.currentSpeed == this.maxSpeed)
            {
                return false;
            }
            else
            {
                this.IncreaseSpeed(this.maxSpeed - this.currentSpeed);
                return true;
            }
        }

        public bool DecreaseCompletely()
        {
            if(this.currentSpeed == 0)
            {
                return false;
            }
            else
            {
                this.DecreaseSpeed(this.currentSpeed);
                return true;
            }
        }

        private void CalcWheelTurn()
        {
            foreach (KeyValuePair<string, Roue> entry in this.wheels)
            {
                if(this.currentSpeed > 0)
                {
                    entry.Value.wheelState = Roue.WheelState.Avant;
                }
                else if(this.currentSpeed < 0)
                {
                    entry.Value.wheelState = Roue.WheelState.Arrière;
                }
                else
                {
                    entry.Value.wheelState = Roue.WheelState.Arrêt;
                }
            }
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