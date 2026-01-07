using LPU_Common;
using LPU_Entity;
using LPU_Exception;
using System.Reflection.Metadata.Ecma335;
namespace Lpu_DAL
{
    /// <summary>
    /// Student DAO class is used for CRUD operation
    /// </summary>
    public class studentDAO : IStudentCRUD
    {
        //public Student SearchStudentByID()
        static List<Student> studentList = null;
        public studentDAO()
        {
            studentList = new List<Student>()
            {
                new Student() { ID=101,Name="Alok",Course=CourseType.CSE,Address="Chandigarh"},
                new Student() { ID = 102, Name = "Aman", Course = CourseType.Electrical, Address = "jammu" },
                new Student() { ID = 101, Name = "Gaurav", Course = CourseType.Civil, Address = "Goa" }
            };
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }
        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                studentList.Add(sObj);
                flag = true;
            }return flag;
            
        }
        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if (rollNo != 0)
            {
                myStud = studentList.Find(s => s.ID == rollNo);
                if (myStud == null)
                {
                    throw new Exception("Student Record Not Found");
                }
            }
            else
            {
                throw new LpuException("Error genrated");
            }
            return myStud;
        }
        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            return data;
           
        }
        public bool UpdatestudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}