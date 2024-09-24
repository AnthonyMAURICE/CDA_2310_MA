using System;
using System.Collections.Generic;
using System.Linq;
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

        private string? type;
        private readonly int cratesGoal;
        private List<Crate> crates;
        private State currentState = State.Initialized;

        public State CurrentState { get => currentState; set => currentState = value; }

        public Production(string _type, int _cratesGoal)
        {
            this.type = _type;
            this.cratesGoal = _cratesGoal;
        }

        public bool Start()
        {
            if (this.currentState != State.Initialized || this.currentState != State.Suspended) 
            {
                return false;
            }
            else
            {
                this.currentState = State.Started;
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
            Crate crate = new Crate(failure);
            crates.Add(crate);
        }

        public decimal GetTotalFailureRate()
        {
            decimal failures = this.crates.FindAll(x => x.IsValid == false).Count;
            return failures / this.crates.Count;
        }

        public decimal GetLastHourFailureRate()
        {
            decimal lastHourFailures = this.crates.FindAll(x => x.IsValid == false && x.DateOfProduction > DateTime.Now.AddHours(-1)).Count;
            return lastHourFailures / this.crates.Count;
        }

        public int GetValidCratesNumber()
        {
            return this.crates.FindAll(x => x.IsValid).Count;
        }
    }
}
