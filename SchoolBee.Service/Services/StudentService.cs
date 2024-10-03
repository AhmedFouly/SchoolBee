using SchoolBee.Domain.Models;
using SchoolBee.Infrastructure.Contracts;
using SchoolBee.Service.Contracts;

namespace SchoolBee.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsAsync();
        }
    }
}
