using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineClasses;
using System.Diagnostics;

namespace EngineClassesUnitTest
{
    [TestClass]
    public class EngineClassesUnitTest1
    {
        /// <summary>
        /// This is the basic test of the EntityActivity class object.
        /// </summary>
        [TestMethod]
        public void EntityActivityTest1()
        {
            string entityName = "EAT";
            DateTime whenOccurred = DateTime.Now;
            decimal openPrice = 13.875m;
            decimal closePrice = 13.5m;
            decimal highPrice = 14.125m;
            decimal lowPrice = 13.25m;
            int tradeUnits = 100;
            decimal testSpread = closePrice - openPrice;
            decimal highSpread = highPrice - lowPrice;
           
            EntityActivity unit = new EntityActivity(entityName, whenOccurred, openPrice, closePrice, highPrice, lowPrice, tradeUnits);

            Assert.AreEqual(unit.Ticker, entityName, "EntityActivity Identifier is wrong.");
            Assert.AreEqual(unit.TradeTimestamp, whenOccurred, "EntityActivity TradeTimestamp is worng.");
            Assert.AreEqual(unit.OpenPrice, openPrice, "EntityActivity OpenPrice is wrong.");
            Assert.AreEqual(unit.ClosePrice, closePrice, "EntityActivity ClosePrice is wrong.");
            Assert.AreEqual(unit.HighPrice, highPrice, "EntityActivity HighPrice is wrong.");
            Assert.AreEqual(unit.LowPrice, lowPrice, "EntityActivity LowPrice is wrong.");
            Assert.AreEqual(unit.Units, tradeUnits, "EntityActivity Units is wrong");
            Assert.AreEqual(unit.OpenCloseSpread, testSpread, "EntityActivity OpenCloseSpread is wrong");
            Assert.AreEqual(unit.HighLowSpread, highSpread,"EntityActivity HighLowSpread is wrong.");
        }

        /// <summary>
        /// This tests the EntityActivity default constructor and get/set logic.
        /// </summary>
        [TestMethod]
        public void EntityActivityTest2()
        {
            string entityName = "EAT";
            DateTime whenOccurred = DateTime.Now;
            decimal openPrice = 13.875m;
            decimal closePrice = 13.5m;
            decimal highPrice = 14.125m;
            decimal lowPrice = 13.25m;
            int tradeUnits = 100;
            decimal testSpread = closePrice - openPrice;
            decimal highSpread = highPrice - lowPrice;

            EntityActivity unit = new EntityActivity();

            unit.Ticker = entityName;
            Assert.AreEqual(unit.Ticker, entityName, "EntityActivity Identifier is wrong.");

            unit.TradeTimestamp = whenOccurred;
            Assert.AreEqual(unit.TradeTimestamp, whenOccurred, "EntityActivity TradeTimestamp is worng.");

            unit.OpenPrice = openPrice;
            Assert.AreEqual(unit.OpenPrice, openPrice, "EntityActivity OpenPrice is wrong.");

            unit.HighPrice = highPrice;
            Assert.AreEqual(unit.HighPrice, highPrice, "EntityActivity HighPrice is wrong.");
            
            unit.ClosePrice = closePrice;
            Assert.AreEqual(unit.ClosePrice, closePrice, "EntityActivity ClosePrice is wrong.");
            
            unit.LowPrice = lowPrice;
            Assert.AreEqual(unit.LowPrice, lowPrice, "EntityActivity LowPrice is wrong.");

            unit.Units = tradeUnits;
            Assert.AreEqual(unit.Units, tradeUnits, "EntityActivity Units is wrong");

            Assert.AreEqual(unit.OpenCloseSpread, testSpread, "EntityActivity OpenCloseSpread is wrong");
            Assert.AreEqual(unit.HighLowSpread, highSpread, "EntityActivity HighLowSpread is wrong.");
        }

        /// <summary>
        /// EntityTransaction populated constructor test.
        /// </summary>
        [TestMethod]
        public void EntityTransactionTest1()
        {
            string entityName = "EAT";
            DateTime whenOccurred = DateTime.Now;
            decimal openPrice = 13.875m;
            decimal closePrice = 13.5m;
            int tradeUnits = 100;
            decimal testSpread = closePrice - openPrice;

            EntityTransaction unit = new EntityTransaction(entityName, whenOccurred, openPrice, closePrice, tradeUnits);

            Assert.AreEqual(unit.Ticker, entityName, "EntityTransaction Identifier is wrong.");
            Assert.AreEqual(unit.TradeTimestamp, whenOccurred, "EntityTransaction TradeTimestamp is worng.");
            Assert.AreEqual(unit.OpenPrice, openPrice, "EntityTransaction OpenPrice is wrong.");
            Assert.AreEqual(unit.ClosePrice, closePrice, "EntityTransaction ClosePrice is wrong.");
            Assert.AreEqual(unit.Units, tradeUnits, "EntityTransaction Units is wrong");
            Assert.AreEqual(unit.OpenCloseSpread, testSpread, "EntityTransaction OpenCloseSpread is wrong");
        }

        /// <summary>
        /// EntityTransaction base constructor test.
        /// </summary>
        [TestMethod]
        public void EntityTransactionTest2()
        {
            string entityName = "EAT";
            DateTime whenOccurred = DateTime.Now;
            decimal openPrice = 13.875m;
            decimal closePrice = 13.5m;
            int tradeUnits = 100;
            decimal testSpread = closePrice - openPrice;

            EntityTransaction unit = new EntityTransaction();

            unit.Ticker = entityName;
            Assert.AreEqual(unit.Ticker, entityName, "EntityTransaction Identifier is wrong.");

            unit.TradeTimestamp = whenOccurred;
            Assert.AreEqual(unit.TradeTimestamp, whenOccurred, "EntityTransaction TradeTimestamp is worng.");

            unit.OpenPrice = openPrice;
            Assert.AreEqual(unit.OpenPrice, openPrice, "EntityTransaction OpenPrice is wrong.");

            unit.ClosePrice = closePrice;
            Assert.AreEqual(unit.ClosePrice, closePrice, "EntityTransaction ClosePrice is wrong.");

            unit.Units = tradeUnits;
            Assert.AreEqual(unit.Units, tradeUnits, "EntityTransaction Units is wrong");

            Assert.AreEqual(unit.OpenCloseSpread, testSpread, "EntityTransaction OpenCloseSpread is wrong");
        }

        /// <summary>
        /// Candelstick test where close is greater than open.
        /// </summary>
        [TestMethod]
        public void CandelstickWhiteTest()
        {
            decimal openPrice = 20.000m;
            decimal closePrice = 25.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - closePrice;
            decimal lowerShadow = openPrice - lowPrice;

            Candlestick c = new Candlestick();
            c.OpenPrice = openPrice;
            c.ClosePrice = closePrice;
            c.HighPrice = highPrice;
            c.LowPrice = lowPrice;

            Assert.AreEqual(c.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.White, "Candelstick RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");

            Candlestick cc = new Candlestick(openPrice, closePrice, highPrice, lowPrice);

            Assert.AreEqual(cc.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.White, "Candelstick RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");
        }

        /// <summary>
        /// Candelstick test where close is less than open.
        /// </summary>
        [TestMethod]
        public void CandelstickBlackTest()
        {
            decimal openPrice = 25.000m;
            decimal closePrice = 20.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - openPrice;
            decimal lowerShadow = closePrice - lowPrice;

            Candlestick c = new Candlestick();
            c.OpenPrice = openPrice;
            c.ClosePrice = closePrice;
            c.HighPrice = highPrice;
            c.LowPrice = lowPrice;

            Assert.AreEqual(c.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.Black, "Candelstick RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");

            Candlestick cc = new Candlestick(openPrice, closePrice, highPrice, lowPrice);

            Assert.AreEqual(cc.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.Black, "Candelstick RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");
        }

        /// <summary>
        /// Candelstick test where close equals open.
        /// </summary>
        [TestMethod]
        public void CandelstickEqualTest()
        {
            decimal openPrice = 20.000m;
            decimal closePrice = 20.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - openPrice;
            decimal lowerShadow = closePrice - lowPrice;

            Candlestick c = new Candlestick();
            c.OpenPrice = openPrice;
            c.ClosePrice = closePrice;
            c.HighPrice = highPrice;
            c.LowPrice = lowPrice;

            Assert.AreEqual(c.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.Black, "Candelstick RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");

            Candlestick cc = new Candlestick(openPrice, closePrice, highPrice, lowPrice);

            Assert.AreEqual(cc.OpenPrice, openPrice, "Candelstick OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "Candelstick ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "Candelstick HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "Candelstick LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.Black, "Candelstick RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "Candelstick UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "Candelstick LowerShadow failed.");
        }

        [TestMethod]
        public void CandelstickMetricsWhiteTest()
        {
            decimal openPrice = 20.000m;
            decimal closePrice = 25.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - closePrice;
            decimal lowerShadow = openPrice - lowPrice;
            int volume = 100;
            decimal candleSpread = 15.000m;
            decimal realBodySpread = 5.0000m;
            decimal lowerShadowAsRealBody = lowerShadow / realBodySpread;
            decimal upperShadowAsRealBody = upperShadow / realBodySpread;
            decimal realBodyAsSpread = realBodySpread / candleSpread;
            decimal upperShaddowAsCandle = upperShadow / candleSpread;

            CandlestickMetrics c = new CandlestickMetrics(openPrice,closePrice,highPrice,lowPrice);
            c.Volume = volume;

            Assert.AreEqual(c.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.White, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(c.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(c.CandelSpread,candleSpread,"CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(c.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(c.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics UpperShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");

            CandlestickMetrics cc = new CandlestickMetrics(openPrice, closePrice, highPrice, lowPrice, volume);

            Assert.AreEqual(cc.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.White, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(cc.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(cc.CandelSpread, candleSpread, "CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(cc.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(cc.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics  UpperShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");
        }

        [TestMethod]
        public void CandelstickMetricsBlackTest()
        {
            decimal openPrice = 25.000m;
            decimal closePrice = 20.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - openPrice;
            decimal lowerShadow = closePrice - lowPrice;
            int volume = 100;
            decimal candleSpread = 15.000m;
            decimal realBodySpread = 5.0000m;
            decimal lowerShadowAsRealBody = lowerShadow / realBodySpread;
            decimal upperShadowAsRealBody = upperShadow / realBodySpread;
            decimal realBodyAsSpread = realBodySpread / candleSpread;
            decimal upperShaddowAsCandle = upperShadow / candleSpread;

            CandlestickMetrics c = new CandlestickMetrics(openPrice, closePrice, highPrice, lowPrice);
            c.Volume = volume;

            Assert.AreEqual(c.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.Black, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(c.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(c.CandelSpread, candleSpread, "CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(c.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(c.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics  UpperShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");

            CandlestickMetrics cc = new CandlestickMetrics(openPrice, closePrice, highPrice, lowPrice, volume);

            Assert.AreEqual(cc.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.Black, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(cc.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(cc.CandelSpread, candleSpread, "CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(cc.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(cc.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics  UpperShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");
        }

        [TestMethod]
        public void CandelstickMetricsEqualTest()
        {
            decimal openPrice = 20.000m;
            decimal closePrice = 20.000m;
            decimal highPrice = 30.000m;
            decimal lowPrice = 15.000m;
            decimal upperShadow = highPrice - openPrice;
            decimal lowerShadow = closePrice - lowPrice;
            int volume = 100;
            decimal candleSpread = 15.000m;
            decimal realBodySpread = 0.0000m;
            decimal lowerShadowAsRealBody = 0.0000m;
            decimal upperShadowAsRealBody = 0.0000m;
            decimal realBodyAsSpread = 0.0000m;
            decimal upperShaddowAsCandle = upperShadow / candleSpread;

            CandlestickMetrics c = new CandlestickMetrics(openPrice, closePrice, highPrice, lowPrice);
            c.Volume = volume;

            Assert.AreEqual(c.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(c.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(c.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(c.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(c.RealBody, RealBodyColor.Black, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(c.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(c.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(c.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(c.CandelSpread, candleSpread, "CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(c.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(c.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics  UpperShadowAsRealBody failed.");
            Assert.AreEqual(c.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");

            CandlestickMetrics cc = new CandlestickMetrics(openPrice, closePrice, highPrice, lowPrice, volume);

            Assert.AreEqual(cc.OpenPrice, openPrice, "CandelstickMetrics OpenPrice failed.");
            Assert.AreEqual(cc.ClosePrice, closePrice, "CandelstickMetrics ClosePrice failed.");
            Assert.AreEqual(cc.HighPrice, highPrice, "CandelstickMetrics HighPrice failed.");
            Assert.AreEqual(cc.LowPrice, lowPrice, "CandelstickMetrics LowPrice failed.");
            Assert.AreEqual(cc.RealBody, RealBodyColor.Black, "CandelstickMetrics RealBody failed.");
            Assert.AreEqual(cc.UpperShadow, upperShadow, "CandelstickMetrics UpperShadow failed.");
            Assert.AreEqual(cc.LowerShadow, lowerShadow, "CandelstickMetrics LowerShadow failed.");
            Assert.AreEqual(cc.Volume, volume, "CandelstickMetrics Volume failed.");
            Assert.AreEqual(cc.CandelSpread, candleSpread, "CandelstickMetrics CandelSpread failed.");
            Assert.AreEqual(cc.RealBodySpread, realBodySpread, "CandelstickMetrics ReadBodySpread failed.");
            Assert.AreEqual(cc.LowerShadowRealBodyPercentage, lowerShadowAsRealBody, "CandelstickMetrics LowerShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowRealBodyPercentage, upperShadowAsRealBody, "CandelstickMetrics  UpperShadowAsRealBody failed.");
            Assert.AreEqual(cc.UpperShadowCandlePercentage, upperShaddowAsCandle, "CandelstickMetrics UpperShadowAsCandle failed.");
        }

        [TestMethod]
        public void CandlestickPatternTestConstructor()
        {
            Patterns pat = Patterns.Unassigned;
            PatternCategories cat = PatternCategories.Unassigned;
            Trends marketTrend = Trends.Unassigned;
            decimal openPrice = 100.00m;
            decimal closePrice = 200.00m;
            decimal highPrice = 300.00m;
            decimal lowPrice = 50.00m;
            int units = 1000;

            CandlestickPattern cpDefault = new CandlestickPattern();
            Assert.AreEqual(cpDefault.MarketTrend, marketTrend, "CandlestickPattern default constructor failed.");
            Assert.AreEqual(cpDefault.Pattern, pat, "CandlestickPattern default constructor failed.");

            CandlestickPattern cpCandlestick = new CandlestickPattern(openPrice,closePrice,highPrice,lowPrice);
            Assert.AreEqual(cpCandlestick.OpenPrice, openPrice, "CandlestickPattern Candlestick constructor failed.");
            Assert.AreEqual(cpCandlestick.ClosePrice, closePrice, "CandlestickPattern Candlestick constructor failed.");
            Assert.AreEqual(cpCandlestick.HighPrice, highPrice, "CandlestickPattern Candlestick constructor failed.");
            Assert.AreEqual(cpCandlestick.LowPrice, lowPrice, "CandlestickPattern Candlestick constructor failed.");

            marketTrend = Trends.Bull;
            CandlestickPattern cpTrend = new CandlestickPattern(openPrice, closePrice, highPrice, lowPrice, marketTrend);
            Assert.AreEqual(cpTrend.OpenPrice, openPrice, "CandlestickPattern Candlestick with Trend constructor failed.");
            Assert.AreEqual(cpTrend.ClosePrice, closePrice, "CandlestickPattern Candlestick with Trend constructor failed.");
            Assert.AreEqual(cpTrend.HighPrice, highPrice, "CandlestickPattern Candlestick with Trend constructor failed.");
            Assert.AreEqual(cpTrend.LowPrice, lowPrice, "CandlestickPattern Candlestick with Trend constructor failed.");
            Assert.AreEqual(cpTrend.MarketTrend, marketTrend, "CandlestickPattern Candlestick with Trend constructor failed.");

            pat = Patterns.Hammer;
            cat = PatternCategories.Reversal;
            CandlestickPattern cpTrendPat = new CandlestickPattern(openPrice, closePrice, highPrice, lowPrice, marketTrend);
            Assert.AreEqual(cpTrendPat.OpenPrice, openPrice, "CandlestickPattern Candlestick with Trend and Pattern constructor failed.");
            Assert.AreEqual(cpTrendPat.ClosePrice, closePrice, "CandlestickPattern Candlestick with Trend and Pattern constructor failed.");
            Assert.AreEqual(cpTrendPat.HighPrice, highPrice, "CandlestickPattern Candlestick with Trend and Pattern constructor failed.");
            Assert.AreEqual(cpTrendPat.LowPrice, lowPrice, "CandlestickPattern Candlestick with Trend and Pattern constructor failed.");
            Assert.AreEqual(cpTrendPat.MarketTrend, marketTrend, "CandlestickPattern Candlestick with Trend and Pattern constructor failed.");

            CandlestickPattern cpCandlestickVol = new CandlestickPattern(openPrice, closePrice, highPrice, lowPrice, units);
            Assert.AreEqual(cpCandlestickVol.OpenPrice, openPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVol.ClosePrice, closePrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVol.HighPrice, highPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVol.LowPrice, lowPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVol.Volume, units, "CandlestickPattern Candlestick Volume constructor failed.");

            CandlestickPattern cpCandlestickVolTrend = new CandlestickPattern(openPrice, closePrice, highPrice, lowPrice, units, marketTrend);
            Assert.AreEqual(cpCandlestickVolTrend.OpenPrice, openPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrend.ClosePrice, closePrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrend.HighPrice, highPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrend.LowPrice, lowPrice, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrend.Volume, units, "CandlestickPattern Candlestick Volume constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrend.MarketTrend, marketTrend, "CandlestickPattern Candlestick Volume constructor failed.");

            CandlestickPattern cpCandlestickVolTrendPat = new CandlestickPattern(openPrice, closePrice, highPrice, lowPrice, units, marketTrend, pat);
            Assert.AreEqual(cpCandlestickVolTrendPat.OpenPrice, openPrice, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.ClosePrice, closePrice, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.HighPrice, highPrice, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.LowPrice, lowPrice, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.Volume, units, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.MarketTrend, marketTrend, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.Pattern, pat, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
            Assert.AreEqual(cpCandlestickVolTrendPat.PatternCategory, cat, "CandlestickPattern Candlestick Volume Pattern constructor failed.");
        }

        [TestMethod]
        public void CandlestickPatternTestAttributes()
        {
            CandlestickPattern cp = new CandlestickPattern();
            Patterns pat = Patterns.Hammer;
            PatternCategories cat = PatternCategories.Reversal;
            Trends trend = Trends.Bear;

            cp.Pattern = pat;
            cp.MarketTrend = trend;

            Assert.AreEqual(cp.Pattern, pat, "CandlestickPatter Pattern failer.");
            Assert.AreEqual(cp.MarketTrend, trend, "CandlestickPatter MarketTrend failer.");
            Assert.AreEqual(cp.PatternCategory, cat, "CandlestickPatter PatternCategory failer.");
        }

        [TestMethod]
        public void GetPatternCategoryForPatternTest()
        {
            CandlestickPattern cp = new CandlestickPattern();
            Patterns pat = Patterns.Hammer;
            PatternCategories cat = cp.GetPatternCategoryForPattern(pat);
            Assert.AreEqual(cat, PatternCategories.Reversal, "GetPatternCategoryForPattern Hammer failed.");
            pat = Patterns.HangingMan;
            cat = cp.GetPatternCategoryForPattern(pat);
            Assert.AreEqual(cat, PatternCategories.Reversal, "GetPatternCategoryForPattern HangingMan failed.");
            pat = Patterns.Unassigned;
            cat = cp.GetPatternCategoryForPattern(pat);
            Assert.AreEqual(cat, PatternCategories.Unassigned, "GetPatternCategoryForPattern Unassigned failed.");
        }

        [TestMethod]
        public void CandlestickHeaderTest()
        {
            string ticker = "MLER";
            DateTime periodStart = DateTime.Now;
            DateTime periodEnd = DateTime.Now;

            CandlestickHeader ch1 = new CandlestickHeader();
            ch1.Ticker = ticker;
            ch1.PeriodStart = periodStart;
            ch1.PeriodEnd = periodEnd;
            Assert.AreEqual(ch1.Ticker, ticker, "CandlestickHeader tickler failed.");
            Assert.AreEqual(ch1.PeriodStart, periodStart, "CandlestickHeader periodStartr failed.");
            Assert.AreEqual(ch1.PeriodEnd, periodEnd, "CandlestickHeader periodEnd failed.");

            CandlestickHeader ch2 = new CandlestickHeader(ticker);
            Assert.AreEqual(ch2.Ticker, ticker, "CandlestickHeader ticker constructor failed.");

            CandlestickHeader ch3 = new CandlestickHeader(periodStart,periodEnd);
            Assert.AreEqual(ch3.PeriodStart, periodStart, "CandlestickHeader period constructor failed.");
            Assert.AreEqual(ch3.PeriodEnd, periodEnd, "CandlestickHeader period constructor failed.");

            CandlestickHeader ch4 = new CandlestickHeader(ticker,periodStart, periodEnd);
            Assert.AreEqual(ch4.Ticker, ticker, "CandlestickHeader full constructor failed.");
            Assert.AreEqual(ch4.PeriodStart, periodStart, "CandlestickHeader full constructor failed.");
            Assert.AreEqual(ch4.PeriodEnd, periodEnd, "CandlestickHeader full constructor failed.");
        }

        [TestMethod]
        public void CandlestickPatternListTestSetHammer()
        {
            DateTime period = DateTime.Now;
            CandlestickHeader ch = new CandlestickHeader("MSFT", period, period.AddMinutes(5));
            CandlestickPatternList cpl = new CandlestickPatternList();
            decimal[] openPrice = new decimal[6]{160m,150m,140m,130m,120m,110m};
            decimal[] closePrice = new decimal[6]{150m,140m,130m,120m,110m,100m};
            decimal[] highPrice = new decimal[6]{161m,151m,141m,131m,121m,110.5m};
            decimal[] lowPrice = new decimal[6] { 120m, 110m, 100m, 90m, 80m, 70m };
            int units = 1000;
            Patterns pat = Patterns.Hammer;

            Candlestick c0 = new Candlestick(openPrice[0], closePrice[0], highPrice[0], lowPrice[0]);
            CandlestickMetrics c1 = new CandlestickMetrics(openPrice[1], closePrice[1], highPrice[1], lowPrice[1]);
            CandlestickPattern c2 = new CandlestickPattern(openPrice[2], closePrice[2], highPrice[2], lowPrice[2]);
            Candlestick c3 = new Candlestick(openPrice[3], closePrice[3], highPrice[3], lowPrice[3]);
            CandlestickMetrics c4 = new CandlestickMetrics(openPrice[4], closePrice[4], highPrice[4], lowPrice[4]);
            CandlestickPattern c5 = new CandlestickPattern(openPrice[5], closePrice[5], highPrice[5], lowPrice[5]);
            c0.Header = ch;
            c4.Volume = units;
            c5.Volume = units;

            cpl.Add(c0);
            cpl.Add(c1);
            cpl.Add(c2);
            cpl.Add(c3);
            cpl.Add(c4);
            cpl.Add(c5);

            Assert.AreEqual(c5.Pattern, pat, "CandlestickPatternList SetPattern Hammer failed.");
        }

        [TestMethod]
        public void CandlestickPatternListTestSetHangingMan()
        {
            DateTime period = DateTime.Now;
            CandlestickHeader ch = new CandlestickHeader("MSFT", period, period.AddMinutes(5));
            CandlestickPatternList cpl = new CandlestickPatternList();
            decimal[] openPrice = new decimal[6] { 100m, 110m, 120m, 130m, 140m, 150m };
            decimal[] closePrice = new decimal[6] { 110m, 120m, 130m, 140m, 150m, 160m };
            decimal[] highPrice = new decimal[6] { 111m, 121m, 131m, 141m, 151m, 160.5m };
            decimal[] lowPrice = new decimal[6] { 70m, 80m, 90m, 100m, 110m, 120m };
            int units = 1000;
            Patterns pat = Patterns.HangingMan;

            Candlestick c0 = new Candlestick(openPrice[0], closePrice[0], highPrice[0], lowPrice[0]);
            CandlestickMetrics c1 = new CandlestickMetrics(openPrice[1], closePrice[1], highPrice[1], lowPrice[1]);
            CandlestickPattern c2 = new CandlestickPattern(openPrice[2], closePrice[2], highPrice[2], lowPrice[2]);
            Candlestick c3 = new Candlestick(openPrice[3], closePrice[3], highPrice[3], lowPrice[3]);
            CandlestickMetrics c4 = new CandlestickMetrics(openPrice[4], closePrice[4], highPrice[4], lowPrice[4]);
            CandlestickPattern c5 = new CandlestickPattern(openPrice[5], closePrice[5], highPrice[5], lowPrice[5]);
            c0.Header = ch;
            c4.Volume = units;
            c5.Volume = units;

            cpl.Add(c0);
            cpl.Add(c1);
            cpl.Add(c2);
            cpl.Add(c3);
            cpl.Add(c4);
            cpl.Add(c5);

            Assert.AreEqual(c5.Pattern, pat, "CandlestickPatternList SetPattern HangingMan failed.");
        }

        [TestMethod]
        public void CandlestickTestLowerShadow()
        {
            decimal[] openPrice = new decimal[6] { 160m, 150m, 140m, 130m, 120m, 110m };
            decimal[] closePrice = new decimal[6] { 150m, 140m, 130m, 120m, 110m, 100m };
            decimal[] highPrice = new decimal[6] { 161m, 151m, 141m, 131m, 121m, 110.5m };
            decimal[] lowPrice = new decimal[6] { 120m, 110m, 100m, 90m, 80m, 70m };
            
            decimal lowerShadow = closePrice[0] - lowPrice[0];
            Candlestick c0 = new Candlestick(openPrice[0], closePrice[0], highPrice[0], lowPrice[0]);
            Assert.AreEqual(c0.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");

            lowerShadow = closePrice[1] - lowPrice[1];
            Candlestick c1 = new Candlestick(openPrice[1], closePrice[1], highPrice[1], lowPrice[1]);
            Assert.AreEqual(c1.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");

            lowerShadow = closePrice[2] - lowPrice[2];
            Candlestick c2 = new Candlestick(openPrice[2], closePrice[2], highPrice[2], lowPrice[2]);
            Assert.AreEqual(c2.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");

            lowerShadow = closePrice[3] - lowPrice[3];
            Candlestick c3 = new Candlestick(openPrice[3], closePrice[3], highPrice[3], lowPrice[3]);
            Assert.AreEqual(c3.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");

            lowerShadow = closePrice[4] - lowPrice[4];
            Candlestick c4 = new Candlestick(openPrice[4], closePrice[4], highPrice[4], lowPrice[4]);
            Assert.AreEqual(c4.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");

            lowerShadow = closePrice[5] - lowPrice[5];
            Candlestick c5 = new Candlestick(openPrice[5], closePrice[5], highPrice[5], lowPrice[5]);
            Assert.AreEqual(c5.LowerShadow, lowerShadow, "Candlestick LowerShadow failed.");
        }

        [TestMethod]
        public void CandlestickTestUpperShadow()
        {
            decimal[] openPrice = new decimal[6] { 100m, 110m, 120m, 130m, 140m, 150m };
            decimal[] closePrice = new decimal[6] { 110m, 120m, 130m, 140m, 150m, 160m };
            decimal[] highPrice = new decimal[6] { 111m, 121m, 131m, 141m, 151m, 160.5m };
            decimal[] lowPrice = new decimal[6] { 70m, 80m, 90m, 100m, 110m, 1200m };

            decimal upperShadow = highPrice[0] - closePrice[0];
            Candlestick c0 = new Candlestick(openPrice[0], closePrice[0], highPrice[0], lowPrice[0]);
            Assert.AreEqual(c0.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");

            upperShadow = highPrice[1] - closePrice[1];
            Candlestick c1 = new Candlestick(openPrice[1], closePrice[1], highPrice[1], lowPrice[1]);
            Assert.AreEqual(c1.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");

            upperShadow = highPrice[2] - closePrice[2];
            Candlestick c2 = new Candlestick(openPrice[2], closePrice[2], highPrice[2], lowPrice[2]);
            Assert.AreEqual(c2.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");

            upperShadow = highPrice[3] - closePrice[3];
            Candlestick c3 = new Candlestick(openPrice[3], closePrice[3], highPrice[3], lowPrice[3]);
            Assert.AreEqual(c3.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");

            upperShadow = highPrice[4] - closePrice[4];
            Candlestick c4 = new Candlestick(openPrice[4], closePrice[4], highPrice[4], lowPrice[4]);
            Assert.AreEqual(c4.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");

            upperShadow = highPrice[5] - closePrice[5];
            Candlestick c5 = new Candlestick(openPrice[5], closePrice[5], highPrice[5], lowPrice[5]);
            Assert.AreEqual(c5.UpperShadow, upperShadow, "Candlestick LowerShadow failed.");
        }
    }
}
