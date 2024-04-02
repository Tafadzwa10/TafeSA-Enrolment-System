using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    public class Address
    {
        private const string DEF_NUMBER = "Default Number";
        private const string DEF_STREET = "Default Street";
        private const string DEF_SUBURB = "Default Suburb";
        private const string DEF_POSTCODE = "Default Code";
        private const string DEF_STATE = "Default State";

        private int streetNum;
        private string streetName;
        private string suburb;
        private int postcode;
        private string state;

        public int AddNumber
        {
            get 
            { return streetNum; }
            set 
            {streetNum = value; }
        }

        public string AddStreet
        {
            get 
            { return streetName; }
            set 
            {streetName = value; }
        }

        public string AddSuburb
        {
            get 
            { return suburb; }
            set 
            { suburb = value; }
        }

        public int AddPostcode
        {
            get 
            { return postcode; } 
            set 
            { postcode = value; }
        }

        public string AddState
        {
            get 
            { return state; }
            set 
            { state = value; }
        }

        public Address(): this(DEF_NUMBER, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        public Address(int streetnum, string streetname, string suburb, int postcode, string state)
        {
            AddNumber =streetnum;
            AddStreet = streetname;
            AddSuburb = suburb;
            AddPostcode = postcode;
            AddState = state;
        }

        public Address(string dEF_NUMBER, string dEF_STREET, string dEF_SUBURB, string dEF_POSTCODE, string dEF_STATE)
        {
        }

        public override string ToString()
        {
            return "streetNumber: " + AddNumber + "streetName: " + AddStreet + "suburb: " + AddSuburb + "postcode: " + AddPostcode + "state: " + AddState + "]";
        }
    }
}
