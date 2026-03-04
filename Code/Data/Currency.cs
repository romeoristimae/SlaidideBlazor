using System.ComponentModel.DataAnnotations;

namespace Abc.Soft.Movie.Models
{
    public class Currency
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }  // e.g., Dollar

        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]{3}$")]
        public string Code { get; set; }  // ISO currency code (e.g., USD)

        [Required]
        [StringLength(5)]
        public string Symbol { get; set; }  // e.g., $
    }
}
