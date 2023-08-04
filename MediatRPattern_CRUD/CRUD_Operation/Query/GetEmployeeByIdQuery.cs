using CRUD_Operation.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Query
{
    public class GetEmployeeByIdQuery:IRequest<EmployeModel>
    {
        public int EmployeeId { get; set; }
    }
}
