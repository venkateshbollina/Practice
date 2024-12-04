using System;
using System.Collections.Generic;
using Company;


namespace company
{
    public interface IEmployeeMethods
    {
        void DisplayAllEmployees(List<Employee> employees);
        void DisplayAge(List<Employee> employees, int age);
        void DisplayGender(List<Employee> employees,string gender);
        void DisplayEmployeesWithDepartment(List<Employee> employees);
    }
}
