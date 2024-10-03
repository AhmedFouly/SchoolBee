using Microsoft.EntityFrameworkCore;
using SchoolBee.Domain.Models;
using SchoolBee.Infrastructure.Contracts;
using SchoolBee.Infrastructure.Data;

namespace SchoolBee.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
