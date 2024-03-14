using Application.Students.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Students
{
    public  class CreateStudentCommand : IRequest<Student>
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }
    }
}
