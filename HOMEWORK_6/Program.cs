using System.Threading.Channels;

namespace HOMEWORK_6;

class Program
{
    static void Main(string[] args)
    {
        #region Number 1
        // 1. დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
        // რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
        // ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .
        //     a. Input:
        // 10
        // 1 2 3 4 5 6 7 8 9 10
        // Output
        //     მასივი#1 : 2 4 6 8 10
        // მასივი#2: 1 3 5 7 9
        
        Console.Write("Enter the lenght of an array: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[arrLenght];
        
        int evenCounter = 0;
        int oddCounter = 0;
        
        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            arr[i] = num;

            if (arr[i] % 2 == 0)
            {
                evenCounter++;
            }
            else
            {
                oddCounter++;
            }
        }
        
        int[] evens = new int[evenCounter];
        int[] odds = new int[oddCounter];

        Console.Write("Your array: ");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        int evenIndex = 0;
        int OddIndex = 0;
        
        for (int i = 0; i < arrLenght; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evens[evenIndex] = arr[i];
                evenIndex++;
            }
            else
            {
                odds[OddIndex] = arr[i];
                OddIndex++;
            }
        }
        Console.Write("Even numbers: ");
        foreach (var even in evens)
        {
            Console.Write(even + " ");
        }

        Console.WriteLine();
        
        Console.Write("Odd numbers: ");
        foreach (var odd in odds)
        {
            Console.Write(odd + " ");
        }
        #endregion

    }
}