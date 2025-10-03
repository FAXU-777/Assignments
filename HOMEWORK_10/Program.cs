namespace HOMEWORK_10;

class Program
{
    static void Main(string[] args)
    {
        ChildWorker childWorker = new ChildWorker(128, "Txt");
        childWorker.Delete();
        childWorker.Edit();
        childWorker.Read();
        childWorker.Write();


        Bank bank = new Bank();
        bank.CheckUserHistory();
        bank.CalculateLoanPercent(5,100);
        MicroFinance microFinance = new MicroFinance();
        microFinance.CheckUserHistory();
        microFinance.CalculateLoanPercent(5,100);
    }
}