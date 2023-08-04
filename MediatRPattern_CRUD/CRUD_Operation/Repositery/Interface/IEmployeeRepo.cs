using CRUD_Operation.Model;

namespace CRUD_Operation.Repositery.Interface
{
    public interface IEmployeeRepo
    {
        public Task<List<EmployeModel>> GetEmploye();
        public Task<EmployeModel> GetEmployeeId(int employeeId);
        public Task<EmployeModel> AddEmployee(EmployeModel employee);
        public Task<int> UpdateEmployee(EmployeModel employee);
        public Task<int> DeleteEmployee(int employeeId);
    }
}