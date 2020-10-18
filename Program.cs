using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{
    class Pogram
    {
        static void Main(string[] args)
        {
            Contacts c = new Contacts();
            //  Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();

            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter the choice");
            string process;
            do
            {
                Console.WriteLine("\n1: Enter contact details  \n2: Edit contact details \n3.Delete a contact  \n4.Display Contanct \n5.Get Contact using " +
                    "city name or state name \n6.Display City and State Lists \n7.Display City or state count");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    ///To enter contact details
                    case 1:
                        c.AddDetails();
                        break;
                    ///To update a contact based on First name 
                    case 2:
                        Console.WriteLine("enter the frstname to edit contact details ");
                        string name = Console.ReadLine();
                        c.EditDetails(name);
                        break;
                    ///To delete a contact
                    case 3:
                        Console.WriteLine("enter the frstname to delete contact details ");
                        string named = Console.ReadLine();
                        c.DeleteContact(named);
                        break;
                    ///To display a contact
                    case 4:
                        c.DisplayAddressBook();
                        break;
                    ///To get contact Details By city or state name
                    case 5:
                        c.GetPersonFromCityOrState();
                        break;
                    ///To Display city and state lists
                    case 6:
                        c.DisplayCityAndStateList();
                        break;
                    ///To display count based on city or state name
                    case 7:
                        c.CountForCityAndState();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                List<IAddress> list = new List<IAddress>();
                list.Add(c);
                Console.WriteLine("Do you want to continue  yes or No ");
                process = Console.ReadLine();
            }
            while (process == "yes");
        }
    }
}


