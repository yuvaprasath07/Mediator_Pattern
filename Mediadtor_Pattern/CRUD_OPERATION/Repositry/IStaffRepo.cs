using CRUD_OPERATION.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Repositry
{
    public interface IStaffRepo
    {
        public Task<List<StaffModel>> GetStaff();
        public Task<StaffModel> GetStaffId(int StaffId);
        public Task<StaffModel> Addstaff(StaffModel employee);
        public Task<int> UpdateStaff(StaffModel employee);
        public Task<int> DeleteEmployee(int employeeId);
    }
}
