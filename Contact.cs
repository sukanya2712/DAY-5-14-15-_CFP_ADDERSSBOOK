using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    public class Contact
    {
        public string name;
        public string email;
        public string phone;
        public string state;
        public string city;
        public string zipcode;

        public Contact(string name, string email, string phone, string state, string city, string zipcode)
        {
            if (!IsValidEmail(email))
                throw new ArgumentException(" Invalid email address");

            if (!IsValidPhone(phone))
                throw new ArgumentException(" Invalid phone number");

            if (!IsValidZipcode(zipcode))
                throw new ArgumentException(" Invalid ZIP code");

            this.name = name;
            this.email = email;
            this.phone = phone;
            this.state = state;
            this.city = city;
            this.zipcode = zipcode;
        }

        public override string ToString()
        {
            return $"Name: {name}\nEmail: {email}\nPhone: {phone}\nState: {state}\nCity: {city}\nZip: {zipcode}";
        }

        private static bool IsValidEmail(string email)
        {
            // Regular expression to validate email addresses
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private static bool IsValidPhone(string phone)
        {
            // Regular expression to validate phone numbers
            string phonePattern = "^\\d{10}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        private static bool IsValidZipcode(string zipcode)
        {
            // Regular expression to validate ZIP codes (5 digits)
            string zipcodePattern = @"^\d{5}$";
            return Regex.IsMatch(zipcode, zipcodePattern);
        }
    }
}
