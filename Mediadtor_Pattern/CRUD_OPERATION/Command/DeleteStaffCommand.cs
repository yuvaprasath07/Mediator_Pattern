using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Command
{
    public class DeleteStaffCommand : IRequest<int>
    {
        public int STAFF_ID { get; set; }
    }
}
