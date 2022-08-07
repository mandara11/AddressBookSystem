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

            EditContact obj3 = new EditContact(); //UC3
            obj3.editContacts();

        }
    }
}
