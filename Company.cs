using System;
using System.Collections.Generic;


namespace List_Employees
{
    class Company
    {
        public string CompanyName { get; set; }
       public List<Employee> EmployeeList { get; set; } = new List<Employee>();

       public void HireEmployee(Employee employee)
       {
           employee.CompanyName = this.CompanyName;
           EmployeeList.Add(employee);
       }

    }
}
