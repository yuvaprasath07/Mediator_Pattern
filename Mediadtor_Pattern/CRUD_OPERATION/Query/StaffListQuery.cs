using CRUD_OPERATION.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Query
{
    public class StaffListQuery : IRequest<List<StaffModel>>
    {
    }
}
