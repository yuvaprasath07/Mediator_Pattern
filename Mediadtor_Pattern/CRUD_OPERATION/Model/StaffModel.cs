using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Model
{
    public class StaffModel
    {
        [Key]
        public int STAFF_ID { get; set; }
        public string? NAME { get; set; }
        public int AGE { get; set; }
        public string? DEPARTMENT { get; set; }
    }
}
