using System.ComponentModel.DataAnnotations;

namespace EcoInvestAPI.Entities
{
    public class CompanyStockData
    {
        public string CompanyName { get; set; }
        public DateTime DateValue { get; set; }
        public decimal OpeningPrice { get; set; }
        public decimal ClosingPrice { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public long Volume { get; set; }
    }
}
