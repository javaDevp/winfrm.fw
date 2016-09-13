using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFrm.Framework.Models;

namespace WinFrm.Framework.Repository
{
    public class TestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}
