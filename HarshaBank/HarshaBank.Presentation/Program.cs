using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("***************Harsha Bank**************************");
        Console.WriteLine("::Login Page::");

        string userName = null; string password = null;

        Console.Write("UserName: ");
        userName = Console.ReadLine();

        if(userName != "")
        {
            Console.Write("Password:");
            password = Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;

            do
            {
                Console.WriteLine("TO DO: Main Menu here");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statements");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

                Console.Write("Please select an option: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                // switch to check main menu choice

                switch (mainMenuChoice)
                {
                    case 1:CustomerMenu();
                        break;
                    case 2:AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                }
            }while(mainMenuChoice != 0);
             
        }
        else
        {
            Console.WriteLine("Invalid UserName or Password");
        }

            Console.WriteLine("Thank you! Visit again.");
            Console.ReadKey();
    }

    static void CustomerMenu()
    {
        int choice = -1;

        do
        {
            Console.WriteLine("\n:::Customer Menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Please select an option: ");
            choice = int.Parse(Console.ReadLine());
        } while (choice != 0);
    }

    static void AccountsMenu()
    {
        int choice = -1;

        do
        {
            Console.WriteLine("\n:::Accounts Menu:::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Account");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Please select an option: ");
            choice = int.Parse(Console.ReadLine());
        } while (choice != 0);
    }


}

   
