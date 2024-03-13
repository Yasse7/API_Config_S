using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Students.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Students
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, bool>
    {
        public readonly IStudentrepository _studentrepository;
        public CreateStudentCommandHandler(IStudentrepository studentrepository)
        {
            _studentrepository = studentrepository;
        }
        public Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //validation 
            //automapper
            var student = new StudentEntity
            {
                id = request.Id,
                name = request.Name,
                Age = request.Age
            };

            var result = _studentrepository.CreateStudent(student, cancellationToken);
            return Task.FromResult(result);

        }
    }
}
