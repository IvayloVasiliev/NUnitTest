namespace BankAcount
{
    class StartUp
    {
        public static void Main()
        {
            BankAccount acc = new BankAccount(0);
            acc.Deposit(0);
            System.Console.WriteLine(acc.Amount);
        }
    }
}
