namespace ExDto.Models
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Firstname { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
