using CRUD_OPERATION.Command;
using CRUD_OPERATION.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRUD_OPERATION.Handler
{
    public class DeleteStaffHandler : IRequestHandler<DeleteStaffCommand, int>
    {
        private readonly IStaffRepo _employeeRepo;

        public DeleteStaffHandler(IStaffRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<int> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employeeRepo.GetStaffId(request.STAFF_ID);
            if (EmployeeDetails == null)
                return default;

            return await _employeeRepo.DeleteEmployee(EmployeeDetails.STAFF_ID);
        }
    }
}
