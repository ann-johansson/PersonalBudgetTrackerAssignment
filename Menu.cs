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

        //-----------------------------------------------------------------------------------------------------------------

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
                        ContinueOrQuit(); // Asks user if they want to go back to menu or quit app
                        break;

                    case "2": // All Transactions
                        manager.ShowAll();
                        ContinueOrQuit();
                        break;

                    case "3": // Total Balance
                        manager.CalculateTotalBalance();
                        ContinueOrQuit();
                        break;

                    case "4": // Remove Transaction
                        manager.DeleteTransaction();
                        ContinueOrQuit();
                        break;

                    case "5": // Show Transactions in Order (sorting them)
                        manager.SortTransactions();
                        ContinueOrQuit();
                        break;

                    case "6": // Quit
                        Console.WriteLine("hello case 6");
                        ContinueOrQuit();
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
                "6. Quit");

            // This is where the user write their choice
            Console.Write("\nPlease write your answere: ");
            choiceMenu = Console.ReadLine();

            Console.WriteLine(); // Estetic space inbetween text

            return choiceMenu; // Skickar val till switch val variabel
        }

        //--------------------------------------------------------------------------------------------------------------------

        // Method that asks user if they wants to continue back to the menu or quit program
        public void ContinueOrQuit()
        {

            //Question if user wanna quit or continue back to menu
            Console.WriteLine("Do you want to return to menu? Press \"y\" for yes and \"n\" for no:");
            string answere = Console.ReadLine();

            answere = answere.Trim().ToLower(); // Removes space and ensures lower case, makes it more fool proof

            // If statement for decision
            if (answere == "y")
            {
                menuTrigger = true;
                Console.WriteLine(); // Estetic space inbetween text
            }
            else if (answere == "n")
            {
                Console.WriteLine("Goodbye! Press any key to close the application.");
                menuTrigger = false;
                Console.ReadKey(); // Stops the app from closing to fast
            }
            else
            {
                Console.WriteLine("Wrong input, please try again.");
                ContinueOrQuit(); // Repeats the if statement
            }
        }
    }
}
