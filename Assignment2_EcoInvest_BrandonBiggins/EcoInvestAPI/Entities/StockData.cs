using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class StockData
    {
        public int StockDataID { get; set; }

        public int CompanyID { get; set; }

        public DateTime DateValue { get; set; }

        public double OpeningPrice { get; set; }

        public double ClosingPrice { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public int Volume { get; set; }
    }
}
