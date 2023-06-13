using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        string name;
        string email;
        string phone;
        string state;
        string city;
        string zipcode;

        public Contact(string name, string email, string phone, string state, string city, string zipcode)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.state = state;
            this.city = city;
            this.zipcode = zipcode;
        }
    }
}
