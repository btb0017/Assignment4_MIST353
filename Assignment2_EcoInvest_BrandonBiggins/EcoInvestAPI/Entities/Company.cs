using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string CompanyStreet { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyCountry { get; set; }

        public string CompanyZip { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyLatitude { get; set; }

        public string CompanyLongitude { get; set; }

        public string CompanyWebsite { get; set; }

        public int CompanyClimateRating { get; set; }
    }
}
