using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBee.Domain.Models
{
    public class DepartmentSubject
    {
        [Key]
        public int DeptartmentSubjectId { get; set; }
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; }
    }
}
