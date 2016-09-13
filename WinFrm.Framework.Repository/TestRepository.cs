using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFrm.Framework.Models;

namespace WinFrm.Framework.Repository
{
    public class TestRepository
    {
        private TestDbContext db = new TestDbContext();

        public IQueryable<User> GetAllUsers()
        {
            return db.Users;
        }
    }
}
