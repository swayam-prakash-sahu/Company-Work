using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


namespace SecondConsoleApp1
{
    class Car
    {
        string color;                 
        int maxSpeed;                 
        public void fullThrottle()    
        {
            Console.WriteLine("The car is going as fast as it can!");
            Console.Read();
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();  
        }
    }
}
