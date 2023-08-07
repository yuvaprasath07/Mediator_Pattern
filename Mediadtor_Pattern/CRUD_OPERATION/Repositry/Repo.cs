using CRUD_OPERATION.DataBase;
using CRUD_OPERATION.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Repositry
{
    public class Repo: IStaffRepo
    {
        private readonly DataConnection _context;

        public Repo(DataConnection context)
        {
            _context = context;
        }

        public async Task<StaffModel> Addstaff(StaffModel employee)
        {
            var data = _context.STAFF_DETAILS.Add(employee);
            await _context.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<List<StaffModel>> GetStaff()
        {
            var data = await _context.STAFF_DETAILS.ToListAsync();
            return data;
        }

        public async Task<StaffModel> GetStaffId(int StaffId)
        {
            var findData = await _context.STAFF_DETAILS.Where(a => a.STAFF_ID == StaffId).FirstOrDefaultAsync();
            return findData;
        }

        public async Task<int> UpdateStaff(StaffModel employee)
        {
            _context.STAFF_DETAILS.Update(employee);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteEmployee(int employeeId)
        {
            var filterdata = _context.STAFF_DETAILS.Where(a => a.STAFF_ID == employeeId).FirstOrDefault();
            _context.Remove(filterdata);
            return await _context.SaveChangesAsync();
        }
    }
}
