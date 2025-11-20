using System;
namespace crud_test_solid2.Models
{
    public abstract class Person //this is a base class for Employee 
    {
        protected int id;
        public string Lastname;
        public string Firstname;
        public string Middlename;
        public string Address;
        public DateTime Birthdate;
        public string Gender;


        public void setID(int id) {
            this.id = id;
        }

        public string GetFullName()
        {
            return $"{this.Lastname}, {this.Firstname}";
        }
    }
}
