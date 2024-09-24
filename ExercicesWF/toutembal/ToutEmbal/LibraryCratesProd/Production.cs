using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCratesProd
{
    internal class Production
    {
        private int productionPerHour;
        private int productionGoal;
        private List<Crate>? crates;
        private decimal? flawRateHour;
        private decimal? flawRateTotal;
        private int totalNumberOfCrates;
        private CrateType? crateTypeProduction;

        public Production(CrateType _crateType)
        {
            this.crateTypeProduction = _crateType;
            this.calcStuff();
        }

        public int ProductionPerHour { get => productionPerHour; }
        public List<Crate>? Crates { get => crates; set => crates = value; }
        public decimal? FlawRateHour { get => flawRateHour; set => flawRateHour = value; }
        public decimal? FlawRateTotal { get => flawRateTotal; set => flawRateTotal = value; }
        public int TotalNumberOfCrates { get => totalNumberOfCrates; set => totalNumberOfCrates = value; }
        public int ProductionGoal { get => productionGoal;}

        private void calcStuff()
        {
            switch (this.crateTypeProduction) 
            {
                case CrateType.A:
                    this.productionPerHour = 1000;
                    this.productionGoal = 10000;
                    break;
                case CrateType.B:
                    this.productionPerHour = 5000;
                    this.productionGoal = 25000;
                    break;
                case CrateType.C:
                    this.productionPerHour = 10000;
                    this.productionGoal = 120000;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }


}
