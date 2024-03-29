using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace EcoInvestAPI.Entities
{
    public class CompanyClimateData
    {
        [Key]
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateValue { get; set; }
        public decimal HighTemperature { get; set; }
        public decimal LowTemperature { get; set; }
        public decimal AvgTemperature { get; set; }
        public decimal Precipitation { get; set; }
    }
}
