using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class EmptyContactListException : Exception
    {
        public EmptyContactListException(string message) : base(message) { }
        

    }
}
