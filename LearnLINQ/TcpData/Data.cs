using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TcpData
{

    public static class Data
    {
        public static List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "sunny",
                LastName = "kumar",
                AnnualSalary = 450000,
                IsManager = true,
                DepartmentId = 1,
            };
            employees.Add(employee);
            Employee employee1 = new Employee
            {
                Id = 2,
                FirstName = "sumanth",
                LastName = "yadav",
                AnnualSalary = 400000,
                IsManager = true,
                DepartmentId = 2,
            };
            employees.Add(employee1);
            Employee employee3 = new Employee
            {
                Id = 3,
                FirstName = "bunny",
                LastName = "sharma",
                AnnualSalary = 550000,
                IsManager = false,
                DepartmentId = 3,
            };
            employees.Add(employee3);
            Employee employee4 = new Employee
            {
                Id = 4,
                FirstName = "sushma",
                LastName = "kumari",
                AnnualSalary = 650000,
                IsManager = false,
                DepartmentId = 4,
            };
            employees.Add(employee4);


            return employees;
        }
        public static List<Department>  GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department department0 = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"

            };
            departments.Add(department0);

            Department department1 = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"

            };
            departments.Add(department1);

            Department department2 = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Techonology"

            };
            departments.Add(department2);
             
            return departments; 

        }
        

}
}
