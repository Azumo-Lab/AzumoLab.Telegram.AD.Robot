using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.AdModels
{
    public class ModelBase
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        [Key]
        public string ID { get; set; }

        /// <summary>
        /// 项目创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 项目更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
