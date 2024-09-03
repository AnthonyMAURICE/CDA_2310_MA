using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    [ReadOnly(true)]
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime? Arrival { get; set; }

        
        public int? DepartureCityId { get; set; }

        public int? ArrivalCityId { get; set; }

        [ForeignKey("ArrivalCityId")]
        public City? CityDeparture { get; set; }

        [ForeignKey("DepartureCityId")]
        public City? CityArrival { get; set; }

        [JsonIgnore]
        public ICollection<Person>? Persons { get; }
    }
}
