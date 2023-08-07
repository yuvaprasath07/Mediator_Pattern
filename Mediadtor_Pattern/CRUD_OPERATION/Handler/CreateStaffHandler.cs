using CRUD_OPERATION.Command;
using CRUD_OPERATION.Model;
using CRUD_OPERATION.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Handler
{
    public class CreateStaffHandler : IRequestHandler<CreateStaffCommand, StaffModel>
    {
        private readonly IStaffRepo _employeeRepo;

        public CreateStaffHandler(IStaffRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<StaffModel> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            var staff = new StaffModel()
            {
                STAFF_ID = request.STAFF_ID,
                NAME = request.NAME,
                AGE = request.AGE,
                DEPARTMENT = request.DEPARTMENT
            };
            return await _employeeRepo.Addstaff(staff);
        }
    }
}
