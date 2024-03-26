using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class StockData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockDataID { get; set; }

        [ForeignKey("Company")]
        [Required]
        public int CompanyID { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateValue { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double OpeningPrice { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double ClosingPrice { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double High { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Low { get; set; }

        [Required]
        public int Volume { get; set; }
    }
}
