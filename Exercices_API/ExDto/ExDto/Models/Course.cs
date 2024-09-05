using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [JsonIgnore]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }

    }
}
