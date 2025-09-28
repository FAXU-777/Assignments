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


        // 4. დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს , შეამოწმებს
        // გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ
        // ოპერაციებს .
        //     თუ გადაეცემა სტრინგების ლისტი - დაბეჭდავს ყველა სტრინგს UpperCase-ში
        // თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი ( int) - დაითვლის მათ ჯამს
        // თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ
        // ელემენტს .
        //
        //     Input : 5,5
        // Output : 10
        //
        // Input : List&lt;string&gt;() { &quot;test&quot;,&quot;random&quot;,&quot;programming&quot;,&quot;word&quot; };
        // Output : TEST
        //     RANDOM
        // PROGRAMMING
        //     WORD
        // Input : true,false,true,false,true,false,false
        // Output : first Element is True
        //     Last Element is False
        //     Middle Element is False

        List<string> name = new List<string>();
        name.Add("Nika");
        name.Add("Nugo");
        ListInput(name);
        
        List<int> number = new List<int>();
        number.Add(1);
        number.Add(2);
        number.Add(32);
        ListInput(number);
        List<bool> bools = new List<bool>();
        bools.Add(true);
        bools.Add(false);
        bools.Add(false);
        bools.Add(true);
      
        ListInput(bools);
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
    
    public static void ListInput<T>(List<T> list)
    {
        Console.WriteLine($"Element type: {typeof(T)}");
        
        if (typeof(T) == typeof(string))
        {
            foreach (var element in list)
            {
                string str = element as string;
                Console.WriteLine(str.ToUpper());
            }
        }

        if (typeof(T) == typeof(int))
        {
            int sum = 0;

            foreach (var elem in list)
            {
                sum += (int)(object)elem;
            }

            Console.WriteLine($"Sum is {sum}");
        }

        Console.WriteLine();

        if (typeof(T) == typeof(bool))
        {
            var middle = list.Count / 2;
            Console.WriteLine($"Firs element {list.First()}");
            Console.WriteLine($"Middle is: {list[middle]}");
            Console.WriteLine($"Last element {list.Last()}");
        }
    }

}