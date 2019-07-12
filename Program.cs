using System;

namespace List_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee Deep = new Employee()
           {
               EmployeeName = "Deep Patel",
               EmployeeTitle = "CTO",
               StartDate = "11/11/11"
           }; 
            Employee Janki = new Employee()
           {
               EmployeeName = "Janki Patel",
               EmployeeTitle = "CEO",
               StartDate = "11/11/11"
           }; 


           Company DeepAndCO = new Company()
           {
               CompanyName = "Deep and Co",
           };

           DeepAndCO.HireEmployee(Deep);
           DeepAndCO.HireEmployee(Janki);

        foreach (Employee employee in DeepAndCO.EmployeeList)
            {
            Console.WriteLine($"{employee.EmployeeName} works at {employee.CompanyName} as {employee.EmployeeTitle} they started on {employee.StartDate}");
            }
        }

    }
}
