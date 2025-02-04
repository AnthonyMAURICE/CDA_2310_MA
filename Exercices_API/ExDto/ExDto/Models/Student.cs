using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? Firstname { get; set; }

        public DateTime EnrollmentDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }

        [JsonIgnore]
        public virtual ICollection<Classes>? Classes { get; set; }
    }
}
