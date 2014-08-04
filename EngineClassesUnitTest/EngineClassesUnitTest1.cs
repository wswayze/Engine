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

            Assert.AreEqual(unit.Identifier, entityName, "EntityActivity Identifier is wrong.");
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

            unit.Identifier = entityName;
            Assert.AreEqual(unit.Identifier, entityName, "EntityActivity Identifier is wrong.");

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

            Assert.AreEqual(unit.Identifier, entityName, "EntityTransaction Identifier is wrong.");
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

            unit.Identifier = entityName;
            Assert.AreEqual(unit.Identifier, entityName, "EntityTransaction Identifier is wrong.");

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
    }
}
