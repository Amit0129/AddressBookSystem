using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contacts> addressList = new List<Contacts>();
        public void AddContact(Contacts contacts)
        {
            addressList.Add(contacts);
        }
        public void Display()
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine("Name : " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.MobileNumber);
                Console.WriteLine("Email : " + contact.Email);
                Console.WriteLine("Contact is Added Successfully");
            }
        }
    }
}
