using CRUD_OPERATION.Command;
using CRUD_OPERATION.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Handler
{
    public class UpdateStaffHandler : IRequestHandler<UpdateStaffCommand, int>
    {
        private readonly IStaffRepo _employeeRepo;

        public UpdateStaffHandler(IStaffRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<int> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employeeRepo.GetStaffId(request.STAFF_ID);
            if (EmployeeDetails == null)
                return default;

            EmployeeDetails.NAME = request.NAME;
            EmployeeDetails.AGE = request.AGE;
            EmployeeDetails.DEPARTMENT = request.DEPARTMENT;

            return await _employeeRepo.UpdateStaff(EmployeeDetails);
        }
    }
}
