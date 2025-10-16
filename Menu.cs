using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTrackerAssignment
{
    public class Menu
    {

        // Boolean for the ProgramMenu() methods while loop
        bool menuTrigger = true;


        // Method where the menu to this program lies
        public void ProgramMenu()
        {
            // This is the while loop that will continue to show the menu until a legit choice have been made
            while (menuTrigger == true)
            {

                // The introduction and alternatives text
                Console.WriteLine("Welcome to your personal budget tracker!\n");
                Console.WriteLine(@"
Please choose one of the following alternatives through writing the corresponding number and press enter:
1. Add Transaction
2. All Transaction
3. Total Balance
4. Remove Transaction
5. Show Transaction in order
6. Quit");


                // This is where the user write their choice
                Console.Write("\nPlease write your answere: ");
                string choiseMenu = Console.ReadLine();


                // a swich statement that will give the user a response depending on what they have chosen
                switch (choiseMenu)
                {
                    case "1":
                        Console.WriteLine("hello choise 1");
                        menuTrigger = false;
                        break;
                    case "2":
                        Console.WriteLine("hello case 2");
                        menuTrigger = false;
                        break;
                    case "3":
                        Console.WriteLine("hello choise 3");
                        menuTrigger = false;
                        break;
                    case "4":
                        Console.WriteLine("hello case 4");
                        menuTrigger = false;
                        break;
                    case "5":
                        Console.WriteLine("hello choise 5");
                        menuTrigger = false;
                        break;
                    case "6":
                        Console.WriteLine("hello case 6");
                        menuTrigger = false;
                        break;
                    default:
                        Console.WriteLine("Something is wrong with your choice." +
                            "\nType only the corresponding number, like for example \"1\" or \"2\" and then press enter.");
                        continue;

                }

            }
        }
    }
}
