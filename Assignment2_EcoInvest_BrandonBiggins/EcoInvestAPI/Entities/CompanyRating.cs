using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class CompanyRatings
    {
        [Key]
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public int CompanyClimateRating { get; set; }
    }
}
