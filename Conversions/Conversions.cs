using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class Conversions
    {
        private string unit1;
        private string unit2;
        private double multiplier;

        public Conversions()
        {

        }
        public Conversions(string unit1, string unit2, double multiplier)
        {
            this.unit1 = unit1;
            this.unit2 = unit2;
            this.multiplier = multiplier;
        }

        public string Unit1
        {
            get
            {
                return unit1;
            }
            set
            {
                unit1 = value;
            }
        }
        public string Unit2
        {
            get
            {
                return unit2;
            }
            set
            {
                unit2 = value;
            }
        }
        public double Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
            }
        }

        public string GetDisplayText()
        {
            return unit1 + "|" + unit2 + "|" + multiplier;
        }
    }
}
