using System.ComponentModel.DataAnnotations;

namespace Airline.Web.Dtos
{
    public class FlightDetailUpdateDto
    {
        [Required]
        public string FlightCode { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}