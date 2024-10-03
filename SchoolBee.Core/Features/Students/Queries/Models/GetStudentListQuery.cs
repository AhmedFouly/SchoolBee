using MediatR;
using SchoolBee.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBee.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
