using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Drinks :CafeAssortment
    {
        private double _volume;


        public override string Info()
        {
            return base.Info();
        }

        public override string CostOfDrink(int percent)
        {
            return base.CostOfDrink(15);
        }

        public Drinks(double volume, string dishName, double price, string category, double weight)
           : base(dishName, price, category, weight)
        {
            _volume = volume;
        }
    }
}
