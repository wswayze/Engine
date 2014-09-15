using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    /// <summary>
    /// CandlestickPattern applies on top of CandlestickMetrics and Candlestick management
    /// of patterns for this candlestick.
    /// </summary>
    public class CandlestickPattern : CandlestickMetrics
    {
        protected Patterns pat = Patterns.Unassigned;
        protected Trends marketTrend = Trends.Unassigned;
        protected PatternCategories patCategory = PatternCategories.Unassigned;
        
        public Patterns Pattern
        {
            get { return pat; }
            set 
            { 
                pat = value;
                patCategory = GetPatternCategoryForPattern(pat);
            }
        }

        public Trends MarketTrend
        {
            get { return marketTrend; }
            set { marketTrend = value; }
        }

        public PatternCategories PatternCategory
        {
            get { return patCategory; }
        }


        public CandlestickPattern()
        { }

        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low) :
            base(Open, Close, High, Low)
        {

        }

        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low, Trends Trend) :
            base(Open, Close, High, Low)
        {
            marketTrend = Trend;
        }
        
        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low, Trends Trend, Patterns Pattern) :
            base(Open, Close, High, Low)
        {
            marketTrend = Trend;
            pat = Pattern;
            patCategory = GetPatternCategoryForPattern(pat);
        }

        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low, int Vol) :
            base(Open, Close, High, Low, Vol)
        {

        }

        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low, int Vol, Trends Trend) :
            base(Open, Close, High, Low, Vol)
        {
            marketTrend = Trend;
        }

        public CandlestickPattern(decimal Open, decimal Close, decimal High, decimal Low, int Vol, Trends Trend, Patterns Pattern) :
            base(Open, Close, High, Low, Vol)
        {
            marketTrend = Trend;
            pat = Pattern;
            patCategory = GetPatternCategoryForPattern(pat);
        }

        public PatternCategories GetPatternCategoryForPattern(Patterns APattern)
        {
            PatternCategories returnValue = PatternCategories.Unassigned;

            switch (APattern)
            {
                case Patterns.Hammer:
                    returnValue = PatternCategories.Reversal;
                    break;
                case Patterns.HangingMan:
                    returnValue = PatternCategories.Reversal;
                    break;
                default:
                    returnValue = PatternCategories.Unassigned;
                    break;
            }

            return returnValue;
        }
    }
}
