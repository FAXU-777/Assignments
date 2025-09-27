namespace HOMEWORK_8;

class Program
{
    static void Main(string[] args)
    {
        
        // 1. დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს a,b, n
        // a. a - მინიმალური რიცხვი
        // b. b - მაქსიმალური რიცხვი
        // c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
        // იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის nხარისხი
        //     მოთავსებულია ამ ინტერვალში
        // Input : 49, 71 , 2 // 7^2 და 8^2 მოთავსდება ამ შუალედში
        // Output : 2
        //
        // Input : 2, 27 , 4 // 2^4
        // Output : 1
        Number_square();
    }

    public static void Number_square()
    {
        int minA;
        int maxB;
        int power;
        Console.WriteLine("Enter min number: ");
        minA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter max number: ");
        maxB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter power: ");
        power = Convert.ToInt32(Console.ReadLine());

        int amount = 0;
        for (int i = 0; Math.Pow(i, power) <= maxB; i++)
        {
            if (Math.Pow(i, power) <= maxB && Math.Pow(i, power) >= minA)
            {
                Console.WriteLine(
                    $"Number {i} raised to power {power} is {Math.Pow(i, power)} and in the range of {minA}-{maxB}");
                amount++;
            }
        }

        Console.WriteLine($"Amount is {amount}");
    }

}