using LoginAuthRef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthRef.Services
{
    public class AuthService
    {
        private readonly MyTestDbContext _dbContext;

        public AuthService(MyTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool UserLogin(string login, string password)
        {
            return _dbContext.Users.Any(u => u.Login == login && u.Password == password && u.RoleId == 2);
        }

        public bool AdminLogin(string login, string password)
        {
            return _dbContext.Users.Any(u => u.Login == login && u.Password == password && u.RoleId == 1);

        }
    }
}
