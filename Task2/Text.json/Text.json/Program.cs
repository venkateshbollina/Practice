

using System.Text.Json;
using System;

namespace Text.json {

    public class Program
    {
        employee employee = new employee()
        {
            FirstName = "sunny",
            LastName = "sss",
            Dob = DateTime.Parse("2001-12-12"),
            EmployeeId = 1,
            Gender="male",
            Salary=200000

        };

        var json = jsonSerializer.Serialize(employee);



    }


}