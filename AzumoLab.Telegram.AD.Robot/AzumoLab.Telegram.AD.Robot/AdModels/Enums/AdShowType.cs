using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels.Enums
{
    public enum AdShowType
    {
        /// <summary>
        /// 默认的展示方式
        /// (每隔一段时间)
        /// </summary>
        None = 1,

        /// <summary>
        /// 固定消息数量
        /// 每N条消息，发送一条广告
        /// </summary>
        FixedMessageQuantity,

        /// <summary>
        /// 固定时间
        /// 每N分钟/小时，发送一条广告
        /// </summary>
        FixedTime,

        /// <summary>
        /// 固定时间
        /// 固定几点/几号发送广告
        /// </summary>
        FixedDateTime,

        /// <summary>
        /// 始终在底部显示
        /// </summary>
        FixedBottom,
    }
}
