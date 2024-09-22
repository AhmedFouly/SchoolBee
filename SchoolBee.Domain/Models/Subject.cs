using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBee.Domain.Models
{
    public class Subject
    {
        public Subject()
        {
            StudentsSubjects = new HashSet<StudentSubject>();
            DepartmetsSubjects = new HashSet<DepartmentSubject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }

        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmetsSubjects { get; set; }
    }
}
