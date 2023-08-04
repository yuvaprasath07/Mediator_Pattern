using CRUD_Operation.Command;
using CRUD_Operation.Repositery.Interface;
using MediatR;

namespace CRUD_Operation.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public UpdateEmployeeHandler(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<int> Handle(UpdateEmployeeCommand command, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employeeRepo.GetEmployeeId(command.EmployeeId);
            if (EmployeeDetails == null)
                return default;

            EmployeeDetails.FirstName = command.FirstName;
            EmployeeDetails.LastName = command.LastName;
            EmployeeDetails.Age = command.Age;
            EmployeeDetails.Department = command.Department;

            return await _employeeRepo.UpdateEmployee(EmployeeDetails);
        }
    }
}