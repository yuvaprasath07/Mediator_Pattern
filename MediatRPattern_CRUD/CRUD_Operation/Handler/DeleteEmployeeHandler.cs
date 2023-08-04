using CRUD_Operation.Command;
using CRUD_Operation.Model;
using CRUD_Operation.Repositery.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Handler
{
    public class DeleteEmployeeHandler: IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public DeleteEmployeeHandler(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<int> Handle(DeleteEmployeeCommand command, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employeeRepo.GetEmployeeId(command.EmployeeId);
            if (EmployeeDetails == null)
                return default;

            return await _employeeRepo.DeleteEmployee(EmployeeDetails.EmployeeId);
        }
    }
}
