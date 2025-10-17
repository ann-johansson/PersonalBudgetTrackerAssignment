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
        public bool menuTrigger = true;

        // Choice variable for the switch statment in Program.cs
        public string choiceMenu;


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
