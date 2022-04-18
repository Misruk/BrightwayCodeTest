using System.ComponentModel.DataAnnotations;

namespace BrightwayCodeTest.Models
{
    public class CountryList
    {
        [Key]
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? CurrencyName { get; set; }
    }
}
