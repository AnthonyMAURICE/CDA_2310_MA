using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    [ReadOnly(true)]
    public class Trip
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime? Arrival { get; set; }

        [ForeignKey("City")]
        public int DepartureCityId { get; set; }

        [ForeignKey("City")]
        public int ArrivalCityId { get; set; }

        [JsonIgnore]
        public ICollection<Person>? Persons { get; }
    }
}
