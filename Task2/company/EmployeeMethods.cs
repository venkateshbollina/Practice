using System;
using System.Collections.Generic;
using System.Linq;

using Company;

namespace company
{
    public class EmployeeMethods : IEmployeeMethods

    {
        public void DisplayAllEmployees(List<Employee> employees)
        {
            try
            {

                Console.WriteLine("\nAll Employees:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.EmployeeId}: {emp.FirstName} {emp.LastName}, \n{emp.Designation},{emp.Designation.DesignationId}," +
                        $" \n{emp.Department},{emp.Department.DepartmentId},\n{emp.Address},{emp.Gender},{emp.Dob},{emp.MaritalStatus}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }




        public void DisplayAge(List<Employee> employees, int age)
        {
            try
            {
                Console.WriteLine($"\nEmployees above age {age}:");
                var result = employees.Where(emp => (DateTime.Now.Year - emp.Dob.Year) > age);
                foreach (var emp in result)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void DisplayGender(List<Employee> employees, string gender)
        {
            try
            {
              
                List<EmployeeDetails> employeeDetailsList = new List<EmployeeDetails>();

               
                var filteredEmployees = employees
                    .Where(emp => string.Equals(emp.Gender, gender ))
                    .Select(emp => new EmployeeDetails
                    {
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        Gender = emp.Gender,
                        DepartmentName = emp.Department.DepartmentName
                    }).ToList();




                employeeDetailsList.AddRange(filteredEmployees);

               
                Console.WriteLine($"\n{gender} Employees:");
                foreach (var emp in employeeDetailsList)
                {
                    Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}, Gender: {emp.Gender}, Department: {emp.DepartmentName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void DisplayEmployeesWithDepartment(List<Employee> employees)
        {
            try
            {
                var result = from emp in employees
                             join dept in employees.Select(e => e.Department) 
                             on emp.Department.DepartmentId equals dept.DepartmentId
                             select new
                             {
                                 emp.FirstName,
                                 emp.LastName,
                                 emp.Gender,
                                 emp.Department.DepartmentName
                             };

                Console.WriteLine("\nEmployees with Department Information:");
                foreach (var item in result)
                {
                    Console.WriteLine($"Name: {item.FirstName} {item.LastName}, Gender: {item.Gender}, Department: {item.DepartmentName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }


}

