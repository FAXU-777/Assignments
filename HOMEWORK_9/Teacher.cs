namespace HOMEWORK_9;

public class Teacher
{
    public string Name { get; set; }
    public bool Certified { get; set; }

    public Teacher(string name, bool certified)
    {
        this.Name = name;
        this.Certified = certified;
    }
    

    public void Check(Student student)
    {
        Random random = new Random();
        int num1 = random.Next();
        int num2 = random.Next();
        int sum = num1 + num2;
        
        if (student.Subject == $"Math")
        {
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }else if (student.Subject == "Chemistry")
        {
            Console.WriteLine("H2O");
        }else if (student.Subject == "English")
        {
            Console.WriteLine("Text in English");
        }
        else
        {
            Console.WriteLine($"Is not competent in {student.Subject}");
        }
    }
    

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Certified: {Certified}");
    }
}