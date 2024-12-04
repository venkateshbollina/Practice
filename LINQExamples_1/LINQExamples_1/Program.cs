using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;


namespace LINQExamples_1
{
    public class Program
    {
        static void Main()
        {

            //List<Employee> employee = new List<Employee>()
            //{
            //    new Employee() { Id = 101, Name = "Sunny", Job="Manager",city="bengaluru",AnnualSalary=9000000 },
            //    new Employee() { Id = 102, Name = "bunny", Job="HR",city="bengaluru",AnnualSalary = 5000000 },
            //    new Employee() { Id = 103, Name = "tommy", Job="testing ",city="bengaluru",AnnualSalary = 6000000 },
            //    new Employee() { Id = 104, Name = "money", Job="developer",city="bengaluru" , AnnualSalary = 5000000}


            //};


            //var result = employee.Where(emp => emp.Job == "Manager");
            //foreach (Employee item in result)
            //{
            //    Console.WriteLine(item.Id + "," + item.Name + "," + item.Job + "," + item.city);
            //}


            //IEnumerable<Employee> Sortedexampke = employee.OrderBy(emp => emp.AnnualSalary);
            //IEnumerable<Employee> Sortedexampke1 = employee.OrderByDescending(emp => emp.AnnualSalary).ThenBy(emp => emp.Id);
            //IEnumerable<Employee> Sortedexampke2 = employee.OrderBy(emp => emp.AnnualSalary).ThenBy(emp=> emp.Id);
            //foreach (Employee item in Sortedexampke)
            //{
            //    Console.WriteLine(item.Id+","+item.Name+","+item.Job+","+item.city+","+item.AnnualSalary);
            //}
            //Console.WriteLine();

            //foreach (Employee item in Sortedexampke1)
            //{
            //    Console.WriteLine(item.Id+","+item.Name+","+item.Job+","+item.city+","+item.AnnualSalary);
            //}
            //Console.WriteLine();
            //foreach (Employee item in Sortedexampke2)
            //{
            //    Console.WriteLine(item.Id+","+item.Name+","+item.Job+","+item.city+","+item.AnnualSalary);
            //}
            //Console.WriteLine();

            List<Employee> employeelist = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();



            //var results = employeelist.Select(e => new
            //{
            //    FullName = e.FirstName + "" + e.LastName,
            //    annualSalary = e.AnnualSalary
            //}).Where(e => e.annualSalary >= 50000);

            //foreach (var items in results)
            //{
            //    Console.WriteLine($"{items.FullName,-20}{items.annualSalary,10}");
            //}
            //var result = departmentList.Join(employeelist, department => department.Id, employee => employee.DepartmentId, 
            //(departments, employees) => new

            //var result = from dept in departmentList
            //             join emp in employeelist
            //             on dept.Id equals emp.DepartmentId
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 annualsalary = emp.AnnualSalary,
            //                 departmentname = dept.LongName
            //             };


            //foreach (var items in result)
            //{
            //    Console.WriteLine($"{items.FullName,-20}{items.annualsalary,10}\t{items.departmentname}");
            //}

            var results = departmentList.GroupJoin(employeelist, dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, employeeGroup) => new { employee = employeeGroup, departmentName = dept.LongName }
                );

            foreach (var items in results)
            {
                Console.WriteLine($" Departmrnt Name: {items.departmentName}");
                foreach (var emp in items.employee)
                {
                    Console.WriteLine($"\t {emp.FirstName}{emp.LastName}");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();

            var result = from dept in departmentList
                          join emp in employeelist
                          on dept.Id equals emp.DepartmentId
                          into employeeGroup
                          select new
                          {
                              Employees = employeeGroup,
                              departmenName = dept.LongName

                          };

            foreach (var item in result)
            {

                Console.WriteLine($" Departmrnt Name: {item.departmenName}");
                foreach (var emp in item.Employees)
                {
                    Console.WriteLine($"\t {emp.FirstName}{emp.LastName}");
                }

            }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal AnnualSalary { get; set; }
            public bool IsManager { get; set; }
            public int DepartmentId { get; set; }
            public string Job { get; set; }
            public string City { get; set; }

        }

        public class Department
        {
            public int Id { get; set; }
            public string ShortName { get; set; }
            public string LongName { get; set; }

        }
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
                    DepartmentId = 2,
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
            public static List<Department> GetDepartments()
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
}
