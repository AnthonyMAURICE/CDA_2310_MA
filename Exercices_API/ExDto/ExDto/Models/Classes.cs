using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExDto.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Student>? Students { get; set; }
    }
}
