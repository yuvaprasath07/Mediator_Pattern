using CRUD_Operation.Model;
using CRUD_Operation.Query;
using CRUD_Operation.Repositery.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Handler
{
    public class GetEmployeeListHandler:IRequestHandler<GetEmployeeListQuery, List<EmployeModel>>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public GetEmployeeListHandler(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<List<EmployeModel>> Handle(GetEmployeeListQuery query,CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetEmploye();
        }
    }
}
