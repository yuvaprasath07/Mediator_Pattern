using Azure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Command
{
    public class UpdateStaffommand : IRequest<int>
    {
        public int STAFF_ID { get; set; }

        public string? NAME { get; set; }

        public int AGE  {get;set;}

        public string? DEPARTMENT { get; set; }


        public UpdateStaffommand(int staffid, string name, int age, string department)
        {
            staffid = STAFF_ID;
            name = NAME;
            age = AGE;
            department = DEPARTMENT;
           
        }
    }
}
