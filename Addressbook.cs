using AddressBook;
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
            string? name = Console.ReadLine();
            Console.WriteLine("Enter email");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter phone");
            string? phone = Console.ReadLine();
            Console.WriteLine("Enter state");
            string? state = Console.ReadLine();
            Console.WriteLine("Enter city");
            string? city = Console.ReadLine();
            Console.WriteLine("Enter zip");
            string? zip = Console.ReadLine();
            Contact contact = new Contact(name, email, phone, state, city, zip);
            bool isDuplicate = false;
            foreach (Contact existingContact in contactList)
            {
                if (existingContact.phone == phone)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                contactList.Add(contact);
                Console.WriteLine("Contact added..");
            }
            else
            {
                Console.WriteLine("Duplicate Phone Number....");
            }
        }

        
        public void Display()
        {
            foreach (Contact contacts in contactList)
            {
                Console.WriteLine(contacts);
            }
        }

        public void delete()
        {
            Console.WriteLine("Enter name of the contact to be deleted : ");
            string? inputString = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                Contact contact = contactList[i];
                if (inputString == contact.name)
                {
                    contactList.Remove(contact);
                    Console.WriteLine("Contact deleted suceefully");
                    return;
                }
            }
            Console.WriteLine("contact not found in addressbook");
        }

        public void Edit()
        {
            Console.WriteLine("Enter name of the contact: ");
            string? input = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                Contact contact = contactList[i];
                if (input == contact.name)
                {
                    Console.WriteLine("Enter name");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    string? email = Console.ReadLine();
                    Console.WriteLine("Enter phone");
                    string? phone = Console.ReadLine();
                    Console.WriteLine("Enter state");
                    string? state = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    string? city = Console.ReadLine();
                    Console.WriteLine("Enter zip");
                    string? zip = Console.ReadLine();
                    contact.name = name;
                    contact.email = email;
                    contact.phone = phone;
                    contact.state = state;
                    contact.city = city;
                    contact.zipcode = zip;
                    Console.WriteLine("Contact Updated sucessfully");
                    return;
                }
            }



        }
    }
}