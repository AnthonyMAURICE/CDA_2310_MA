using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    [Table("continent")]
    public class Continent
    {
        [Key]
        [Column("continent_id")]
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage ="Nom trop long, 20 caractères maximum")]
        [MinLength(2, ErrorMessage ="Nom trop court, 2 caractères minimum")]
        [Column("continent_name")]
        public string ContinentName { get; set; }

        [Column("continent_area")]
        public int ContinentArea { get; set; }

        [JsonIgnore]
        public ICollection<Country>? Countries { get; set; }
    }
}
