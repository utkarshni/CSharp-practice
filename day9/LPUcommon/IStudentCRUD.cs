using LPU_Entity;
using System.Collections.Generic;
namespace LPU_Common
{
    public interface IStudentCRUD
    {
        Student SearchStudentByID(int rollNo);
        List<Student> SearchStudentByName(string name);
        bool EnrollStudent(Student sObj);
        bool UpdatestudentDetails(int id, Student newObj);
        bool DropStudentDetails(int id);
    }
}
