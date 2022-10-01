namespace AddressBook
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            bool check = true;

            while (check)
            {
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details to add Contact in List\n" +
                    "2)Add new Contact, Display and Stores contact in the list\n" +
                    "3)Edit Details of Contact\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        AddressBookClass addobj = new AddressBookClass();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj.AddContact();
                        break;

                    case 2:

                        AddressBookClass addobj1 = new AddressBookClass();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        addobj1.AddContact();
                        Console.WriteLine("::::::::::::::::::::::::::");
                        Console.WriteLine("Entered Details of Person given as :");
                        addobj1.Display();
                        addobj1.addPerson();
                        break;

                    case 3:

                        AddressBookClass addobj2 = new AddressBookClass();
                        Console.WriteLine("::::::::::::::::::::::::::");

                        bool check1 = true;

                        while (check1)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj2.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 2:
                                    addobj2.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 3:
                                    addobj2.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;
                    case 4:

                        AddressBookClass addobj3 = new AddressBookClass();
                        Console.WriteLine("::::::::::::::::::::::::::");

                        bool check2 = true;

                        while (check2)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Remove Contact\n" + "4) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj3.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 2:
                                    addobj3.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 3:
                                    addobj3.DeleteContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 4:
                                    addobj3.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;


                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;
                    case 5:

                        AddressBookClass addobj4 = new AddressBookClass();
                        Console.WriteLine("::::::::::::::::::::::::::");

                        bool check3 = true;

                        while (check3)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Remove Contact\n" + "4) Adding Multiple Contacts\n" +
                               "5) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    addobj4.addPerson();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 2:
                                    addobj4.EditContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 3:
                                    addobj4.DeleteContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 4:
                                    addobj4.AddMultipleContact();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;

                                case 5:
                                    addobj4.Display();
                                    Console.WriteLine(":::::::::::::::::::::::::::;");
                                    break;


                                default:

                                    check = !check;
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                Console.WriteLine("Try Again ");
                break;
            }
        }
    
    }
}