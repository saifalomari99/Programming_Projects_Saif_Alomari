using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate_regular_expressions
{
    internal class Person
    {
        //7 data
        public string lastName;
        public string firstName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public int phoneNumber;

        //---- method to set the info of the person 
        public void SetPerson(string Last, string First, string Address, string City, string State, int Zip , int Phone)
        {
            lastName = Last;
            firstName = First;
            address = Address;
            city = City;
            state = State;
            zipCode = Zip;
            phoneNumber = Phone;
        }



    }//end class
}
