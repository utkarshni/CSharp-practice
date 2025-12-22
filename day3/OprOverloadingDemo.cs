using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demo
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int AdmFees { get; set; }
        public int TutionFees { get; set; }
        //Operator Overloading Code Below
        public static Student operator +(Student sObj1,Student sObj2)
        {
            Student tempObj = new Student();
            tempObj.AdmFees = sObj1.AdmFees + sObj2.AdmFees;
            tempObj.TutionFees = sObj1.TutionFees + sObj2.TutionFees;
            return tempObj;
        }
    }
    class OprOverloadingDemo
    {
       public static void OprOverloadingMain()
        {
            Student s1, s2, s3;
            //Init the Student Objects
            s1 = new Student();
            s1.RollNo = 101;
            s1.Name = "Alok";
            s1.AdmFees = 125000;
            s1.TutionFees = 3500;

            //object Init
            s2 = new Student() { RollNo = 102, Name = "Riya", AdmFees = 125000, TutionFees =7000};
            s3 = new Student() { RollNo = 103, Name = "Priya", AdmFees = 125000, TutionFees = 3500 };

            Student totStud = s1 + s2 + s3;

            Console.WriteLine(totStud.TutionFees);
            Console.WriteLine(totStud.AdmFees);
        }
    }
}
