using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels.Enums
{
    public enum AdBillingType
    {
        /// <summary>
        /// 默认的计费方式（按点击计费）
        /// </summary>
        None = 1,

        /// <summary>
        /// 按点击量计费
        /// </summary>
        Hits,

        /// <summary>
        /// 按展示量计费
        /// </summary>
        DisplayQuantity,

        /// <summary>
        /// 按固定时间计费（例如：一个月展示时间）
        /// </summary>
        FixedDisplayTime,
    }
}
