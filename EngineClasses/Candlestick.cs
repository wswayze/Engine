using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    /// <summary>
    /// Candelstick base object.
    /// </summary>
    public class Candlestick
    {
        protected RealBodyColor realBody = RealBodyColor.Unassigned;
        protected decimal openPrice = 0.0000m;
        protected decimal closePrice = 0.0000m;
        protected decimal highPrice = 0.0000m;
        protected decimal lowPrice = 0.0000m;
        protected decimal upperShadow = 0.0000m;
        protected decimal lowerShadow = 0.0000m;
        protected CandlestickHeader header = new CandlestickHeader();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Candlestick()
        { }

        /// <summary>
        /// Basic Candlestick constructor.
        /// </summary>
        /// <param name="Open">Open price.</param>
        /// <param name="Close">Close price.</param>
        /// <param name="High">High price.</param>
        /// <param name="Low">Low price.</param>
        public Candlestick(decimal Open, decimal Close, decimal High, decimal Low)
        {
            OpenPrice = Open;
            ClosePrice = Close;
            HighPrice = High;
            LowPrice = Low;
        }

        /// <summary>
        /// Full Candlestick constructor.
        /// </summary>
        /// <param name="Symbol">The entity ticker symbol.</param>
        /// <param name="Starting">The Candlestick period start time.</param>
        /// <param name="Ending">The Candlestick period end time.</param>
        /// <param name="Open">Open price.</param>
        /// <param name="Close">Close price.</param>
        /// <param name="High">High price.</param>
        /// <param name="Low">Low price.</param>
        public Candlestick(string Symbol, DateTime Starting, DateTime Ending, decimal Open, decimal Close, decimal High, decimal Low)
        {
            OpenPrice = Open;
            ClosePrice = Close;
            HighPrice = High;
            LowPrice = Low;
            header.Ticker = Symbol;
            header.PeriodStart = Starting;
            header.PeriodEnd = Ending;
        }

        /// <summary>
        /// The Candlestick header information with ticker symbol and period start and close times.
        /// </summary>
        public CandlestickHeader Header
        {
            get { return header; }
            set { header = value; }
        }

        /// <summary>
        /// The ticker symbol of the entity the candlestick is representing.
        /// </summary>
        public string Ticker
        {
            get { return header.Ticker; }
            set { header.Ticker = value; }
        }

        /// <summary>
        /// This period's start time for the candlestick.
        /// </summary>
        public DateTime PeriodStart
        {
            get { return header.PeriodStart; }
            set { header.PeriodStart = value; }
        }

        /// <summary>
        /// This period's end time for the candlestick.
        /// </summary>
        public DateTime PeriodEnd
        {
            get { return header.PeriodEnd; }
            set { header.PeriodEnd = value; }
        }

        /// <summary>
        /// RealBoday states if the candlestick is white or black.
        /// </summary>
        public RealBodyColor RealBody
        {
            get { return realBody; }
            // No set available.
        }

        /// <summary>
        /// OpenPrice is the open price for the candlestick period.
        /// </summary>
        public decimal OpenPrice
        {
            get { return openPrice; }
            set 
            { 
                openPrice = value;
                SetRealBody();
            }
        }

        /// <summary>
        /// ClosePrice is the close price for the candlestick period.
        /// </summary>
        public decimal ClosePrice
        {
            get { return closePrice; }
            set 
            { 
                closePrice = value;
                SetRealBody();
            }
        }

        /// <summary>
        /// HighPrice is the highest price for the candlestick period.
        /// </summary>
        public decimal HighPrice
        {
            get { return highPrice; }
            set 
            { 
                highPrice = value;
                SetUpperShadow();
                //SetLowerShadow();
            }
        }

        /// <summary>
        /// LowPrice is the lowest price for the candlestick period.
        /// </summary>
        public decimal LowPrice
        {
            get { return lowPrice; }
            set 
            { 
                lowPrice = value;
                //SetUpperShadow();
                SetLowerShadow();
            }
        }

        protected void SetRealBody()
        {
            if (closePrice > openPrice)
            {
                realBody = RealBodyColor.White;
            }
            else
            {
                realBody = RealBodyColor.Black;
            }
        }

        protected void SetUpperShadow()
        {
            if (realBody == RealBodyColor.White)
            {
                upperShadow = highPrice - closePrice;
            }

            if (realBody == RealBodyColor.Black)
            {
                upperShadow = highPrice - openPrice;
            }
        }

        /// <summary>
        /// UpperShadow is the size of the candlestick upper shadow.
        /// </summary>
        public decimal UpperShadow
        {
            get { return upperShadow; }
            // No set available.
        }

        /// <summary>
        /// LowerShadow is the size of the candlestick lower shadow.
        /// </summary>
        public decimal LowerShadow
        {
            get { return lowerShadow; }
            // No set available.
        }

        protected void SetLowerShadow()
        {
            if (realBody == RealBodyColor.White)
            {
                lowerShadow = openPrice - lowPrice;
            }

            if (realBody == RealBodyColor.Black)
            {
                lowerShadow = closePrice - lowPrice;
            }
        }
    }
}
