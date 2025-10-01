namespace HOMEWORK_9;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EnrollmentYear { get; set; }
    public string Subject { get; set; }

    public Student(string name, int age, int enrollmentYear)
    {
        this.Name = name;
        this.Age = age;
        this.EnrollmentYear = enrollmentYear;

    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Enrollment: {EnrollmentYear}");
    }

    public void UniGraduation()
    {
        int end = 22- this.Age;
        Console.WriteLine($"{Name} left {end} years to graduate");
    }

    public void RandomSubject()
    {
        string[] subjects = new[] { "Math", "English", "Chemistry", "Manual testing", "Data Bases-1" };

        Random random = new Random();
        int num = random.Next(0, 4);
        Console.WriteLine(subjects[num]);
        this.Subject = subjects[num];
        
    } 
}
