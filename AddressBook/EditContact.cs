using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class EditContact
    {
        List<Contacts> address = new List<Contacts>();
        Contacts contact = new Contacts();
        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
            address.Add(contact);
        }
        public void print()
        {
            Console.WriteLine("Contact Derails : " + "\n" + "First Name - " + contact.FirstName + "\n" + "Last Name - " + contact.LastName
                                + "\n" + "Address - " + contact.Address + "\n" + "City - " + contact.City + "\n" + "State - " + contact.State
                                + "\n" + "Zip - " + contact.Zip + "\n" + "Phone Number - " + contact.PhoneNumber + "\n" + "Email - " + contact.Email);
        }
        public void Editcontact (string name)
            {
            CreateContact();
            foreach (var contact in address)

            {
                if (((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name))))
                {
                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 6:
                            break;
                        case 7:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    print();

                }
            }
        }
    }
}
