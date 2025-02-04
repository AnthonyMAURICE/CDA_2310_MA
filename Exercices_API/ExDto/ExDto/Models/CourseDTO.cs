using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public class CourseDTO
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
