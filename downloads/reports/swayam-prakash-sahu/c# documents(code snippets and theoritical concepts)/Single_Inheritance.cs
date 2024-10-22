using System;  
   public class Intern  
    {  
       public float salary = 30000;  
   }  
   public class Programmer: Intern  
   {  
       public float bonus = 10000;  
   }  
   class SingleInheritance{  
       public static void Main(string[] args)  
        {  
           Programmer p1 = new Programmer();  
              
          Console.WriteLine("Stipend: " + p1.salary);  
          Console.WriteLine("Bonus: " + p1.bonus);  
  
        }  
    }  
