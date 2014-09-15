using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    public class CandlestickHeader
    {
        protected string ticker = "";
        protected DateTime periodStart = DateTime.Now;
        protected DateTime periodEnd = DateTime.Now;

        public CandlestickHeader()
        { }

        public CandlestickHeader(string Symbol)
        {
            ticker = Symbol;
        }

        public CandlestickHeader(DateTime Starting, DateTime Ending)
        {
            periodStart = Starting;
            periodEnd = Ending;
        }

        public CandlestickHeader(string Symbol, DateTime Starting, DateTime Ending)
        {
            ticker = Symbol;
            periodStart = Starting;
            periodEnd = Ending;
        }

        public string Ticker
        {
            get { return ticker; }
            set { ticker = value; }
        }

        public DateTime PeriodStart
        {
            get { return periodStart; }
            set { periodStart = value; }
        }

        public DateTime PeriodEnd
        {
            get { return periodEnd; }
            set { periodEnd = value; }
        }
    }
}
