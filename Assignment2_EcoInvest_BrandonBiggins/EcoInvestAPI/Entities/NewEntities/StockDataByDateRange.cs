namespace EcoInvestAPI.Entities.NewEntities
{
    public class StockDataByDateRange
    {
        
        public string ?CompanyName { get; set; }
        public DateTime DateValue { get; set; }
        public double OpeningPrice { get; set; }
        public double ClosingPrice { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public int Volume { get; set; }
    }
}
