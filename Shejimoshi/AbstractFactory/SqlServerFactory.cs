using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.AbstractFactory
{
    class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlserverUser();
        }

        public IDepartment GetDepartment()
        {
            return new SqlserverDepartment();
        }
    }
}
