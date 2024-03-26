using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyStreet { get; set; }

        [Required]
        public string CompanyCity { get; set; }

        [Required]
        public string CompanyState { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyCountry { get; set; }

        [Required]
        [StringLength(10)]
        public string CompanyZip { get; set; }

        [Required]
        public string CompanyEmail { get; set; }

        [Required]
        public string CompanyLatitude { get; set; }

        [Required]
        public string CompanyLongitude { get; set; }

        [Required]
        public string CompanyWebsite { get; set; }

        [Required]
        public int CompanyClimateRating { get; set; }
    }
}
