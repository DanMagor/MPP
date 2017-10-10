namespace Assignment6
{
    public class Name
    {
        private string _familyName;
        private string _givenName;

        public Name(string givenName, string familyName)
        {
            _givenName = givenName;
            _familyName = familyName;
        }

        public string GivenName
        {
            get { return _givenName; }
            set { _givenName = value; }
        }


        public string FamilyName
        {
            get { return _familyName; }
            set { _familyName = value; }
        }
    }
}