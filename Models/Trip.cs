using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;

namespace BrightwayCodeTest.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Required, Display(Name = "Email")]
        public string? UserEmail { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required]
        public string? Destination { get; set; }

        [Range(0, 365), Required, Display(Name = "Duration of Trip (Days)")]
        public int Duration { get; set; }

        [Column(TypeName = "decimal(18, 2)"), Display(Name = "$ USD")]
        public decimal Currency { get; set; }

        [Display(Name = "Converted Currency"), Column(TypeName = "decimal(18, 2)")]
        public decimal ConvertedCurrency { get; set; }
    }
}
