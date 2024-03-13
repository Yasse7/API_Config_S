using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IStudentrepository
    {
        List<StudentEntity> GetAll(CancellationToken cancellationToken);
        bool CreateStudent(StudentEntity student , CancellationToken cancellationToken);
    }
}
