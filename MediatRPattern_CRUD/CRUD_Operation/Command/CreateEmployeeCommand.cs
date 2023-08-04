using CRUD_Operation.Handler;
using CRUD_Operation.Model;
using MediatR;

namespace CRUD_Operation.Command
{
    public class CreateEmployeeCommand : IRequest<EmployeModel>
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public CreateEmployeeCommand(int employeeId, string firstName, string lastName, int age, string department)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
        }
    }
}