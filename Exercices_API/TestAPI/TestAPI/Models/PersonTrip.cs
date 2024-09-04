using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestAPI.Models
{
    [PrimaryKey(nameof(PersonId), nameof(TripId))]
    public class PersonTrip
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [ForeignKey("Trip")]
        public int TripId { get; set; }

        [Required]
        public bool IsDriver { get; set; }

        public virtual Trip? Trip { get; set; }

        public virtual Person? Person { get; set; }

        
    }
}