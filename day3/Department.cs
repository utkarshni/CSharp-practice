using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Department
    {
        Employee obj = null;//HAS-A
        public Department()
        {

        }
        public Department(int id)
        {
            if(id>0)
            {
                obj = new Employee();
            }
        }
    }
}
