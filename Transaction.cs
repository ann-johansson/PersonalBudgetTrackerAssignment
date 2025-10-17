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
            Console.WriteLine($" Amount: {amount} \n Date: {date} \n Category: {category} \n Description: {description} \n ID: {ID}");
        }
    }
}
