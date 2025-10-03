namespace HOMEWORK_10;

public class MicroFinance : IFinanceOperations
{
    private bool _randomBool;
    public void CalculateLoanPercent(int month, double amountPerMonth)
    {
        if (_randomBool)
        {
            double total = (amountPerMonth + amountPerMonth * 10 / 100) * month + month * 4 ;;
            Console.WriteLine($"The client must pay {total}$ in total");
        }
    }

    public void CheckUserHistory()
    { 
        _randomBool= true;
    }
}