using ExDto.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }


    public class Enrollment {

        [Key]
        public int EnrollmentID { get; set; }

        [Required]
        public int CourseID { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Required]
        public Grade? Grade { get; set; }

        [ForeignKey("CourseID")]
        [JsonIgnore]
        public virtual Course? Course { get; set; }

        [ForeignKey("StudentID")]
        [JsonIgnore]
        public virtual Student? Student { get; set; }
    }
}