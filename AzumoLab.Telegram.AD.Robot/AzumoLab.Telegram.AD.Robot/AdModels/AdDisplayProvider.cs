using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    /// <summary>
    /// 广告展示提供商
    /// 广告展示的群组等信息
    /// </summary>
    public class AdDisplayProvider
    {
        /// <summary>
         /// 广告商的ID
         /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 展示商的名字（Telegram用户名称）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 展示商的用户ID（Telegram用户ID）
        /// </summary>
        public long TelegramUserID { get; set; }

        /// <summary>
        /// 面对展示商的报价
        /// </summary>
        public List<AdShowTypeCosts> ShowTypeCosts { get; set; }
    }
}
