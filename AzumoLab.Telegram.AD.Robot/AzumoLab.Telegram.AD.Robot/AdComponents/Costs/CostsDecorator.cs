using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdComponents.Costs
{
    internal abstract class CostsDecorator : ICosts
    {
        protected ICosts Costs;

        public CostsDecorator(ICosts Costs)
        {
            this.Costs = Costs;
        }

        public decimal Calculate()
        {
            return Costs.Calculate();
        }
    }
}
