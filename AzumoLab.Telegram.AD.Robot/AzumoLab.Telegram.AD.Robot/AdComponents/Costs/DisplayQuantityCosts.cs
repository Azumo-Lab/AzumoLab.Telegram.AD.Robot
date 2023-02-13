using AzumoLab.Telegram.AD.Robot.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdComponents.Costs
{
    internal class DisplayQuantityCosts : ICosts
    {
        private readonly IServiceProvider ServiceProvider;
        private readonly ADBotDBContext ADBotDBContext;

        public DisplayQuantityCosts(IServiceProvider ServiceProvider, ADBotDBContext ADBotDBContext)
        {
            this.ServiceProvider = ServiceProvider;
            this.ADBotDBContext = ADBotDBContext;
        }

        public decimal Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
