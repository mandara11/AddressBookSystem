namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            //CreateContact obj = new CreateContact(); //UC1
            //obj.createContactMethod();
            //obj.printContact();

            //AddContactUserInput obj2 = new AddContactUserInput();//UC2
            //obj2.addContact();
            //obj2.printAddedContact();

            //EditContact obj3 = new EditContact(); //UC3
            //obj3.editContacts();

            //DeleteContact obj4 = new DeleteContact();
            //obj4.deleteContact();

            //MultiplePersonAddressBook obj5 = new MultiplePersonAddressBook();
            //obj5.addMultipleContact();
            //obj5.printContact();
            //obj5.editMultiContact();
            //obj5.deleteMultiContact();
            //Console.WriteLine("After removing Contacts");
            //obj5.printContact();

            MultipleAddressBookDictionary obj6 = new MultipleAddressBookDictionary();
            obj6.dictionaryContacts();

        }
    }
}
