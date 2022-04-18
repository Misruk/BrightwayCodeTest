using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;

namespace BrightwayCodeTest.Models
{
    public class Trip
    {
        [Display(Name = "Invoice Number")]
        public int TripId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, Display(Name = "User Name")]
        public string? UserName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"), Required, Display(Name = "Email")]
        public string? UserEmail { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, Display(Name = "Travel Destination")]
        public string? Destination { get; set; }

        [Range(0, 365), Required, Display(Name = "Duration of Trip in Days")]
        public int Duration { get; set; }

        [Column(TypeName = "decimal(18, 2)"), Display(Name = "$ USD")]
        public decimal Currency { get; set; }

        [Display(Name = "Needed Native Currency"), Column(TypeName = "decimal(18, 2)")]
        public decimal ConvertedCurrency { get; set; }
    }
}
