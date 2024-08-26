using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    public class City
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("city_zipcode")]
        public string CityZipCode { get; set; }

        [Column("city_name")]
        public string CityName { get; set; }

        [ForeignKey("Country")]
        [Column("country_id")]
        public int CountryId { get; set; }

        [JsonIgnore]
        public Country? Country { get; set; }

    }
}
