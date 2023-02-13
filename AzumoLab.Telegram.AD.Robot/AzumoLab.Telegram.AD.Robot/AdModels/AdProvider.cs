using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    /// <summary>
    /// 广告提供商
    /// </summary>
    internal class AdProvider : ModelBase
    {
        /// <summary>
        /// 广告商的名字（Telegram用户名称）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 广告商的用户ID（Telegram用户ID）
        /// </summary>
        public long TelegramUserID { get; set; }
    }
}
