using Assignment6.Properties;

namespace Assignment6
{
    public class Instructor:Teacher
    {
       
        public Instructor(Name name, LectureCourse[] lectures) : base(name,lectures)
        {
           
        }

        public Instructor(Name name) : base(name)
        {
        }

        
    }
}