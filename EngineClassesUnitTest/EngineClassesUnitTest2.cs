using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineClasses;

namespace EngineClassesUnitTest
{
    [TestClass]
    public class EngineClassesUnitTest2
    {
        /// <summary>
        /// CandlestickPatternListTestAddCandlestickPattern tests adding a CandlestickPattern
        /// to the list.
        /// </summary>
        [TestMethod]
        public void CandlestickPatternListTestAddCandlestickPattern()
        {
            CandlestickPattern cp = new CandlestickPattern(15.00m, 20.00m, 25.00m, 10.00m);
            int marketSampleSize = 5;
            int listSize = 20;
            CandlestickPatternList cpl = new CandlestickPatternList();
            cpl.Add(cp);
            CandlestickPattern cpAdded = cpl.GetLatestAdd();
            Assert.AreEqual(cpAdded.OpenPrice, cp.OpenPrice, "CandlestickPatternListTestAddCandlestickPattern OpenPrice failed.");
            Assert.AreEqual(cpAdded.ClosePrice, cp.ClosePrice, "CandlestickPatternListTestAddCandlestickPattern ClosePrice failed.");
            Assert.AreEqual(cpAdded.HighPrice, cp.HighPrice, "CandlestickPatternListTestAddCandlestickPattern HighPrice failed.");
            Assert.AreEqual(cpAdded.LowPrice, cp.LowPrice, "CandlestickPatternListTestAddCandlestickPattern LowPrice failed.");
            Assert.AreEqual(cpl.MarketDirectionSampleSize, marketSampleSize, "CandlestickPatternListTestAddCandlestickPattern MarketDirectionSampleSize failed.");
            Assert.AreEqual(cpl.ListSize, listSize, "CandlestickPatternListTestAddCandlestickPattern ListSize failed.");
        }

        /// <summary>
        /// CandlestickPatternListTestAddCandlestickMetrics tests adding a CandlestickMetrics
        /// to the list.
        /// </summary>
        [TestMethod]
        public void CandlestickPatternListTestAddCandlestickMetrics()
        {
            CandlestickMetrics cm = new CandlestickMetrics(15.00m, 20.00m, 25.00m, 10.00m);
            int marketSampleSize = 5;
            int listSize = 20;
            CandlestickPatternList cpl = new CandlestickPatternList();
            cpl.Add(cm);
            CandlestickPattern cpAdded = cpl.GetLatestAdd();
            Assert.AreEqual(cpAdded.OpenPrice, cm.OpenPrice, "CandlestickPatternListTestAddCandlestickPattern OpenPrice failed.");
            Assert.AreEqual(cpAdded.ClosePrice, cm.ClosePrice, "CandlestickPatternListTestAddCandlestickPattern ClosePrice failed.");
            Assert.AreEqual(cpAdded.HighPrice, cm.HighPrice, "CandlestickPatternListTestAddCandlestickPattern HighPrice failed.");
            Assert.AreEqual(cpAdded.LowPrice, cm.LowPrice, "CandlestickPatternListTestAddCandlestickPattern LowPrice failed.");
            Assert.AreEqual(cpl.MarketDirectionSampleSize, marketSampleSize, "CandlestickPatternListTestAddCandlestickPattern MarketDirectionSampleSize failed.");
            Assert.AreEqual(cpl.ListSize, listSize, "CandlestickPatternListTestAddCandlestickPattern ListSize failed.");
        }

        /// <summary>
        /// CandlestickPatternListTestAddCandlestick tests adding a Candlestick
        /// to the list.
        /// </summary>
        [TestMethod]
        public void CandlestickPatternListTestAddCandlestick()
        {
            Candlestick c = new Candlestick(15.00m, 20.00m, 25.00m, 10.00m);
            int marketSampleSize = 5;
            int listSize = 20;
            CandlestickPatternList cpl = new CandlestickPatternList();
            cpl.Add(c);
            CandlestickPattern cpAdded = cpl.GetLatestAdd();
            Assert.AreEqual(cpAdded.OpenPrice, c.OpenPrice, "CandlestickPatternListTestAddCandlestickPattern OpenPrice failed.");
            Assert.AreEqual(cpAdded.ClosePrice, c.ClosePrice, "CandlestickPatternListTestAddCandlestickPattern ClosePrice failed.");
            Assert.AreEqual(cpAdded.HighPrice, c.HighPrice, "CandlestickPatternListTestAddCandlestickPattern HighPrice failed.");
            Assert.AreEqual(cpAdded.LowPrice, c.LowPrice, "CandlestickPatternListTestAddCandlestickPattern LowPrice failed.");
            Assert.AreEqual(cpl.MarketDirectionSampleSize, marketSampleSize, "CandlestickPatternListTestAddCandlestickPattern MarketDirectionSampleSize failed.");
            Assert.AreEqual(cpl.ListSize, listSize, "CandlestickPatternListTestAddCandlestickPattern ListSize failed.");
        }

        [TestMethod]
        public void CandlestickPatternListTestMarketDirectionSampleSize()
        {
            int sampleSize = 10;
            CandlestickPatternList cpl = new CandlestickPatternList();
            cpl.MarketDirectionSampleSize = sampleSize;
            int processedSampleSize = cpl.MarketDirectionSampleSize;
            Assert.AreEqual(processedSampleSize, sampleSize, "CandlestickPatternList MarketDirectionSampleSize failed.");
        }

        [TestMethod]
        public void CandlestickPatternListTestListSize()
        {
            CandlestickPattern cp = new CandlestickPattern(15.00m, 20.00m, 25.00m, 10.00m);
            CandlestickPatternList cpl = new CandlestickPatternList();
            int defaultListSize = cpl.ListSize;
            int newListSize = 5;

            // Load default number of elements.
            for (int i = 0; i < defaultListSize; i++)
            {
                cp.OpenPrice = cp.OpenPrice + 1.00m; // Change some data so you can see a change if necessary in debug.
                cpl.Add(cp);
            }
            int listCount = cpl.Count();
            Assert.AreEqual(listCount, defaultListSize, "CandlestickPattern Add to ListSize failed.");

            cpl.ListSize = newListSize;
            listCount = cpl.Count();
            Assert.AreEqual(listCount, newListSize, "CandlestickPattern set ListSize failed.");
        }

        [TestMethod]
        public void CandlestickPatternListTestDetermineMarketTrendBull()
        {
            CandlestickPattern cp = new CandlestickPattern(115.00m, 120.00m, 125.00m, 110.00m);
            CandlestickPatternList cpl = new CandlestickPatternList();
            int defaultListSize = cpl.ListSize;

            // Load default number of elements.
            for (int i = 0; i < defaultListSize; i++)
            {
                cp.OpenPrice = cp.OpenPrice + 1.00m; // Change some data so you can see a change if necessary in debug.
                cp.ClosePrice = cp.ClosePrice + 1.00m;
                cpl.Add(cp);
            }
            Trends bull = cpl.DetermineMarketTrend();
            Assert.AreEqual(bull, Trends.Bull, "CandlestickPatternList DetermineMarketTrend Bull market failure.");
        }

        [TestMethod]
        public void CandlestickPatternListTestDetermineMarketTrendBear()
        {
            CandlestickPattern cp = new CandlestickPattern(115.00m, 110.00m, 125.00m, 110.00m);
            CandlestickPatternList cpl = new CandlestickPatternList();
            int defaultListSize = cpl.ListSize;

            // Load default number of elements.
            for (int i = 0; i < defaultListSize; i++)
            {
                cp.OpenPrice = cp.OpenPrice - 1.00m; // Change some data so you can see a change if necessary in debug.
                cp.ClosePrice = cp.ClosePrice - 1.00m;
                cpl.Add(cp);
            }
            Trends bear = cpl.DetermineMarketTrend();
            Assert.AreEqual(bear, Trends.Bear, "CandlestickPatternList DetermineMarketTrend Bear market failure.");
        }
    }
}
