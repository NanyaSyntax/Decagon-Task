using BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp
{
    internal class Transactions  : Logged
    {
      //  static string accountNumber = Logged.loggedAccount;
        static List<KeyValuePair<string, string[]>> statements = AccountStatement.statements;
        static Dictionary<string, Customer> customerList = ListOfCustomers.customerList;
       

        public static void Deposit(double amount)
        {
            foreach (var item in customerList)
            {
                if (item.Key == loggedAccount)
                {
                    Customer customer = item.Value;
                    double balance = customer.GetBalance();
                    double currentBalance = balance + amount;
                    customer.SetBalance(currentBalance);
                    string[] value = { customer.GetFullname(), amount.ToString(), loggedAccount, customer.GetAccountType(), currentBalance.ToString(), "CREDIT" };
                    statements.Add(new KeyValuePair<string, string[]>(loggedAccount, value));

                    break;
                }
            }  
        }
            
        public static void Withdraw(double amount)
        {
            foreach (var item in customerList)
            {
                if (item.Key == loggedAccount)
                {
                    Customer customer = item.Value;
                    double balance = customer.GetBalance();
                    double currentBalance = balance - amount;
                    customer.SetBalance(currentBalance);

                    string[] value = { customer.GetFullname(), amount.ToString(), loggedAccount, customer.GetAccountType(), currentBalance.ToString(), "DEBIT" };
                    statements.Add(new KeyValuePair<string, string[]>(loggedAccount, value));
                                       

                    break;
                }
            }
        }
        public void Transfer()
        {

        }
        public static double CheckBalance()
        {
            double bal = 0;
            foreach (var item in customerList)
            {
                if (item.Key == loggedAccount)
                {
                    Customer customer = item.Value;
                    bal = customer.GetBalance();

                    break;
                }
            }
            return bal;
        }

        public void GetStatementOfAccount()
        {

        }

        public static string GetAccountType()
        {
            string accountType = "";
            foreach (var item in customerList)
            {
                if(item.Key == loggedAccount)
                {
                    Customer customer = item.Value;
                    accountType = customer.GetAccountType();

                    break;
                }
            }
            return accountType;
        }
    }
}

