using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebMVC_0506.Data.Models
{
    public class Student
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string FirstMidName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
