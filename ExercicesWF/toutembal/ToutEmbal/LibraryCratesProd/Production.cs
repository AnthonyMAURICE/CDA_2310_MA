using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCratesProd
{
    public class Production
    {
        public enum State
        {
            Initialized,
            Started,
            Suspended,
            Stopped
        }
        
        System.Timers.Timer timer = new System.Timers.Timer(100);
        
        private string? type;
        private readonly int cratesGoal;
        private List<Crate> crates = new List<Crate>();
        private State currentState = State.Initialized;

        public event EventHandler itemAdded;

        public State CurrentState { get => currentState; set => currentState = value; }
        public List<Crate> Crates { get => crates; }
        public string? Type { get => type; set => type = value; }

        public int CratesGoal => cratesGoal;

        public Production(string _type, int _cratesGoal)
        {
            this.type = _type;
            this.cratesGoal = _cratesGoal;
            timer.Elapsed += OnTimedEvent;
        }

        public bool Start()
        {
            if (this.currentState != State.Initialized && this.currentState != State.Suspended) 
            {
                return false;
            }
            else
            {
                this.currentState = State.Started;
                timer.Start();
                return true;
            }  
        }

        public bool Suspend() 
        {
            if (this.currentState != State.Started)
            {
                return false;
            }
            else
            {
                this.currentState = State.Suspended;
                return true;
            }
        }

        public bool Continue() 
        {
            if (this.currentState != State.Suspended) 
            {
                return false;
            }
            else
            {
                this.currentState = State.Started;
                return true;
            }
        }

        private void Stop()
        {
            this.currentState = State.Stopped;
        }

        public bool IsGoalMet()
        {
            return this.crates.Count == this.cratesGoal;
        }

        public void AddCrate()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 10);
            bool failure = random == 6;
            Crate crate = new Crate(!failure);
            this.crates.Add(crate); 
        }

        public decimal GetTotalFailureRate()
        {
            decimal failures = this.crates.FindAll(x => x.IsValid == false).Count;
            return failures / this.crates.Count *100;
        }

        public decimal GetLastHourFailureRate()
        {
            decimal lastHourFailures = this.crates.FindAll(x => x.IsValid == false && x.DateOfProduction > DateTime.Now.AddHours(-1)).Count;
            return lastHourFailures / this.crates.Count *100;
        }

        public int GetValidCratesNumber()
        {
            return this.crates.FindAll(x => x.IsValid).Count;
        }

        public int GetProgress()
        {
            if(this.crates != null && this.crates.Count > 0)
            {
                double progress = (double)this.crates.Count / (double)this.cratesGoal;
                progress *= 100;
                int castedProgress;
                castedProgress = (int)Math.Round(progress);
                if (progress == 100) 
                {
                    this.Stop();
                }
                return castedProgress;
            }
            else
            {
                return 0;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (this.currentState == State.Started) 
            {
                this.AddCrate();
                itemAdded?.Invoke(this, null);
            }  
        }
    }
}