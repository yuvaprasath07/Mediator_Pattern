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
    public class GetStaffgetbyIdHandler : IRequestHandler<StaffGetByIdQuery, StaffModel>
    {
        private readonly IStaffRepo _employeeRepo;

        public GetStaffgetbyIdHandler(IStaffRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<StaffModel> Handle(StaffGetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetStaffId(request.STAFF_ID);
        }   
    }
}
