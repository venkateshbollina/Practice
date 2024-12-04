using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using company;

namespace Company
{
   public  class Employee 
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public Designation Designation { get; set; } 
        public Department  Department { get; set; }   
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Error { get; set; }
    }

}

