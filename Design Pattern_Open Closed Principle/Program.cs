using System.Collections.Generic;
using System;
using OCP_Library;
using OCP_Library.Applicants; // this is not needed if corresponding namespace OCP_Library but not OCP_Library.Applicants


/*   Closed for modification 
     Open for extension
     Either inherit or use the same interface so that we can grow the app and add new features without changing working code

Open Closed principle works hand in hand with Single Responsibility principle   */

// This project using interface to allow us to bring a new class that uses the same structure but has new features
// just making small changes based upon new circumstances
// thus Accounts class doesn't have to change unless there's a bug

namespace Design_Pattern_Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tom", LastName ="Corey"},
                new TechnicianModel {FirstName = "Jane", LastName ="Corey"},
                new ManagerModel { FirstName = "Sue", LastName ="Green"},
                new ExecutiveModel { FirstName = "Louise", LastName ="Luo"}          
            };
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }
            Console.WriteLine("\nEmplyees : \n");
            int num = 1;
            foreach(var employee in employees)
            {
                Console.WriteLine(num);
                num++;
                Console.WriteLine($"{employee.FirstName}{employee.LastName} is manager :  {employee.IsManager}");
                Console.WriteLine($"{employee.FirstName}{employee.LastName} is executive :  {employee.IsExecutive}");
                Console.WriteLine($"-- {employee.EmailAddress}  ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
