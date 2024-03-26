using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class ClimateData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClimateDataID { get; set; }

        [ForeignKey("Company")]
        [Required]
        public int CompanyID { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateValue { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double HighTemperature { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double LowTemperature { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double AvgTemperature { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Precipitation { get; set; }
    }
}
