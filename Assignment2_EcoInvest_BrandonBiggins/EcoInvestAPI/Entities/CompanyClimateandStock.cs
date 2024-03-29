using System.ComponentModel.DataAnnotations;

namespace EcoInvestAPI.Entities
{
    public class CompanyClimateandStock
    {
        [Key]
        public int CompanyID { get; set; }
        public int StockDataID { get; set; }
        public int ClimateDataID { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateValue { get; set; }
        public float HighTemperature { get; set; }
        public float LowTemperature { get; set; }
        public float AvgTemperature { get; set; }
        public float Precipatation { get; set; }
        public float OpeningPrice { get; set; }
        public float ClosingPrice { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public int Volume { get; set; }
    }
}
