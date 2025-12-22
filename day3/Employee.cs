using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Employee
    {
        #region Fields
        public const int MyConst=1234;
        public readonly int myData;
             int empID;
             string empName;
             Address homeAddress;
        #endregion
        public int EmployeeID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        public Address HomeAddress
        {
            get
            {
                return homeAddress;
            }
            set
            {
                homeAddress = value;
            }
        }

        #region Constructors
            public Employee()
            {
            myData = 200;
            Console.WriteLine("Inside Default Constructor of Employee Class");
            myData = 400;
            }

            public Employee(int empID,string name)
            {
               this.empID = empID;
                empName = name;
            }
        #endregion
        ~Employee()
        {
            HomeAddress = null;
        }

        
    }
}
