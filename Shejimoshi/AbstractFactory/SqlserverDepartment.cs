using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shejimoshi.AbstractFactory
{
    class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("get department by id in sql");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("add record to department in sql");
        }
    }
}
