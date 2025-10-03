namespace HOMEWORK_9;

public class Company
{
   public string ForeignOrNative { get; set; }
  
   
   public Company(string foreignOrNative)
   {
      this.ForeignOrNative = foreignOrNative;
   }

   public void Checker(Employee employee)
   {
      if (ForeignOrNative.ToLower() == "foreign")
      {
         int fee = employee.Salary * 5 / 100;
         employee.Salary = employee.Salary - fee;
         Console.WriteLine($"Money that goes from {employee.Name} to goverment: {fee}");
         
      }else if (ForeignOrNative.ToLower() == "native")
      {
         int fee = employee.Salary * 18 / 100;
         employee.Salary = employee.Salary - fee;
         Console.WriteLine($"Money that goes from {employee.Name} to goverment: {fee}");
      }
      else
      {
         Console.WriteLine("Invalid");
      }
      
   }
   
}