namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            double amount = 100;
            BankAccount.balance = amount;

            Console.WriteLine(BankAccount.GetBalance());
        }
    }
}