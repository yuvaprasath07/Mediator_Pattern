using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Command
{
    public class UpdateStaffCommand : IRequest<int>
    {
        public int STAFF_ID { get; set; }
        public string? NAME { get; set; }
        public int AGE { get; set; }
        public string? DEPARTMENT { get; set; }
        public UpdateStaffCommand(int staffid, string name, int age, string department)
        {
            STAFF_ID = staffid;
            NAME = name;
            AGE = age;
            DEPARTMENT = department;
        }
    }
}
