using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddContactUserInput
    {
        public List<Contact> ContactBook = new List<Contact>();
        public void addContact()
        {
            Contact input = new Contact();
            Console.Write("Enter the FirstName : ");
            input.FirstName = Console.ReadLine();
            Console.Write("Enter the LastName : ");
            input.LastName = Console.ReadLine();
            Console.Write("Enter the City: ");
            input.City= Console.ReadLine();
            Console.Write("Enter the State : ");
            input.State= Console.ReadLine();
            Console.Write("Enter the ZipCode : ");
            input.ZipCode= Console.ReadLine();
            Console.Write("Enter the PhoneNumber : ");
            input.PhoneNumber = Console.ReadLine();
            Console.Write("Enter the E_Mail : ");
            input.E_Mail=Console.ReadLine();
            ContactBook.Add(input);
        }

        public void printAddedContact()
        {
            Console.WriteLine("\nPrinting Added Contacts.\n");
            foreach (var info in ContactBook)
            {
                Console.WriteLine("FirstName  : " + info.FirstName);
                Console.WriteLine("LastName   : " + info.LastName);
                Console.WriteLine("City       : " + info.City);
                Console.WriteLine("State      : " + info.State);
                Console.WriteLine("ZipCode    : " + info.ZipCode);
                Console.WriteLine("PhoneNumber: " + info.PhoneNumber);
                Console.WriteLine("E_Mail     : " + info.E_Mail);
            }
        }
    }
}
