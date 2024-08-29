﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    [ReadOnly(true)]
    public class Person
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }

        public bool IsDriver { get; set; }

        [JsonIgnore]
        public ICollection<Trip>? TripList { get; }
    }
}
