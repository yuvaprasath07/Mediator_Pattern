using CRUD_OPERATION.Command;
using CRUD_OPERATION.Model;
using CRUD_OPERATION.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediadtor_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IMediator mediator;

        public StaffController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("StaffGet")]
        public async Task<List<StaffModel>> GetStaffListAsync()
        {
            var EmployeeDetails = await mediator.Send(new StaffListQuery());

            return EmployeeDetails;
        }

        [HttpGet("StaffId")]
        public async Task<StaffModel> GetStaffIdAsync(int staffid)
        {
            var EmployeDetails = await mediator.Send(new StaffGetByIdQuery() { STAFF_ID = staffid });

            return EmployeDetails;
        }

        [HttpPost("StaffCreate")]
        public async Task<StaffModel> AddStudentAsync(StaffModel StaffDetails)
        {
            var studentDetail = await mediator.Send(new CreateStaffCommand(
                StaffDetails.STAFF_ID,
                StaffDetails.NAME,
                StaffDetails.AGE,
                StaffDetails.DEPARTMENT
                ));
            return studentDetail;
        }
        [HttpPut("StaffUpdate")]
        public async Task<int> UpdateStudentAsync(StaffModel EmployeDetails)
        {
            var isEmployeeDetailUpdated = await mediator.Send(new UpdateStaffCommand(
               EmployeDetails.STAFF_ID,
               EmployeDetails.NAME,
               EmployeDetails.AGE,
               EmployeDetails.DEPARTMENT));

            return isEmployeeDetailUpdated;
        }
        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await mediator.Send(new DeleteStaffCommand() { STAFF_ID = Id });
        }
    }
}
