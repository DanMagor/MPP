using Assignment6.Properties;

namespace Assignment6
{
    public class Assistant:Teacher
    {
        
        

        public Assistant(Name name, LectureCourse[] lectures):base(name,lectures)
        {
        }

        public Assistant(Name name):base(name)
        {
            
        }

    }
}