using System.ComponentModel.DataAnnotations;

namespace Abc.Data
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]{2,3}$")]
        public string Code { get; set; }  // ISO country code (e.g., US, USA)

        [StringLength(100)]
        public string Capital { get; set; }

        [Range(0, long.MaxValue)]
        public long Population { get; set; }

        [DataType(DataType.Date)]
        public DateOnly IndependenceDate { get; set; }
    }
}
