using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    public class Person
    {
        const string DEF_NAME = "No name provided";
        const string DEF_EMAIL = "No email provided";
        const int DEF_PHONENUM = -1;

        private string name;
        private string email;
        private int phonenum;
        public Address Address { get; set; }

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public string Email
        {
            get
            { return email; }
            set
            { email = value; }
        }

        public int phoneNumber
        {
            get
            { return phonenum; }
            set
            { phonenum = value; }
        }

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONENUM)
        {

        }

        public Person(string name, string email, int telnum, Address address)
        {
            Name = name;
            Email = email;
            phoneNumber = telnum;
            Address = address;
        }

        public Person(string dEF_NAME, string dEF_EMAIL, int dEF_PHONENUM)
        {
        }

        public override string ToString()
        {
            return "name: " + Name + "email: " + Email + "telnum: " + phoneNumber + "]";
        }
    }
}
