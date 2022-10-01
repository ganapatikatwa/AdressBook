using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UniqueNameDict
    {
        //Dictionary is used to store

        public Dictionary<string, AddressBookClass> addBookobj = new Dictionary<string, AddressBookClass>();
        public void NewAddressBook()
        {
            AddressBookClass newAddBook = new AddressBookClass();
            newAddBook.AddMultipleContact();

            Console.WriteLine("Please enter Name of the AddressBook:");
            string addName = Convert.ToString(Console.ReadLine());
            addBookobj.Add(addName.ToLower(), newAddBook);

        }
    }
}
