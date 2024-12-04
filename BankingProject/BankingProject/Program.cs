using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(">>>>>>Axis bank<<<<<<");
            Console.WriteLine(">>loin page<<");
            string userName = null;
            string password = null;

            Console.WriteLine("username");
            userName = Console.ReadLine();
            if (userName != "")
            {
                Console.WriteLine("password");
                password = Console.ReadLine();
            }

            if (userName == "admin" && password == "admin")
            {
                int choice = -1;
                do
                {
                    
                    Console.WriteLine("\n>>>> main menu<<<<");
                    Console.WriteLine("1.customers");
                    Console.WriteLine("2.accounts");
                    Console.WriteLine("3.funds transfer");
                    Console.WriteLine("4.statement");
                    Console.WriteLine("5.balance");
                    Console.WriteLine("0.exit");
                    Console.WriteLine("enter coice");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("ramesh");
                            break;
                        case 2:
                            Console.WriteLine("savings account");
                            break;
                        case 3:
                            Console.WriteLine("transferd sucessfully");
                            break;
                        case 4:
                            Console.WriteLine("mini statement");
                            break;
                        case 5:
                            Console.WriteLine("balance remaning");
                            break;
                        case 0:
                            Console.WriteLine("exit");
                            break;
                    }



                } while (choice != 0);

            }
            else
            {
                Console.WriteLine("invalid user or password");
            }
            Console.WriteLine("<<<<<thank you>>>>");


        }
    }
}
