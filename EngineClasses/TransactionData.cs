using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    public class TransactionData
    {
        private string symbol;
        private DateTime tradeTimestamp;
        private int units;
        private decimal price;

        public TransactionData()
        {

        }

        public TransactionData(string Symbol, DateTime TradeTimestamp, int Units, decimal Price)
        {
            symbol = Symbol;
            tradeTimestamp = TradeTimestamp;
            units = Units;
            price = Price;

        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public DateTime TradeTimestamp
        {
            get { return tradeTimestamp; }
            set { tradeTimestamp = value; }
        }

        public int Units
        {
            get { return units; }
            set { units = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
