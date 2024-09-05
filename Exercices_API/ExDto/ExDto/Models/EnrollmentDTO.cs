using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public class EnrollmentDTO
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }


        public int StudentID { get; set; }


        public Grade? Grade { get; set; }

    }

    public class EnrollmentDetailedDTO
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }


        public int StudentID { get; set; }


        public Grade? Grade { get; set; }


        public Course? Course { get; set; }


        public Student? Student { get; set; }
    }
}
