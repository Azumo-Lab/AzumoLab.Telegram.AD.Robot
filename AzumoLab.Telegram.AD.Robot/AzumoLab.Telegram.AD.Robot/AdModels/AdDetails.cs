using AzumoLab.Telegram.AD.Robot.AdModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    /// <summary>
    /// 广告的详细信息
    /// </summary>
    public class AdDetails : ModelBase
    {
        /// <summary>
        /// 广告名称
        /// </summary>
        public string AdName { get; set; }

        /// <summary>
        /// 广告内容
        /// </summary>
        public string AdContent { get; set; }

        /// <summary>
        /// 广告的图片路径
        /// </summary>
        public List<string> AdImages { get; set; }

        /// <summary>
        /// 广告的备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 广告展示方式
        /// </summary>
        public AdShowType AdShowType { get; set; }

        /// <summary>
        /// 广告计费方式
        /// </summary>
        public AdBillingType AdBillingType { get; set; }
    }
}
