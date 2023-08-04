using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Command
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public UpdateEmployeeCommand(int employeeId, string firstName, string lastName, int age, string department)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
        }
    }
}
