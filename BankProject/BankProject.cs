using System;

namespace BankProject
{
    enum AccountState
    {
        New, Active, UnderAudit, Frozen, Closed
    }
    public class Account
    {
        private string name;
        private string address;
        private decimal balance;
        public Account(string ownerName, string ownerAddress, decimal accBalance)
        {
            name = ownerName;
            address = ownerAddress;
            balance = accBalance;
        }
    }

    class BankProject
    {
        static void Main(string[] args)
        {
            const int MAX_CUST = 100;
            Account[] bank = new Account[MAX_CUST];
            Account dansAccount = new Account("Daniel Battick", "Havendale", 230000);   
        }
    }
}
