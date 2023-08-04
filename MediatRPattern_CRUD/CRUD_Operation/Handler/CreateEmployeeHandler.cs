using CRUD_Operation.Command;
using CRUD_Operation.Model;
using CRUD_Operation.Repositery.Interface;
using MediatR;

namespace CRUD_Operation.Handler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeModel>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public CreateEmployeeHandler(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<EmployeModel> Handle(CreateEmployeeCommand command, CancellationToken cancellationToken)
        {
            var Employee = new EmployeModel()
            {
                EmployeeId  = command.EmployeeId,
                FirstName = command.FirstName,
                LastName = command.LastName,
                Age = command.Age,
                Department = command.Department
            };
            return await _employeeRepo.AddEmployee(Employee);
        }
    }
}