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

    }
}