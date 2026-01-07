using System;
using LPU_Common;
using System.Collections.Generic;
using LPU_Entity;
using Lpu_DAL;
using LPU_Exception;

namespace LPU_BL
{
    public class StudentBL : IStudentCRUD
    {
        studentDAO sDao = null;
        public StudentBL()
        {
            sDao = new studentDAO(); // all are instat method so we need it
        }

        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            return sDao.EnrollStudent(sObj);
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 = null;
            try { s1 = sDao.SearchStudentByID(rollNo); }
            catch(Exception e)
            {
                throw e;// exception is coming from dal layer n bl is catching
            }
            return s1;
            
        }

        public List<Student> SearchStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdatestudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
                                    