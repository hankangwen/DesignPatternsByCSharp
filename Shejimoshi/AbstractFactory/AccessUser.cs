using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.AbstractFactory
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("get user by id in access");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("add record in access");
        }
    }
}
