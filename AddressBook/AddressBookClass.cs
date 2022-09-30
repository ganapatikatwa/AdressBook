using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookClass
    {
        List<Contacts> add = new List<Contacts>();
        public void AddContact()
        {
            Contacts con = new Contacts();
            Console.WriteLine("Enter First Name");
            con.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            con.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            con.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            con.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            con.ZipCode = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            con.Phonenumber = long.Parse(Console.ReadLine());

            add.Add(con);
        }

        public void addPerson()
        {
            Contacts newcontact = new Contacts();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.FirstName = Console.ReadLine();

            foreach (Contacts contact in add)
            {
                if (contact.FirstName == newcontact.FirstName)
                {
                    Console.WriteLine("Person with this Name Already Exists");
                    return;
                }
            }
            Console.WriteLine("2)Enter Last Name");
            newcontact.LastName = Console.ReadLine();

            Console.WriteLine("3)Enter Address");
            newcontact.Address = Console.ReadLine();

            Console.WriteLine("4)Enter City Name");
            newcontact.City = Console.ReadLine();

            Console.WriteLine("5)Enter State");
            newcontact.State = Console.ReadLine();

            Console.WriteLine("6)Enter Zip Code");
            newcontact.ZipCode = long.Parse(Console.ReadLine());

            Console.WriteLine("7)Enter Phone Number");
            newcontact.Phonenumber = long.Parse(Console.ReadLine());

            Console.WriteLine("8)Enter Email-Id");
            newcontact.Email = Console.ReadLine();

            add.Add(newcontact);
        }


        public void Display()
        {
            foreach (Contacts data in add)
            {
                Console.WriteLine("Firstname:" + data.FirstName);
                Console.WriteLine("Lastname:" + data.LastName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("city:" + data.City);
                Console.WriteLine("state:" + data.State);
                Console.WriteLine("Zipcode:" + data.ZipCode);
                Console.WriteLine("PhoneNumber:" + data.Phonenumber);

            }
        }

        public void EditContact()
        {
            Console.WriteLine("To Edit Contact list Enter Contact First Name");
            string name = Console.ReadLine().ToLower();
            foreach (var data in add)
            {
                if (add.Contains(data))
                {
                    Console.WriteLine("To edit Contact Enter 1.LastName\n" +
                        "2.Address\n 3.City\n 4.State\n 5.Zipcode\n 6.Phone Number\n");
                    int options = Convert.ToInt32(Console.ReadLine());
                    switch (options)
                    {
                        case 1:
                            string lastname = Console.ReadLine();
                            data.LastName = lastname;
                            break;
                        case 2:
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 3:
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 4:
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 5:
                            long zipcode = long.Parse(Console.ReadLine());
                            data.ZipCode = zipcode;
                            break;
                        case 6:
                            long phonenumber = long.Parse(Console.ReadLine());
                            data.Phonenumber = phonenumber;
                            break;
                        default:
                            Console.WriteLine("Enter Valid Option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Name doesn't Matches");
                }
            }
           
        }

    }
}
