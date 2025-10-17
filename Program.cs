namespace PersonalBudgetTrackerAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Menu menu = new Menu();
           BudgetManager manager = new BudgetManager();

            // This is the while loop that will continue to show the menu until a legit choice have been made
            while (menu.menuTrigger == true)
            {

                // Menu alternatives text and input for user
                menu.MenuAlternatives();

                // a swich statement that will give the user a response depending on what they have chosen
                switch (menu.choiceMenu)
                {
                    case "1": // Add Transaction
                        manager.AddTransaction();
                        menu.ContinueOrQuit(); // Asks user if they want to go back to menu or quit app
                        break;

                    case "2": // All Transactions
                        manager.ShowAll();
                        menu.ContinueOrQuit();
                        break;

                    case "3": // Total Balance
                        manager.CalculateTotalBalance();
                        menu.ContinueOrQuit();
                        break;

                    case "4": // Remove Transaction
                        manager.DeleteTransaction();
                        menu.ContinueOrQuit();
                        break;

                    case "5": // Show Transactions in Order (sorting them)
                        manager.SortTransactions();
                        menu.ContinueOrQuit();
                        break;

                    case "6": // Quit
                        Console.WriteLine("hello case 6");
                        menu.ContinueOrQuit();
                        break;

                    default: // If anything else is writen
                        Console.WriteLine("Something is wrong with your choice." +
                            "\nType only the corresponding number, like for example \"1\" or \"2\" and then press enter.\n\n");
                        continue;

                }

            }
        }
    }
}
