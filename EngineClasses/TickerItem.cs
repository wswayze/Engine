using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    public class TickerItem
    {
        protected string tickerSymbol = "";
        protected int tickerVolume = 0;
        protected decimal tickerPrice = 0.0000m;
        protected DateTime tickerTime = DateTime.Now;

        public TickerItem()
        { }

        public TickerItem(int Volume, decimal Price, DateTime Time)
        {
            tickerVolume = Volume;
            tickerPrice = Price;
            tickerTime = Time;
        }

        public TickerItem(string Symbol, int Volume, decimal Price, DateTime Time)
        {
            tickerSymbol = Symbol;
            tickerVolume = Volume;
            tickerPrice = Price;
        }

        public string TickerSymbol
        {
            get { return tickerSymbol; }
            set { tickerSymbol = value; }
        }

        public int TickerVolume
        {
            get { return tickerVolume; }
            set { tickerVolume = value; }
        }

        public decimal TickerPrice
        {
            get { return tickerPrice; }
            set { tickerPrice = value; }
        }

        public DateTime TickerTime
        {
            get { return tickerTime; }
            set { tickerTime = value; }
        }
    }
}
