using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PersonalBudgetTrackerAssignment
{
    public class BudgetManager
    {

        // List with transaction objects
        List<Transaction> MyTransactions = new List<Transaction>();

        // ID given to all transactions created through AddTransaction()
        public static int giveID = 1;


        //------------------------------------------------------------------------------------------

        
        public void AddTransaction() // Method that adds a transaction
        {
            Transaction newTransaction = new Transaction(); // creates new object

            // adding the amount and validating so it is a number
            decimal checkValid;
            // a while loop that loops until a correct amount is given
            while (true)
            {
                Console.Write("Please input amount: ");
                string inputAmount = Console.ReadLine();

                //trying to convert the string into a number and giving it to checkValid if it works
                if (decimal.TryParse(inputAmount, out checkValid)) 
                {
                    newTransaction.amount = checkValid; // giving the amount to our list
                    break;
                }
                else // if it couldn't be converted
                {
                    Console.WriteLine("This is not a valid amount, please input a number.");
                }
            }

            //adding other information to the newTransaction object
            Console.WriteLine("Please input date of transaction: ");
            newTransaction.date = Console.ReadLine();
            Console.WriteLine("Give it a category: ");
            newTransaction.category = Console.ReadLine();
            Console.WriteLine("Give a description for your transaction: ");
            newTransaction.description = Console.ReadLine();

            Console.WriteLine(); // Estetic space

            //Gives each transaction a personal ID
            newTransaction.ID = giveID;
            giveID++;

            // Shows user added transaction
            Console.WriteLine("New transaction added:");
            newTransaction.ShowInfo();

            MyTransactions.Add(newTransaction); // adds the object to list
        }

        //---------------------------------------------------------------------------------

        
        public void ShowAll() // Method that shows all the users transactions
        {
            foreach (Transaction transaction in MyTransactions)
            {
                transaction.ShowInfo();

                Console.WriteLine(); // Estetic Space
            }
        }

        //------------------------------------------------------------------------------------


        public void CalculateTotalBalance() // Method that calculates the users total balance
        {
            decimal totalSum = 0; // storing the total sum

            // goes through each transaction and store the amount in totalSum variable
            for (int i = 0; i < MyTransactions.Count; i++)
            {
                totalSum += MyTransactions[i].amount;
            }

            Console.Write("Your balance: "); // Writing out the sum

            //This if statement makes positive amounts green and negative amounts red
            if (totalSum >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalSum);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(totalSum);
                Console.ResetColor();
            }
        }

        //--------------------------------------------------------------------------------------


        // Method to remove a transaction
        public void DeleteTransaction()
        {
            //Asks which transaction the user wants to remove
            Console.WriteLine("Please write the ID for the transaction you want to delete: ");
            int removeThis = int.Parse(Console.ReadLine());

            //finds transaction in the list and stores it in a variable
            Transaction removeTransaction = MyTransactions.Find(t => t.ID == removeThis);

            // removes transaction if found
            if (removeTransaction != null)
            {
                MyTransactions.Remove(removeTransaction);
                Console.WriteLine($"The transaction has been removed.");
            }
            else
            {
                Console.WriteLine("The ID can't be found.");
            }
        }

        //-----------------------------------------------------------------------------------------------

        public void SortTransactions()
        {
            Console.WriteLine("Do you want to sort by category or amount? press \"c\" for category or \"a\" for amount:");
            char sortChoice = Console.ReadKey().KeyChar; // assigning variable with a char for decicion in if statement
            sortChoice = char.ToLower(sortChoice); // ensures char is lower case

            Console.WriteLine("\n"); // Estetic space


            // If the user chose "c", it sorts by category and writes out transactions
            if (sortChoice == 'a')
            {
                //Uses Sort and CompareTo to sort the objects
                MyTransactions.Sort((x, y) => x.amount.CompareTo(y.amount));

                Console.WriteLine("Here is the transactions sorted by amount:\n");
                
                //Writes out sorted transactions
                foreach (Transaction transaction in MyTransactions)
                {
                    transaction.ShowInfo();
                    Console.WriteLine(); //Estetic space
                }
            }
            // If the user chose "a", it sorts by amount and writes out transactions
            else if (sortChoice == 'c') 
            {
                // //Uses Sort and CompareTo to sort the objects, also doesn't care if it is upper or lower case
                MyTransactions.Sort((x, y) => string.Compare(x.category, y.category, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine("Here is the transactions sorted by category:\n");

                //Writes out sorted transactions
                foreach (Transaction transaction in MyTransactions)
                {
                    transaction.ShowInfo();
                    Console.WriteLine(); //Estetic space
                }
            }
            // If the user press incorrect key they get a message and gets sent back to beging of method
            else
            {
                Console.WriteLine("Wrong input. Please try again!");
                SortTransactions();
            }
        }

        //-----------------------------------------------------------------------------------------------------------

        // A method that shows statistics
        public void Statistics()
        {
            // Variables for storing the numbers of transactions and amounts
            int numberOfTransactions = 0;
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            // Using a foreach loop with an if statment to collect necessary data
            foreach (Transaction transaction in MyTransactions)
            {
                numberOfTransactions++; // gives number of transactions

                if (transaction.amount > 0) // decides if it is an income or expense
                    totalIncome += transaction.amount; // income
                else
                    totalExpenses += transaction.amount; // expense
            }

            // writing out all statistics
            Console.WriteLine("Statistics:\n");
            Console.WriteLine($"Number of transactions: {numberOfTransactions}");


            Console.Write($"Total income: ");
            //This if statement makes positive amounts green and negative amounts red
            if (totalIncome >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalIncome);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(totalIncome);
                Console.ResetColor();
            }


            Console.Write($"Total expenses: ");
            //This if statement makes positive amounts green and negative amounts red
            if (totalExpenses >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(totalExpenses);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(totalExpenses);
                Console.ResetColor();
            }
        }

        //-----------------------------------------------------------------------------------------------------------


        // Tillfällig test constructor
        public BudgetManager()
        {
            Transaction newTransaction1 = new Transaction();
            newTransaction1.amount = 1000;
            newTransaction1.date = "2025-10-15";
            newTransaction1.category = "art";
            newTransaction1.description = "Min lön";
            newTransaction1.ID = 389;
            MyTransactions.Add(newTransaction1);

            Transaction newTransaction2 = new Transaction();
            newTransaction2.amount = -200;
            newTransaction2.date = "2025-10-17";
            newTransaction2.category = "mat";
            newTransaction2.description = "Min mat";
            newTransaction1.ID = 6795;
            MyTransactions.Add(newTransaction2);

            Transaction newTransaction3 = new Transaction();
            newTransaction3.amount = 4000;
            newTransaction3.date = "2025-10-17";
            newTransaction3.category = "Lön";
            newTransaction3.description = "Min mat";
            newTransaction3.ID = 568;
            MyTransactions.Add(newTransaction3);
        }

    }
}
