using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp;

namespace BankApp
{
    internal class Function :Logged
    {
        static Dictionary<string, Customer> customerList = ListOfCustomers.customerList;
        static List<KeyValuePair<string, string[]>> statements = AccountStatement.statements;
        public static void LoginCustomer()
        {
            Login.LoginUser();
        }
        public static void CreateCustomer()
        {
            CreateAccount.CreateCustomerAccount();
        }

        public static void DepositFunds(double amount)
        {
            if (amount > 0)
            {
                Transactions.Deposit(amount);
                Console.Clear();
                Logger.Log($"{amount} has been credited to your account. ");
            }
            else
            {
                Console.Clear();
                Logger.Log("Transaction failed. Invalid amount");
            }
        }

        public static void Withdraw(double amount)
        {
            if (amount > 0)
            {
                double bal = Transactions.CheckBalance();
                string accountType = Transactions.GetAccountType();
                if(accountType == "SAVINGS")
                {
                    bal -= 1000;
                }

                if(bal >= amount)
                {
                    Transactions.Withdraw(amount);
                    Console.Clear();
                    Logger.Log("Withdrawal successful");

                }
                else
                {
                    Logger.Log("Insufficient funds");
                } 
            }
            else
            {
                Console.Clear();
                Logger.Log("Invalid withdrawal amount");
                Welcome.Options();
            }
        }

        public static void Transfer(double amount)
        {
            if (amount < 0)
            {
                Logger.Log("Invalid transfer amount.");
            }
            else
            {
                Logger.Log("Input beneficiary account number");
                string beneficiaryAcc = Console.ReadLine();
                if (beneficiaryAcc == loggedAccount)
                {
                    Logger.Log("You cannot transfer to your account.");
                }
                else
                {
                    double balance = loggedCustomer.GetBalance();
                    if (loggedCustomer.GetAccountType() == "SAVINGS")
                    {
                        if ((balance - 1000) < amount)
                        {
                            Console.Clear();
                            Logger.Log("Insufficient funds");
                            return;
                        }
                    }



                    if (balance >= amount)
                    {
                        bool found = false;
                        foreach (var regUsers in customerList)
                        {
                            if (regUsers.Key == beneficiaryAcc)
                            {
                                double currentBalance = balance - amount;
                                loggedCustomer.SetBalance(currentBalance);

                                double beneBalance = regUsers.Value.GetBalance() + amount;
                                regUsers.Value.SetBalance(beneBalance);

                                string[] values = { regUsers.Value.GetFullname(), amount.ToString(), loggedAccount, regUsers.Value.GetAccountType(), currentBalance.ToString(), "CREDIT" };
                                statements.Add(new KeyValuePair<string, string[]>(loggedAccount, values));

                                string[] value = { loggedCustomer.GetFullname(),  amount.ToString(), beneficiaryAcc, loggedAccount, loggedCustomer.GetAccountType(), loggedCustomer.GetBalance().ToString(), "DEBIT" };
                                statements.Add(new KeyValuePair<string, string[]>(loggedAccount, values));

                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            Logger.Log("Transfer successful");
                        }
                        else
                        {
                            Logger.Log("Invalid recepient account");
                        }
                    }
                    else
                    {
                        Logger.Log("Insufficient balance");
                    }





                }
            }
        }
    }
}
