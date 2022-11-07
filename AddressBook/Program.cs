using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.AddressBookMain" + "\n" + "2.EXIT");
                Console.WriteLine("Enter the option from the above");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookMain main = new AddressBookMain();
                        main.CreateContact();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
