using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzumoLab.Telegram.AD.Robot.DB
{
    internal class ADBotDBContext : DbContext
    {
        public ADBotDBContext(DbContextOptions<ADBotDBContext> options) : base(options) { }
    }
}
