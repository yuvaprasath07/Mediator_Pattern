using CRUD_OPERATION.Model;
using CRUD_OPERATION.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator.Controllers
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
        [HttpGet("get")]
        public async Task<List<StaffModel>> GetEmployeeListAsync()
        {
            var EmployeeDetails = await mediator.Send(new GetStaffListQuery());

            return EmployeeDetails;
        }
    }
}
