using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    /// <summary>
    /// CandelstickMetrics calculates basic metrics used for Candelstick evaluations.
    /// </summary>
    public class CandlestickMetrics : Candlestick
    {
        protected decimal candleSpread = 0.0000m;
        protected decimal realBodySpread = 0.0000m;
        protected decimal lowerShadowRealBodyPercentage = 0.0000m;
        protected decimal upperShadowRealBodyPercentage = 0.0000m;
        protected decimal upperShadowCandlePercentage = 0.0000m;
        protected decimal realBodyAsSpread = 0.0000m;
        protected int volume = 0;

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public CandlestickMetrics()
        { }

        /// <summary>
        /// Uses the Candelstick standard constructor.
        /// </summary>
        /// <param name="Open">Open price.</param>
        /// <param name="Close">Close price.</param>
        /// <param name="High">High price.</param>
        /// <param name="Low">Low price.</param>
        public CandlestickMetrics(decimal Open, decimal Close, decimal High, decimal Low) :
            base(Open, Close, High, Low)
        {
            SetRealBodySpread();
            SetUpperShadowRealBodyPercentage();
            SetLowerShadowRealBodyPercentage();
            SetCandelSpread();
            SetUpperShadowCandlePercentage();
        }

        /// <summary>
        /// Uses the Candelstick standard constructor plus adds the volume.
        /// </summary>
        /// <param name="Open">Open price.</param>
        /// <param name="Close">Close price.</param>
        /// <param name="High">High price.</param>
        /// <param name="Low">Low price.</param>
        /// <param name="Vol">Volume.</param>
        public CandlestickMetrics(decimal Open, decimal Close, decimal High, decimal Low, int Vol) :
            base(Open, Close, High, Low)
        {
            volume = Vol;
            SetRealBodySpread();
            SetUpperShadowRealBodyPercentage();
            SetLowerShadowRealBodyPercentage();
            SetCandelSpread();
            SetUpperShadowCandlePercentage();
        }

        /// <summary>
        /// SetRealBodySpread calulates the RealBodySpread.
        /// </summary>
        protected void SetRealBodySpread()
        {
            if (realBody == RealBodyColor.White)
            {
                realBodySpread = closePrice - openPrice;
            }
            else
            {
                realBodySpread = openPrice - closePrice;
            }
        }

        /// <summary>
        /// The value of the real body.
        /// </summary>
        public decimal RealBodySpread
        {
            get { return realBodySpread; }
        }

        /// <summary>
        /// SetCandelSpread calculates the value of the entire candle.
        /// </summary>
        protected void SetCandelSpread()
        { candleSpread = highPrice - lowPrice; }

        /// <summary>
        /// The value of the candle.
        /// </summary>
        public decimal CandelSpread
        {
            get { return candleSpread; }
            // No set available.
        }

        /// <summary>
        /// Calculates the ratio between the LowerShadow to the real body value.
        /// </summary>
        protected void SetLowerShadowRealBodyPercentage()
        {
            if(realBodySpread != 0)
                lowerShadowRealBodyPercentage = lowerShadow / realBodySpread;
        }

        /// <summary>
        /// The ratio of the lower shadow to the real body value.
        /// </summary>
        public decimal LowerShadowRealBodyPercentage
        {
            get { return lowerShadowRealBodyPercentage; }
            // No set available.
        }

        /// <summary>
        /// Calculate the ratio of the upper shadow to the real body value.
        /// </summary>
        protected void SetUpperShadowRealBodyPercentage()
        {
            if(realBodySpread != 0)
                upperShadowRealBodyPercentage = upperShadow / realBodySpread;
        }

        /// <summary>
        /// The ratio of the upper shodow to the real body value.
        /// </summary>
        public decimal UpperShadowRealBodyPercentage
        {
            get { return upperShadowRealBodyPercentage; }
            // No set available.
        }

        /// <summary>
        /// The volume of units being sold.
        /// </summary>
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        protected void SetUpperShadowCandlePercentage()
        {
            if(candleSpread != 0)
                upperShadowCandlePercentage = upperShadow / candleSpread;
        }

        public decimal UpperShadowCandlePercentage
        {
            get { return upperShadowCandlePercentage; }
            set { upperShadowCandlePercentage = value; }
        }
    }
}
