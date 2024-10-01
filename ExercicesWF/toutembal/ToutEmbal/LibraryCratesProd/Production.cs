using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

        public readonly static char[] alphabet = Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();
        private string? type;
        private readonly int cratesGoal;
        private List<Crate> crates = new List<Crate>();
        private State currentState = State.Initialized;
        private Thread thread;

        public event EventHandler ItemAddedInList;

        public State CurrentState { get => currentState; set => currentState = value; }
        public List<Crate> Crates { get => crates; }
        public string? Type { get => type; set => type = value; }
        public int CratesGoal => cratesGoal;
        public Thread Thread { get => thread; }

        public Production(string _type, int _cratesGoal)
        {
            this.type = _type;
            this.cratesGoal = _cratesGoal;
            //timer.Elapsed += OnTimedEvent;
            this.thread = new Thread(new ThreadStart(this.LaunchProd)); 
        }

        public bool StartProd()
        {
            if (this.currentState != State.Initialized && this.currentState != State.Suspended) 
            {
                return false;
            }
            else
            {
                this.currentState = State.Started;

                // Pour avec le timer de l'IHM
                //this.LaunchProdIHM();

                // Timer de classe
                //timer.Start();

                // Thread
                this.thread.Start();
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
            return this.GetValidCratesNumber() == this.cratesGoal;
        }

        public void AddCrate()
        {
            if (this.IsGoalMet())
            {
                this.Stop();
            }
            else
            {
                Crate crate = new();
                crate.SetValidity();
                this.crates.Add(crate); 
            }
        }

        public decimal GetTotalFailureRate()
        {
            decimal failures = this.crates.FindAll(x => x.IsValid == false).Count;
            return failures / this.crates.Count *100;
        }

        public decimal GetLastHourFailureRate()
        {
            System.TimeSpan tSpan = new(0, 1, 0, 0);
            decimal lastHourFailures = this.crates.FindAll(x => x.IsValid == false && x.DateOfProduction > DateTime.Now.Subtract(tSpan)).Count;
            return lastHourFailures / this.crates.Count *100;
        }

        public int GetValidCratesNumber()
        {
            int validCrates = this.crates.FindAll(x => x.IsValid).Count;
            return this.crates.FindAll(x => x.IsValid).Count;
        }

        public int GetProgress()
        {
            if(this.crates != null && this.crates.Count > 0)
            {
                double progress = ((double)this.GetValidCratesNumber() / (double)this.cratesGoal) * 100d;
                return (int)Math.Round(progress);
            }
            else
            {
                return 0;
            }
        }

        // Avec timer de l'IHM

        //public void LaunchProdIHM()
        //{
        //    if (this.currentState == State.Started)
        //    {
        //        this.AddCrate();
        //        ItemAddedInList?.Invoke(this, new EventArgs());
        //    }
        //}

        //Avec le Timer de la classe
        //private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        //{
        //    if (this.currentState == State.Started)
        //    {
        //        this.AddCrate();
        //        ItemAddedInList?.Invoke(this, new EventArgs());
        //    }
        //}

        // Avec le Thread
        public void LaunchProd()
        {
            while (this.currentState != State.Stopped)
            {
                if (this.currentState == State.Started)
                {
                    this.AddCrate();
                    ItemAddedInList?.Invoke(this, new EventArgs());
                    Thread.Sleep(100);
                }
            }
        }
    }
}