namespace HOMEWORK_10;

public class Bank : IFinanceOperations
{
    private bool _randomBool;
    
    public void CalculateLoanPercent(int month, double amountPerMonth)
    {
        if (_randomBool == true)
        {
            double total = (amountPerMonth + amountPerMonth * 5 / 100) * month;;
            Console.WriteLine($"The client must pay {total}$ in total");
        }
    }

    public void CheckUserHistory()
    {
        Random random = new Random();
        _randomBool = random.Next(0, 2) == 0;
        Console.WriteLine(_randomBool);
    }

}