namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public string _firstName="";
        public string _lastName="";
        public double _salary;
        public string _gender="";
        public string FirstName
        {
            get { return _firstName;}
            set { _firstName=value;}
        }
        public string LastName
        {
            get { return _lastName;}
            set { _lastName=value;}
        }
        public double Salary
        {
            get { return _salary;}
            set { _salary=value;}
        }
        public string Gender
        {
            get { return _gender;}
            set { _gender=value;}
        }

        partial void PartialMethod();
        
    }
}