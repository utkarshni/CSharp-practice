namespace LPU_Entity
{


    //Enums ca be defined can be defined at namespcae level
    //Sudent can choose only these courses
    public enum CourseType
    {
        Mechanical = 10,//by default it is =0 so if we don't provide mechanical = 10 n just write mechinical it will be 0
        Electrical = 20,//this is =1
        Civil = 30,// this is =2
        CSE = 40,
        IT = 50
    }
    public class Student
    {
        //auto inplicit properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        //Property of type enum
        public CourseType Course { get; set; }

    }
}
