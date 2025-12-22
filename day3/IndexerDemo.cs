using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Project
    {
        int age;
        public int Age  //CLR Properties
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 60)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Error Raised: Invalid Age...");
                }
            }
        }


        //Auto Implicit Properties
        public int ProjectID { get; set; }
        public string ProjName { get; set; }

        public string[] devlopers = new string[5];
       
        
        //indexer code below
        public string this[int idx]
        {
            get
            {
                return devlopers[idx];
            }
            set
            {
                devlopers[idx] = value;
            }
        }

    }
    class IndexerDemo
    {
        public static void IndexerDemoMain()
        {
            Project hsbcProj= new Project();

            hsbcProj[0] = "Alok";
            hsbcProj[1] = "Riya";
            hsbcProj[2] = "Aliya";
            hsbcProj[3] = "Jiya";
            hsbcProj[4] = "Shlok";
            
        }
    }
}
