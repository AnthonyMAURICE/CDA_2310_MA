using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    [PrimaryKey(nameof(StudentId), nameof(ClassesId))]
    public class ClassesStudents
    {
        public int StudentId { get; set; }

        public int ClassesId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(StudentId))]
        public virtual  Student? Student { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ClassesId))]
        public virtual Classes? Classes { get; set; }
    }
}
