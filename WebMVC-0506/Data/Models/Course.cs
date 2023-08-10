using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC_0506.Data.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
