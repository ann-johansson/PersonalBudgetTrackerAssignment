using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTrackerAssignment
{
    public class Transaction
    {
        public string description;
        public decimal amount;
        public string date;
        public string category;
        public int ID;


        public void ShowInfo()
        {
            Console.Write($" Amount: ");

            //This if statement makes positive amounts green and negative amounts red
            if (amount >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(amount);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(amount);
                Console.ResetColor();
            }

            Console.WriteLine($" Date: {date} \n Category: {category} \n Description: {description} \n ID: {ID}");
        }
    }
}
