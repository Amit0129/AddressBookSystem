namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Mobile Number: ");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter EMail: ");
            string eMail = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            int zip = Convert.ToInt32(Console.ReadLine()); 

            Contacts contacts = new Contacts()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                MobileNumber = mobileNumber,
                Email = eMail
            };
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(contacts);
            addressBook.Display();
            
        }
    }
}