using System;

namespace GoforBroke
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //Variables          
            double purchase;
            double firstCommission;           
            double sale;
            double secondCommission;
            double profitLoss;
            


            //Calculations and use cleaner language to simplify          
            purchase = 32.87 * 1000;
            firstCommission = purchase * .02;
            sale = 33.92 * 1000;
            secondCommission = sale * .02;
            profitLoss = sale - (purchase + firstCommission + secondCommission);
            

            //Display information
            Console.WriteLine("The amount of money Jennifer paid for the stock is  ${0:f2}", purchase);
            Console.WriteLine("The amount of commission Jennifer paid her broker when she bought the stock is  ${0:f2}", firstCommission);
            Console.WriteLine("The amount that Jennifer sold the stock for is  ${0:f2}", sale);
            Console.WriteLine("The amount of commission Jennifer paid her broker when she sold the stock is  ${0:f2}", secondCommission);
            Console.WriteLine("The profit/loss after Jennifer sold her stock and paid her broker is  ${0:f2}", profitLoss);
           











         
        }
    }
}
