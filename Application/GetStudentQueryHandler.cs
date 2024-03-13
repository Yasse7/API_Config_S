using Application.Students.Model;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GetStudentQueryHandler : IRequestHandler<GetStuentsQuery, List<Student>>
    {
        private readonly IStudentrepository _studentRepository;
        private readonly IMapper _mapper;
        public GetStudentQueryHandler(IStudentrepository studentrepository,IMapper mapper)
        {
            _studentRepository = studentrepository;
            _mapper = mapper;

        }

        public async Task<List<Student>> Handle(GetStuentsQuery query, CancellationToken cancellationToken)
        {
            //validation /fluent validation
            //donnees (reposi) : injection de depandance 
            var resultData = _studentRepository.GetAll(cancellationToken);
             
           var students = new List<Student>();
           
            foreach (var student in resultData)
               {
              
           // students.Add(new Student().ToModel(student));
            students.Add(_mapper.Map<Student>(student));
             }
         // List<Student> students = _mapper.Map<List<Student>>(resultData);


            return students;
        }
     //   Task<List<Student>> IRequestHandler<GetStuentsQuery, List<Student>>.Handle(GetStuentsQuery request, CancellationToken cancellationToken)
        //{
           //throw new NotImplementedException();
       //}
    }
}
