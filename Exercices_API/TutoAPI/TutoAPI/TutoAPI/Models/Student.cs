using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TutoAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string? Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string? Firstname { get; set; }

        public DateTime EnrollmentDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
