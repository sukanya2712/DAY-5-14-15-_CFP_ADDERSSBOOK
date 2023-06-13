using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        List<Contact> contactList = new List<Contact>();
        public void addContact()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter phone");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();
            Contact contact = new Contact(name, email, phone, state, city, zip);
            contactList.Add(contact);
            Console.WriteLine("Contact added..");
        }

        internal void Display()
        {
            Console.WriteLine("not yet implemented");
        }

    }
}
