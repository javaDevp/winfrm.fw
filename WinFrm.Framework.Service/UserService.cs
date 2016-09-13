using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFrm.Framework.Models;
using WinFrm.Framework.Repository;

namespace WinFrm.Framework.Service
{
    public class UserService
    {
        TestRepository db = new TestRepository();

        public IQueryable<User> GetAllUsers()
        {
            return db.GetAllUsers();
        }
    }
}
