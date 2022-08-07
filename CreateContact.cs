using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Ability to create a contact

    public class CreateContact
    {

        public List<Contact> ContactBook = new List<Contact>();
        public void createContactMethod()
        {
            Contact obj1 = new Contact();
            obj1.FirstName = "Pruthvi";
            obj1.LastName = "L";
            obj1.City = "Shimoga";
            obj1.State = "karnataka";
            obj1.ZipCode = "577201";
            obj1.PhoneNumber = "9988334423";
            obj1.E_Mail = "pruthvi123@gmail.com";
            ContactBook.Add(obj1);
            Console.WriteLine("\nADDRESS BOOK Is Created ");
        }

        //Printing ContactBook
        public void printContact()
        {
            Console.WriteLine("\nPrinting Contact information. \n");
            foreach (var obj2 in ContactBook)
            {
                Console.WriteLine("FirstName is: "+ obj2.FirstName);
                Console.WriteLine("LastName is : "+ obj2.LastName);
                Console.WriteLine("City is     : "+ obj2.City);
                Console.WriteLine("State is    : "+ obj2.State);
                Console.WriteLine("ZipCode is  : "+ obj2.ZipCode);
                Console.WriteLine("PhoneNo is  : "+ obj2.PhoneNumber);
                Console.WriteLine("E_Mail is   : "+ obj2.E_Mail);

            }
        }
    }
}
