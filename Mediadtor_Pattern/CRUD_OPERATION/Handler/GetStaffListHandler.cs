using CRUD_OPERATION.Model;
using CRUD_OPERATION.Query;
using CRUD_OPERATION.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Handler
{
    public class GetStaffListHandler : IRequestHandler<StaffListQuery, List<StaffModel>>
    {
        private readonly IStaffRepo _employeeRepo;

        public GetStaffListHandler(IStaffRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<List<StaffModel>> Handle(StaffListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetStaff();
        }
    }
}
