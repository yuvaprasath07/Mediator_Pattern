using CRUD_Operation.DataBase;
using CRUD_Operation.Model;
using CRUD_Operation.Repositery.Interface;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operation.Repositery.Service
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DataConnection _context;

        public EmployeeRepo(DataConnection context)
        {
            _context = context;
        }

        public async Task<EmployeModel> AddEmployee(EmployeModel employee)
        {
            var data = _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<int> DeleteEmployee(int employeeId)
        {
            var filterdata = _context.Employee.Where(a => a.EmployeeId == employeeId).FirstOrDefault();
            _context.Remove(filterdata);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<EmployeModel>> GetEmploye()
        {
            var data = await _context.Employee.ToListAsync();
            return data;
        }

        public async Task<EmployeModel> GetEmployeeId(int employeeId)
        {
            var findData = await _context.Employee.Where(a => a.EmployeeId == employeeId).FirstOrDefaultAsync();
            return findData;
        }

        public async Task<int> UpdateEmployee(EmployeModel employee)
        {
            _context.Employee.Update(employee);
            return await _context.SaveChangesAsync();
        }
    }
}