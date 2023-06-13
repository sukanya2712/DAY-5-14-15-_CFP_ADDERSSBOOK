namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook addressBook = new Addressbook();
            Console.WriteLine("welcome to AddressBook : ");
            while (true)
            {
                Console.WriteLine("Choose your operation: ");
                Console.WriteLine("1) Add contact");
                Console.WriteLine("2) Display Contact");
                Console.WriteLine("9) Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            addressBook.addContact();
                            break;
                        }
                    case 2:
                        {
                            addressBook.Display();
                            break;
                        }
                    case 9:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }

        }
    }
}