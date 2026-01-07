using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LPU_Common
{
     interface IEmployee<T>:IRepo<T>
    {
        List<T> ShowAllFemaleEmployees();
        List<T> ShowAllMaleEmployees();
        List<T> ShowAllEmployeesWithAgeAbove40(); 

    }
}
