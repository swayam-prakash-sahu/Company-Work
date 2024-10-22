using System;  
   public class Company  
    {  
       public void task() { Console.WriteLine("task"); }  
   }  
   public class Employee: Company  
   {  
       public void work() { Console.WriteLine("work"); }  
   }  
   public class Intern : Employee  
   {  
       public void practice() { Console.WriteLine("practice"); }  
   }  
   class TestInheritance2{  
       public static void Main(string[] args)  
        {  
            Intern d1 = new Intern();  
            d1.task();  
            d1.work();  
            d1.practice();  
        }  
    }  
