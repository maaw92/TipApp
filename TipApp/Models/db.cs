using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipApp.Models
{
    class Db:DbContext
    {
        
        
        public DbSet<Worker> Workers { get; set; }
    }
}
