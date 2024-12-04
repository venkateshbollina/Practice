using System;
using System.Collections.Generic;

using company;
using Company;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            
           
           
            var employees = GetEmployeesFromUser();
            var operations = new EmployeeMethods();


            Console.WriteLine("\nEnter age to filter employees:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter department name from the list to filter employees:\n (IT,civil,mechanical,electronics:)");
            string departmentName1 = Console.ReadLine();
            Console.WriteLine("\nEnter thr gender to filter the employees based on their grnder ");
            string gender = Console.ReadLine();

            operations.DisplayAllEmployees(employees);
            operations.DisplayAge(employees, age);
            operations.DisplayGender(employees, gender); 
            operations.DisplayEmployeesWithDepartment(employees);  

        }

        static List<Employee> GetEmployeesFromUser()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                Console.WriteLine("Enter the number of employees:");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Date of Birth (yyyy-mm-dd): ");
                    DateTime dob = DateTime.Parse(Console.ReadLine());
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.Write("Gender: ");
                    string gender = Console.ReadLine();
                    Console.Write("Designation name : ");
                    string designationName = (Console.ReadLine());
                    Console.Write("Designation iD ");
                    string designationId = (Console.ReadLine());
                    Console.Write("Department Name: ");
                    string departmentName = Console.ReadLine();
                    Console.Write("Department id: ");
                    string departmentID = Console.ReadLine();
                    Console.Write("Adress:");
                    string adress = Console.ReadLine();
                    Console.Write("maritial status:");
                    String maritialstatus = Console.ReadLine();


                    Employee employee = new Employee();
                    


                    employee.FirstName = firstName;
                    employee.EmployeeId = i +1;
                    
                    
                    employee.LastName = lastName;
                    employee.Dob = dob;
                    employee.Salary = salary;
                    employee.Gender = gender;

                    Designation designation = new Designation();
                    designation.DesignationName = designationName;
                    designation.DesignationId = int.Parse(designationId);
                    employee.Designation = designation;

                    Department department = new Department();
                    department.DepartmentName = departmentName;
                    department.DepartmentId = int.Parse(departmentID);
                    employee.Department = department;

                    employee.Address = adress;
                    employee.MaritalStatus = maritialstatus;
                    employees.Add(employee);
                }

                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                List<Employee> employees1 = new List<Employee>();
                Employee emp = new Employee();
                emp.Error = ex.StackTrace;
                employees1.Add(emp);
                return employees1;
            }
        } 

    }
}

