using CRUD_OPERATION.Model;
using CRUD_OPERATION.Query;
using CRUD_OPERATION.Repositry.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Handler
{
    public class GetStaffHandler : IRequestHandler<GetStaffListQuery, List<StaffModel>>
    {
        private readonly Istaffcs _istaffcs;
        public GetStaffHandler(Istaffcs istaffcs)
        {
            _istaffcs = istaffcs;
        }

        public async Task<List<StaffModel>> Handle(GetStaffListQuery request, CancellationToken cancellationToken)
        {
            return await _istaffcs.GetEmploye();
        }
    }
}
