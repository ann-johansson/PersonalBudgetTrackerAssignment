using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTrackerAssignment
{
    public class Menu
    {
        BudgetManager manager = new BudgetManager();
        // Boolean for the ProgramMenu() methods while loop
        public bool menuTrigger = true;

        // Choice variable for the switch statment in Program.cs
        public string choiceMenu;

        public void AppMenu()
        {
            // This is the while loop that will continue to show the menu until a legit choice have been made
            while (menuTrigger == true)
            {

                // Menu alternatives text and input for user
                MenuAlternatives();

                // a swich statement that will give the user a response depending on what they have chosen
                switch (choiceMenu)
                {
                    case "1": // Add Transaction
                        manager.AddTransaction();
                        Continue(); // Asks user to press enter to continue and also clears screen
                        break;

                    case "2": // All Transactions
                        manager.ShowAll();
                        Continue();
                        break;

                    case "3": // Total Balance
                        manager.CalculateTotalBalance();
                        Continue();
                        break;

                    case "4": // Remove Transaction
                        manager.DeleteTransaction();
                        Continue();
                        break;

                    case "5": // Show Transactions in Order (sorting them)
                        manager.SortTransactions();
                        Continue();
                        break;

                    case "6": // Statistics
                        manager.Statistics();
                        Continue();
                        break;

                    case "7": // Quit
                        menuTrigger = false;
                        break;

                    default: // If anything else is writen
                        Console.WriteLine("Something is wrong with your choice." +
                            "\nType only the corresponding number, like for example \"1\" or \"2\" and then press enter.\n\n");
                        continue;

                }

            }
        }

        //-----------------------------------------------------------------------------------------------------------------

        public string MenuAlternatives()
        {
            // The introduction and alternatives text
            Console.WriteLine("Welcome to your Personal Budget Tracker!\n");
            Console.WriteLine("Please choose one of the following alternatives through writing the corresponding number and press enter:\n" +
                "1. Add Transaction\n" +
                "2. All Transactions\n" +
                "3. Total Balance\n" +
                "4. Remove Transaction\n" +
                "5. Show Transaction in Order\n" +
                "6. Statistics\n" +
                "7. Quit");

            // This is where the user write their choice
            Console.Write("\nPlease write your answere: ");
            choiceMenu = Console.ReadLine();

            Console.WriteLine(); // Estetic space inbetween text

            return choiceMenu; // Skickar val till switch val variabel
        }

        //--------------------------------------------------------------------------------------------------------------------

        // Method that makes a smoother transit back to menu and also clear previous text
        public void Continue()
        {

            //Question if user wanna quit or continue back to menu
            Console.WriteLine("\n Press enter to return to menu: ");
            Console.ReadLine();
            // Removes previous text for a cleaner program
            Console.Clear();
        }
    }
}
