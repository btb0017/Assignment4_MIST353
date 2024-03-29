using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class ClimateData
    {
        public int ClimateDataID { get; set; }

        public int CompanyID { get; set; }

        public DateTime DateValue { get; set; }

        public double HighTemperature { get; set; }

        public double LowTemperature { get; set; }

        public double AvgTemperature { get; set; }

        public double Precipitation { get; set; }
    }
}
