using CRUD_Operation.Command;
using CRUD_Operation.Model;
using CRUD_Operation.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPattern_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("get")]
        public async Task<List<EmployeModel>> GetEmployeeListAsync()
        {
            var EmployeeDetails = await mediator.Send(new GetEmployeeListQuery());

            return EmployeeDetails;
        }

        [HttpGet("EmployeeId")]
        public async Task<EmployeModel> GetEmployeeByIdAsync(int studentId)
        {
            var EmployeDetails = await mediator.Send(new GetEmployeeByIdQuery() { EmployeeId = studentId });

            return EmployeDetails;
        }

        [HttpPost]
        public async Task<EmployeModel> AddStudentAsync(EmployeModel EmployeeDetails)
        {
            var studentDetail = await mediator.Send(new CreateEmployeeCommand(
                EmployeeDetails.EmployeeId,
                EmployeeDetails.FirstName,
                EmployeeDetails.LastName,
                EmployeeDetails.Age,
                EmployeeDetails.Department
                ));
            return studentDetail;
        }

        [HttpPut]
        public async Task<int> UpdateStudentAsync(EmployeModel EmployeDetails)
        {
            var isEmployeeDetailUpdated = await mediator.Send(new UpdateEmployeeCommand(
               EmployeDetails.EmployeeId,
               EmployeDetails.FirstName,
               EmployeDetails.LastName,
               EmployeDetails.Age,
               EmployeDetails.Department));
            return isEmployeeDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await mediator.Send(new DeleteEmployeeCommand() { EmployeeId = Id });
        }
    }
}