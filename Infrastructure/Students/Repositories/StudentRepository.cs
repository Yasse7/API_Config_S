using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Students.Repositories
{
    public class StudentRepository : IStudentrepository
    {
        private List<StudentEntity> _students = new List<StudentEntity>
            {
                new StudentEntity { id =1, name = "Hamza", Age =30 },
                new StudentEntity { id =1, name = "Imad", Age =22 },
                new StudentEntity { id =1, name = "Yasser", Age =22 },
                new StudentEntity { id =1, name = "Abdelemalk", Age =23 },

            };

        public StudentEntity CreateStudent(StudentEntity student, CancellationToken cancellationToken)
        {
            _students.Add(student);
            return student; 
        }

        public List<StudentEntity> GetAll(CancellationToken cancellationToken)
        {
            return _students;
        }

    }
}
