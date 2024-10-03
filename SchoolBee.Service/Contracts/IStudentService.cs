using SchoolBee.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBee.Service.Contracts
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
