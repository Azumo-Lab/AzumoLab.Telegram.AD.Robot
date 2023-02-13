using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    /// <summary>
    /// 广告展示信息
    /// 例如展示次数，点击数量等
    /// </summary>
    internal class AdDisplayInfo : ModelBase
    {
        /// <summary>
        /// 广告信息
        /// </summary>
        public AdDetails AdDetails { get; set; }

        /// <summary>
        /// 展示次数
        /// </summary>
        public long DisplayCount { get; set; }

        /// <summary>
        /// 点击次数
        /// </summary>
        public long HitsCount { get; set; }

        /// <summary>
        /// 展示时长(秒)
        /// </summary>
        public long DisplayTimeCount { get; set; }

        /// <summary>
        /// 广告展示上架或下架
        /// </summary>
        public bool Display { get; set; }
    }
}
