namespace HomeWork_7;

class Program
{
    static void Main(string[] args)
    {
        // 1. მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში
        // ჩახატულია კიდევ ერთი სხვა კვადრატი .
        //     დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
        //     ფართობებს შორის .
        //     Input : 5 (რადიუსი )
        // Output : 50
        
        Console.Write("Enter rafius of circle: ");
        var radius = Convert.ToInt32(Console.ReadLine());
        var bigSquare = (2* radius)  * (2* radius) ;
        var smallSquare = bigSquare/2;
        Console.WriteLine($"Area of big square is : {bigSquare} and small square: {smallSquare}");
        Console.WriteLine();
        
        
        //     2. დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა თუ არა იუზერს
        //         ჯეკპოტი
        //
        //     Input : [ “@”,“@”,“@”,“@”,“@”,“@”]
        //     Input : [ “X”,“X”,“X”]
        //     Output : Yes
        //     Input : [ “S”,“S”,“S”]
        //     Output : Yes
        //     Input : [ “@”,“a”,“@”,“@”,“@”,“@”]
        //     Output : No

        Console.WriteLine("Welcome Casino");
        Console.Write("Enter your option: "); 
        string option = Console.ReadLine();

        bool same = option.All(x => x == option[0]);
        
        if (same) Console.WriteLine("Congrats you win");
        else Console.WriteLine("Sorry, you lost everything");
        Console.WriteLine();
        
        // 3. დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა
        //     საფეხბურთო გუნდმა
        // a. მოგება - 3
        // b. ფრე = 1
        // c. წაგება = 0
        //
        // Input : [მოგება - 3,ფრე - 1,წაგება -1]
        //
        // Output : 10

        Console.Write("Enter amount of win: ");
        int win = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter amount of draw: ");
        var draw = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter amount of loos: ");
        var loss = Convert.ToInt32(Console.ReadLine());

        int finalScore = (int)Score.Win * win +(int) Score.Draw * draw + (int)Score.Loss * loss;
        Console.WriteLine($"Final score is {finalScore}");
        Console.WriteLine();
        
        // 4. დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
        // კვირის განმავლობაში .
        //     გაითვალისწინეთ
        // a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
        // b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
        // c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს
        //
        // Input : 8, 8, 8, 8, 8, 0, 0
        // Output : 400
        // Input : 8, 8, 8, 8, 8, 8, 0
        // Output : 560
        // Input : 4,4,4,4,4,0,4
        // Output : 280
        // Input : 5,8,8,8,8,8,8
        // Output : 690

     

        int[] arr = new int[7];
        int salary = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter hours of each day of week: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            arr[i] = hours;
        }
        for (int i = 0; i < arr.Length-2; i++)
        {
            if (arr[i] >= 0 && arr[i] <= 8)
            {
                salary += arr[i] * (int)Money.Ord;
            }
            else
            {
                int diff = arr[i] - 8;
                salary += 80 + diff * (int)Money.OverTime;
            }
        }

        salary += arr[5] *(int)Money.Ord * (int)Money.Weekends;
        salary += arr[6] * (int)Money.Ord * (int)Money.Weekends;
        
        Console.WriteLine($"Salary is: {salary}");
        Console.WriteLine();
        
        // 5. გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
        //     .შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
        //     დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.
        //
        //     Input : 5, 8, 8, 9,10
        // Output : 3
        // Input : 5,5,5,5
        // Output: 0

        List<int> nums = new List<int>();
        Console.Write("Enter amount of nums: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        int max = 0;

        for (int i = 0; i < amount; i++)
        {
            Console.Write("Enter numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            nums.Add(num);
        }

        for (int i = 0; i < nums.Count-1; i++)
        {
            if (nums[i+1] > nums[i])
            {
                max++;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine();
        
        // 6. დაწერეთ პროგრამა რომელიც ამობეჭდავს N სიგრძის მქონდე ელემენტს
        //     მასივიდან
        //
        // Input : N = 7
        //
        //     „Hello”, “World” , “Programming”, “communication”
        // Output : Programming, “communication”
        // Input : N = 15
        //     „Hello”, “World” , “Programming”, “communication”
        // Output : No elements found

        string[] arr2 = { "Hello", "World", "Programming", "communication" };

        Console.Write("Enter length of string you want: ");
        int lenght = Convert.ToInt32(Console.ReadLine());
        

        for (int i = 0; i < arr.Length; i++)
        {
            if (lenght <= arr2[i].Length)
            {
                Console.WriteLine(arr[i]);
            }
        }
        
    }
    enum Money
    {
        Ord = 10,
        OverTime = 5,
        Weekends = 2
    }
    enum Score
    {
        Win = 3,
        Draw = 1,
        Loss=0
    }
        
    
}