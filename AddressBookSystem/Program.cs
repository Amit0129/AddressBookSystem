namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true, check = true;
            Contacts contact = new Contacts();
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contact \n 4. Delete Contact \n 5. Add Multiple Contact \n 6. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        contact = new Contacts()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Mobile Number, Email.");
                        contact = new Contacts()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to  Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Contact is Edited Sucsessfully");
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the contact you want to delete :");
                        string detail = Console.ReadLine();
                        AddressBook delete = new AddressBook();
                        delete.DeleteContact(detail);
                        delete.Display();
                        break;
                    case 5:
                        while (check)
                        {
                            Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                            contact = new Contacts()
                            {
                                FirstName = Console.ReadLine(),
                                LastName = Console.ReadLine(),
                                Address = Console.ReadLine(),
                                City = Console.ReadLine(),
                                State = Console.ReadLine(),
                                Zip = Console.ReadLine(),
                                MobileNumber = Console.ReadLine(),
                                Email = Console.ReadLine(),
                            };
                            addressBook.AddContact(contact);
                            Console.WriteLine("Contact is Saved");
                            Console.WriteLine("Enter 1 to add more contact");
                            int addCheck = Convert.ToInt32(Console.ReadLine());
                            if (addCheck != 1)
                            {
                                check = false;
                            }
                        }
                        addressBook.Display();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }

        }

    }

}
    
