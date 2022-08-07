namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            CreateContact obj = new CreateContact();
            obj.createContactMethod();
            obj.printContact();

        }
    }
}
