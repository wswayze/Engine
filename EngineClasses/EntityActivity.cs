using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    /// <summary>
    /// EntityActivity is the base for financial movement.
    /// </summary>
    public class EntityActivity
    {
        protected string identifier = "";
        protected DateTime tradeTimestamp = DateTime.Now;
        protected decimal openPrice = 0m;
        protected decimal closePrice = 0m;
        protected decimal highPrice = 0m;
        protected decimal lowPrice = 0m;
        protected int units = 0;
        protected decimal openCloseSpread = 0m;
        protected decimal highLowSpread = 0m;

        /// <summary>
        /// Identifier is the name, abbreviation, or code of the financial unit.
        /// </summary>
        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        /// <summary>
        /// TradeTimestamp is the timestamp for which this trade or transaction occurred.
        /// </summary>
        public DateTime TradeTimestamp
        {
            get { return tradeTimestamp; }
            set { tradeTimestamp = value; }
        }

        /// <summary>
        /// OpenPrice is the opening price for this trade or transaction.
        /// </summary>
        public decimal OpenPrice
        {
            get { return openPrice; }
            set 
            {
                openPrice = value;
                openCloseSpread = CalculateOpenCloseSpread();
            }
        }

        /// <summary>
        /// ClosePrice is the closing price for this trade or transaction.
        /// </summary>
        public decimal ClosePrice
        {
            get { return closePrice; }
            set 
            { 
                closePrice = value;
                openCloseSpread = CalculateOpenCloseSpread();
            }
        }

        /// <summary>
        /// HighPrice is the highest price for this trade or transaction.
        /// </summary>
        public decimal HighPrice
        {
            get { return highPrice; }
            set
            {
                highPrice = value;
                highLowSpread = CalculateHighLowSpread();
            }
        }

        /// <summary>
        /// LowPrice is the lowest price for this trade or transaction
        /// </summary>
        public decimal LowPrice
        {
            get { return lowPrice; }
            set
            {
                lowPrice = value;
                highLowSpread = CalculateHighLowSpread();
            }
        }

        /// <summary>
        /// Units is the number of financial units in this trade or transaction.
        /// </summary>
        public int Units
        {
            get { return units; }
            set { units = value; }
        }

        /// <summary>
        /// Spread is the difference between the close and open prices.
        /// </summary>
        public decimal OpenCloseSpread
        {
            get { return openCloseSpread; }
            // set is not valid here.
        }

        public decimal HighLowSpread
        {
            get { return highLowSpread; }
            // set is not valid here.
        }

        /// <summary>
        /// CalculateOpenCloseSpread calculates the spread between the opening and closing prices.
        /// </summary>
        /// <returns>The spread.</returns>
        protected decimal CalculateOpenCloseSpread()
        {
            decimal newSpreadValue = 0m;
            newSpreadValue = closePrice - openPrice;
            return newSpreadValue;
        }

        /// <summary>
        /// CalculateHighLowSpread calculates the spread between the highest and lowest prices.
        /// </summary>
        /// <returns>The spread.</returns>
        protected decimal CalculateHighLowSpread()
        {
            decimal newSpreadValue = 0m;
            newSpreadValue = highPrice - lowPrice;
            return newSpreadValue;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public EntityActivity()
        {

        }

       /// <summary>
       /// Populated EntityActivity with calculated Spread.
       /// </summary>
       /// <param name="ID">Identifier</param>
       /// <param name="TradeOccurred">TradeTimestamp</param>
       /// <param name="OpeningPrice">OpenPrice</param>
        /// <param name="ClosingPrice">ClosePrice</param>
        /// <param name="HighestPrice">HighPrice</param>
        /// <param name="LowestPrice">LowPrice</param>
       /// <param name="TradeUnits">Units</param>
        public EntityActivity(string ID, DateTime TradeOccurred, decimal OpeningPrice, decimal ClosingPrice,
            decimal HighestPrice, decimal LowestPrice, int TradeUnits)
        {
            identifier = ID;
            tradeTimestamp = TradeOccurred;
            openPrice = OpeningPrice;
            closePrice = ClosingPrice;
            highPrice = HighestPrice;
            lowPrice = LowestPrice;
            units = TradeUnits;
            openCloseSpread = CalculateOpenCloseSpread();
            highLowSpread = CalculateHighLowSpread();
        }
    }
}
