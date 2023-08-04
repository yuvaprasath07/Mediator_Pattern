using CRUD_Operation.Command;
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
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeModel>
    {
        private readonly IEmployeeRepo _employeeRepo;

        public GetEmployeeByIdHandler(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<EmployeModel> Handle(GetEmployeeByIdQuery query,CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetEmployeeId(query.EmployeeId);
        }
    }
}
