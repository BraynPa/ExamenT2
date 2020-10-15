using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using N00029793T2.Models;

namespace N00029793T2.Repositories
{
    public interface IUserRepository
    {
        public User FindUser(string username, string password);
    }

    public class UserRepository : IUserRepository
    {
        private readonly N00029793T2Context context;

        public UserRepository(N00029793T2Context context)
        {
            this.context = context;
        }

        public User FindUser(string username, string password)
        {
            return context.Users
               .Where(o => o.Username == username && o.PassWord == password)
               .FirstOrDefault();
        }
    }
}
