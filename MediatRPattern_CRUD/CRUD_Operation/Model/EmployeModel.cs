﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_Operation.Model
{
    public class EmployeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}