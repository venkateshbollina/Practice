using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TcpData;
using TcpExtensions;

namespace LearnLINQ
{
    public class Program
    {
        static void Main()
        {
            //    List<Employee> employeeList = Data.GetEmployees();
            //    var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary < 500000);

            //    foreach (var employee in filteredEmployees)
            //    {
            //        Console.WriteLine($"First name: {employee.FirstName}");
            //        Console.WriteLine($"lastname: {employee.LastName}");
            //        Console.WriteLine($"Annual salary: {employee.AnnualSalary}");
            //        Console.WriteLine($"IsManager: {employee.IsManager}");
            //        Console.WriteLine();
            //    }




            //List<Department> departmentList = Data.GetDepartments();
            //var filteredDepartment = departmentList.Where(dept => dept.ShortName == "HR" || dept.ShortName=="TE");

            //foreach (var department in filteredDepartment)
            //{
            //    Console.WriteLine($"Dept ID {department.Id}");
            //    Console.WriteLine($"First name: {department.ShortName}");
            //    Console.WriteLine($"lastname: {department.LongName}");

            //    Console.WriteLine();
            //} 

            List<Employee> employeelist = Data.GetEmployees();
            List<Department> departmentlist = Data.GetDepartments();

            var resultlist = from emp in employeelist
                             join dept in departmentlist
                             on emp.DepartmentId equals dept.Id
                             select new
                             {
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName,
                             };

            foreach (var employee in resultlist)
            {
                Console.WriteLine($"First name: {employee.FirstName}");
                Console.WriteLine($"lastname: {employee.LastName}");
                Console.WriteLine($"Annual salary: {employee.AnnualSalary}");
                Console.WriteLine($"IsManager: {employee.Manager}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine();
            }
            var averageAnnualSalary = resultlist.Average(a => a.AnnualSalary);
            Console.WriteLine($" Average annuel salery: {averageAnnualSalary}");

            var highestAnnuelSalary = resultlist.Max(a => a.AnnualSalary);
            Console.WriteLine($"hihest annuel saary: { highestAnnuelSalary}");



        }
    }
}
