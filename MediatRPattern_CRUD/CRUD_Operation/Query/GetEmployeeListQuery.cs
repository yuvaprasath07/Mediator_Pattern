using CRUD_Operation.Model;
using MediatR;

namespace CRUD_Operation.Query
{
    public class GetEmployeeListQuery : IRequest<List<EmployeModel>>
    {

    }
}