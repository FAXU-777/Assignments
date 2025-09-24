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

    }

    enum Score
    {
        Win = 3,
        Draw = 1,
        Loss=0
    }
        
    
}