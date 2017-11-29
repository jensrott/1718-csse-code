using System;

namespace opdrachtweek9.account
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy accountProxy = new AccountProxy();
            Console.WriteLine(accountProxy.activateAccount("jens ", "passwoord"));

            // Wat ik wil is dat ik gewoon het passwoord van hierboven kan oproepen.
            // Ik denk dat we dit met getters en setters kunnen doen
            Console.WriteLine(accountProxy.getUserPassword(" ander_passwoord"));


            // Hier hetzelfde ik wil de account info van activateAccount hier in krijgen.
            Console.WriteLine(accountProxy.getAccountInfo("jens", "passwoord"));

            
        }
    }

    public interface IAccount 
    {
        String activateAccount(string name, string password);  

        String getUserPassword(string Password);

        String getAccountInfo(string name, string password);
    }

    class Account : IAccount 
    {

        private string password;
        public String activateAccount(string name , string password) 
        {
            return name + password;
        }

        public String getUserPassword(string Password) 
        {
            return Password;
        }

        public String getAccountInfo(string name, string password) 
        {
            return name + password;
        }
    }

    class AccountProxy : IAccount
    {
        private Account account = new Account();
        public String activateAccount(string name , string password) 
        {
            return account.activateAccount(name, password);
        }

        public String getUserPassword(string Password) 
        {
            return account.getUserPassword(Password);
        }

        public String getAccountInfo(string name , string password) 
        {
            return account.getAccountInfo(name, password);
        }
    }
}

