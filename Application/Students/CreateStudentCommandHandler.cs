using Application.Students.Model;
using AutoMapper;
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
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentrepository _studentrepository;
        private readonly IMapper _mapper;
        public CreateStudentCommandHandler(IStudentrepository studentrepository, IMapper mapper)
        {
            _studentrepository = studentrepository;
            _mapper= mapper;
        }
        public Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //validation 
            //automapper
            var student= _mapper.Map<StudentEntity>(request);
            //var student = new StudentEntity
            // {
                //id = request.Id,
               //name = request.Name,
                //Age = request.Age
           // };
            
            var result = _studentrepository.CreateStudent(student, cancellationToken);
            var rs = _mapper.Map<Student>(result);
            return Task.FromResult(rs);

        }
    }
}
