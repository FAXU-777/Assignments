namespace newHomeWork;

class Program
{
    static void Main(string[] args)
    {
        #region Divisibility
/*1. შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ. რიცხვი უნდა მიიღოთ
           კონსოლიდან.
           Input : 10 Output : Yes
           Input : 44 Output : NO*/
        Console.Write("Enter a number to check if it is divisible by 5: ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number % 5 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        

        #endregion
        
        
        
    }
}