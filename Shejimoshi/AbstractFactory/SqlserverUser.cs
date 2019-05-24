using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.AbstractFactory
{
    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("zai sql user add record");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("find user by id");
            return null;
        }
    }
}
