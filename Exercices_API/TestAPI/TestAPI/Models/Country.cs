using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    [Index(nameof(CountryCode), IsUnique =true)]
    public class Country
    {

        [Key]
        [Column("country_id")]
        public int Id { get; set; }

        [MaxLength(200, ErrorMessage ="Nom définitivement trop long")]
        [Column("country_name")]
        [Required]
        public string CountryName { get; set; }

        [Column("country_area")]
        public int CountryArea { get; set; }

        [StringLength(2)]
        [Column("country_code")]
        [Required]
        public string CountryCode { get; set; }

        [ForeignKey("Continent")]
        public int ContinentId { get; set; }

        [JsonIgnore]
        public Continent? Continent { get; set; }

        [JsonIgnore]
        public ICollection<City>? Cities { get; set; }
    }
}
