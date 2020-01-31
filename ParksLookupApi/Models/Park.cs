using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        [Range(1, 5, ErrorMessage="Your rating must be between 1 and 5 stars.")]
         public int Rating { get; set; }

    }
}