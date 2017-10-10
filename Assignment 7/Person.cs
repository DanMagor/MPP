namespace Assignment6
{
    public class Person
    {
        protected Name _name;

        public Person(Name name)
        {
            _name = name;
        }
        
        
        public Name Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
    }
}