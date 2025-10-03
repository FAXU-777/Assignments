namespace HOMEWORK_9;

public class Employee
{
    public string Name { get; set;}
    public string Surname { get; set; }
    public int Age { get; set; }
    public Positions Position { get; set; }
    public int [] HoursOfWork { get; set; }
    public int Salary { get; set; }

    public Employee(string name,string surname, int age, Positions position,int [] hoursOfWork  )
    {
        if (hoursOfWork.Length != 7)
        {
            throw new ArgumentException("HoursOfWork must contain exactly 7 elements (one for each day of the week)");
        }

        this.HoursOfWork  = hoursOfWork;
        this.Position = position;
        this.Name = name;
        this.Age = age;
        this.Surname = surname;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Position: {Position},");
    }

    public void AverageSalary()
    {
        Salary = 0;
        for (int i = 0; i < HoursOfWork.Length-2; i++)
        {
            if (HoursOfWork[i] >= 0 && HoursOfWork[i] <= 8)
            {
                Salary += HoursOfWork[i] * (int)Money.Ord;
            }
            else
            {
                int diff = HoursOfWork[i] - 8;
                Salary += 80 + diff * (int)Money.OverTime;
            }
        }
        Salary += HoursOfWork[5] *(int)Money.Ord * (int)Money.Weekends;
        Salary += HoursOfWork[6] * (int)Money.Ord * (int)Money.Weekends;

        
        if (Position == Positions.Meneger)
        {
            Salary *= 4;
        }else if (Position == Positions.Developer)
        {
            Salary *= 3;
        }
        else if (Position==Positions.Tester)
        {
            Salary *= 2;
        }

        int totalHour = 0;
        for (int i = 0; i < HoursOfWork.Length; i++)
        {
            totalHour += HoursOfWork[i];
        }

        if (totalHour > 50)
        {
            Salary = Salary + (Salary * 20) /100;
        }

        Console.WriteLine($"Salary is: {Salary}");
    }
    enum Money
    {
        Ord = 10,
        OverTime = 5,
        Weekends = 2
    }

    public enum Positions
    {
        CoWorker,
        Meneger,
        Developer,
        Tester
    }
    
    
}