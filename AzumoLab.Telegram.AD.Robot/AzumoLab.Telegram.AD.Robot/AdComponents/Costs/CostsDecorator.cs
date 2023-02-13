using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdComponents.Costs
{
    internal abstract class CostsDecorator : ICosts
    {
        protected List<ICosts> Costs;

        public CostsDecorator(params ICosts[] Costs)
        {
            this.Costs = new List<ICosts>(Costs);
        }

        public decimal Calculate()
        {
            decimal result = decimal.Zero;
            foreach (ICosts cost in Costs)
            {
                result = decimal.Add(result, cost.Calculate());
            }
            return result;
        }
    }
}
