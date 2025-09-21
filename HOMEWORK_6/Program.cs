using System.Threading.Channels;

namespace HOMEWORK_6;

class Program
{
    static void Main(string[] args)
    {
        // #region Number1
        //
        // // 1. დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
        // // რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
        // // ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .
        // //     a. Input:
        // // 10
        // // 1 2 3 4 5 6 7 8 9 10
        // // Output
        // //     მასივი#1 : 2 4 6 8 10
        // // მასივი#2: 1 3 5 7 9
        //
        // Console.Write("Enter the lenght of an array: ");
        // int arrLenght = Convert.ToInt32(Console.ReadLine());
        // int[] arr = new int[arrLenght];
        //
        // int evenCounter = 0;
        // int oddCounter = 0;
        //
        // for (int i = 0; i < arrLenght; i++)
        // {
        //     Console.Write("Enter a number: ");
        //     int num = Convert.ToInt32(Console.ReadLine());
        //     arr[i] = num;
        //
        //     if (arr[i] % 2 == 0)
        //     {
        //         evenCounter++;
        //     }
        //     else
        //     {
        //         oddCounter++;
        //     }
        // }
        //
        // int[] evens = new int[evenCounter];
        // int[] odds = new int[oddCounter];
        //
        // Console.Write("Your array: ");
        // foreach (var num in arr)
        // {
        //     Console.Write(num + " ");
        // }
        //
        // Console.WriteLine();
        //
        // int evenIndex = 0;
        // int OddIndex = 0;
        //
        // for (int i = 0; i < arrLenght; i++)
        // {
        //     if (arr[i] % 2 == 0)
        //     {
        //         evens[evenIndex] = arr[i];
        //         evenIndex++;
        //     }
        //     else
        //     {
        //         odds[OddIndex] = arr[i];
        //         OddIndex++;
        //     }
        // }
        //
        // Console.Write("Even numbers: ");
        // foreach (var even in evens)
        // {
        //     Console.Write(even + " ");
        // }
        //
        // Console.WriteLine();
        //
        // Console.Write("Odd numbers: ");
        // foreach (var odd in odds)
        // {
        //     Console.Write(odd + " ");
        // }
        //
        // #endregion

        #region Number 2

        // შექმენით კონტაქტების აპლიკაცია რომელსაც ექნება კონტაქტის დამატების,
        //     წაშლის და განახლების ფუნქციონალი ( გამოიყენეთ Dictionary)

        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("--Contact List--");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Delete contact");
            Console.WriteLine("3. Update contact");
            Console.WriteLine("4. show contact");
            Console.WriteLine("5. Exit from contact");
            Console.WriteLine();
            
            Console.Write("Enter number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddContatcs(contacts);
                    break;
                case 2 : DeleteContact(contacts);
                    break;
               case 3: UpdateContacts(contacts);
                   break;
                case 4: ShowContacts(contacts);
                    break;
                
             
                case 5: return;
            }

            Console.WriteLine();
        }
        #endregion
    }


public static void AddContatcs(Dictionary<string, string> contacts)
    {
        Console.Write("Eneter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Phone: ");
        string phone =Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact already exist");
        }
        else
        {
            contacts.Add(name, phone);
        }
        Console.WriteLine($"{name} was added in your contacts");
    }

    public static void DeleteContact(Dictionary<string, string> contacts)
    {
        Console.Write("Enter name you want to delete: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            contacts.Remove(name);
            Console.WriteLine("Contact deleted!");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
            
        }
         public static void ShowContacts(Dictionary<string, string> contatcs)
    {

        if (contatcs.Count == 0)
        {
            Console.WriteLine("Contacts is empty ");
        }
        foreach (var contact in contatcs)
        {
            Console.WriteLine($"Name: {contact.Key} \nPhone: {contact.Value}");
        }
    }

    public static void UpdateContacts(Dictionary<string, string> contacts)
    {
        Console.Write("Enter name you wnat to update: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.Write("Enter new phone number: ");
            string newPhoneNumber = Console.ReadLine();
            contacts[name] = newPhoneNumber;
            Console.WriteLine("Contact updated");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
}
    