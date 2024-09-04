using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TutoAPI.Models
{
    public class EnrollmenntDTO
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Grade? Grade { get; set; }

        public virtual Course? Course { get; set; }

        public virtual Student? Student { get; set; }
    }
}
