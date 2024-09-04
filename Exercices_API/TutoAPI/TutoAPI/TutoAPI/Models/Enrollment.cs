using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TutoAPI.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Grade? Grade { get; set; }

        [ForeignKey("CourseId")]
        [JsonIgnore]
        public virtual Course? Course { get; set; }

        [ForeignKey("StudentId")]
        [JsonIgnore]
        public virtual Student? Student { get; set; }
    }
}
