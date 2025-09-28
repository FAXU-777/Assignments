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
        Console.WriteLine();
        
        
        // 2. დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
        //     აღნიშნულია ორი ერთნაირი სიმბოლოთი.
        //     Input : AA
        // Output : 1
        //
        // Input : AABBCC
        // Output : 3
        //
        // Input : AABBC
        // Output : 2
        // Input : ABABC
        // Output : 2
        // Input : AAABB
        // Output : 2
        Duplicates();
        Console.WriteLine();
        
        // 3. დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველაზე გრძელ საერთო
        // ბოლოსართს ორ სტრინგს შორის .
        //     Input : multiplication , substraction
        // Output : tion
        // Input : Some Random Text, It is Some Random Text
        // Output : Some Random Text
        Comparision();
        Console.WriteLine();


       


        
        
        

      
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

    public static void Duplicates()
    {
        Console.Write("Enter input: ");
        string input = Console.ReadLine();

        if (input != null)
        {
            
            var duplicates = input
                .ToUpper()
                .GroupBy(n => n)
                .Count(n => n.Count() > 1);
            Console.WriteLine($"The number of pairs is: {duplicates}");
        }
    }


    public static void Comparision()
    {
        Console.Write("Enter first word: ");
        var word1 = Console.ReadLine();
        Console.Write("Enter second word: ");
        var word2 = Console.ReadLine();

        // var sortedFirst = word1
        //     .ToLower()
        //     .OrderBy(n => n);
        
        int i = word1.Length -1 ;   
        int j = word2.Length -1 ;

        // var sortedSecond = word2
        //     .ToLower()
        //     .OrderBy(n => n);

        var result = " ";

        while (i != 0 && j != 0 && word1[i] == word2[j])
        {
            result = word1[i] + result;
            i--;
            j--;
        }

        Console.WriteLine(result);
    }

}