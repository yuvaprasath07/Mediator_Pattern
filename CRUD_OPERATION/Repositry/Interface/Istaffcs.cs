using CRUD_OPERATION.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Repositry.Interface
{
    public interface Istaffcs
    {
        public Task<List<StaffModel>> GetEmploye();
        //public Task<StaffModel> GetEmployeeId(int staffId);
        //public Task<StaffModel> AddEmployee(StaffModel staff);
        //public Task<int> UpdateEmployee(StaffModel staff);
        //public Task<int> DeleteEmployee(int staffId);
    }
}
