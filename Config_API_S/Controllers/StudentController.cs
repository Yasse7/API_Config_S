using Application;
using Application.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Config_API_S.Controllers
{
    [ApiController]
    [Route("stu")]
    public class StudentController :ControllerBase
    {
        private readonly IMediator _mediator;
      
        public StudentController(IMediator mediator)
        {
            _mediator = mediator; // This is necessary to avoid NullReferenceException
        }

        [HttpGet("students")]
        public async Task<IActionResult> GetStudents(CancellationToken cancellationToken)
        {
            var query = new GetStuentsQuery
            {
            };
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);

        }
        [HttpPost("/student")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand cmd ,CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(cmd, cancellationToken);
            return Ok(result);
        }
    }
}
