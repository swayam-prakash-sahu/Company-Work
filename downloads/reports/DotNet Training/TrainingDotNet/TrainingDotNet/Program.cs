using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TrainingDotNet;
using TrainingDotNet.EntityModels;

namespace TrainingDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntityDataModel entityDataModel = new EntityDataModel();
            List<Employee> employees = entityDataModel.Employees.ToList();


            Console.ReadLine();
        }

        private static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        private static void AddNumbers(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        private static void AddNumbers(double a, double b, double c)
        {
            Console.WriteLine(a + b + c);
        }


        public static string FullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
