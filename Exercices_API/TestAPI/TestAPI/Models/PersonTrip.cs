using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestAPI.Models
{
    [PrimaryKey(nameof(PersonId), nameof(TripId))]
    public class PersonTrip
    {
        public int PersonId { get; set; }

        public int TripId { get; set; }

        [Required]
        public bool IsDriver { get; set; }
    }
}