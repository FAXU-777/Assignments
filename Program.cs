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

        #region Calculator
        /*დაწერეთ ისეთი პროგრამა, რომელიც შეასრულებს ჯამის, სხვაობის,
           ნამრავლის და გაყოფის მოქმედებები
           შენიშვნა
           i. გაყოფის და გამოკლების დროს აარჩიეთ უდიდესი და მას
           გამოაკელით უმცირესი
           ii. თუ უმცირესი რიცხვი იქნება 0 პროგრამამ უნდა გამოიტანოს
           შეცდომა 0 გაყოფა არ შეიძლება .*/
        Console.WriteLine("Enter number one: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number two: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Now choose an operator: ");
        Console.WriteLine("1. + ");
        Console.WriteLine("2. - ");
        Console.WriteLine("3. * ");
        Console.WriteLine("4. / ");

        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+" :
                double sum = numberOne + numberTwo;
                Console.WriteLine("The sum of " + numberOne +" and " + numberTwo +" is "+  sum);
                break;
            case  "-" :
                if (numberTwo > numberOne)
                {
                    int temp = numberOne;
                    numberOne = numberTwo;
                    numberTwo = temp;
                }
                double sub = numberOne - numberTwo;
                Console.WriteLine(numberOne + " - "+ numberTwo+ " = " + sub);
                break;
            case "*" :
                double num = numberOne * numberTwo;
                Console.WriteLine(numberOne +" * "+ numberTwo+ " = "+ num );
                break;
            case "/":
                if (numberTwo > numberOne)
                {
                    int temp = numberOne;
                    numberOne = numberTwo;
                    numberTwo = temp;
                }
                if (numberTwo == 0)
                {
                    Console.WriteLine("erro it cant bew divided by zero");
                }
                else
                {
                    double div = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {div}");
                }
                break;
            
            default: Console.WriteLine("Invalid input");
                break;
        }

        #endregion
        
        
    }
}