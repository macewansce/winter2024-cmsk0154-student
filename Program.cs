namespace Assignment03
{

    public class SavingAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Saving account data.");
        }
    }

    public class CurrentAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Current account data.");
        }
    }

    public class Account
    {
        SavingAccount savingAccount = new SavingAccount();
        CurrentAccount currentAccount = new CurrentAccount();

        public void PrintAccounts()
        {
            savingAccount.PrintData();
            currentAccount.PrintData();
        }
    }

    static public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.PrintAccounts();
        }
    }

}
