using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdComponents.Costs
{
    internal interface ICosts
    {
        /// <summary>
        /// 计算价格
        /// </summary>
        /// <param name="costs"></param>
        /// <returns></returns>
        decimal Calculate();
    }
}
