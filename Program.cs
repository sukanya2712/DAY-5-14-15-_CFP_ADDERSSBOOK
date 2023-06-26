namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook addressBook = new Addressbook();
            Console.WriteLine("Welcome to AddressBook");

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1) Add contacts");
                Console.WriteLine("2) Display Contacts");
                Console.WriteLine("3) Delete Contacts");
                Console.WriteLine("4) Edit Contacts");
                Console.WriteLine("9) Exit");

                string OptionString = Console.ReadLine();
                int Choice;

                if (int.TryParse(OptionString, out Choice))
                {
                    try
                    {
                        switch (Choice)
                        {
                            case 1:
                                addressBook.addContact();
                                break;
                            case 2:
                                addressBook.Display();
                                break;
                            case 3:
                                addressBook.delete();
                                break;
                            case 4:
                                addressBook.Edit();
                                break;
                            case 9:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    catch (ContactAlreadyExistsException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    catch (EmptyContactListException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid integer choice.");
                }
            }

        }
    }
}