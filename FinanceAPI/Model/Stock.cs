using System;
namespace FinanceAPI.Model
{
    public class Stock
    {
        public DateTime Date { get; set; }

        public string Ticker { get; set; }

        public double LastPrice { get; set; }
    }
}
