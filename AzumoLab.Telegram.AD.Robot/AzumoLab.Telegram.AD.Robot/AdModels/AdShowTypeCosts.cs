using AzumoLab.Telegram.AD.Robot.AdModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    public class AdShowTypeCosts : ModelBase
    {
        /// <summary>
        /// 报价类型
        /// </summary>
        public AdShowType AdShowType { get; set; }

        /// <summary>
        /// 实际报价
        /// </summary>
        public decimal Price { get; set; }
    }
}
