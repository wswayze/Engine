using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineClasses;
using EngineLogic;
using System.Configuration;

namespace EngineLogicUnitTests
{
    [TestClass]
    public class EngineLogicUnitTest2
    {
        [TestMethod]
        public void GetQueueMessageCountTest()
        {
            int numberOfExpectedRows = 2519; // hardcoded number of rows from database. Change when appropriate.
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            FrontEndLogic fel = new FrontEndLogic();
            EngineEnums.ValidQueues vq =  fel.GetValidQueuesType("SIRI");
            fel.PurgeQueue(vq);
            fel.LoadQueueWithEntityActivity(connStr, vq);
            ProcessLogic pl = new ProcessLogic();
            int queueRows = pl.GetQueueMessageCount(vq);
            fel.PurgeQueue(vq);
            Assert.AreEqual(queueRows, numberOfExpectedRows, "GetQueueMessageCount failed");
        }

        [TestMethod]
        public void  GetTrackingDataRowsForSymbolTest()
        {
            int numberOfExpectedRows = 2519; // hardcoded number of rows from database. Change when appropriate.
            string symbol = "SIRI";
            ProcessLogic pl = new ProcessLogic();
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            FrontEndLogic fel = new FrontEndLogic();
            EngineEnums.ValidQueues sym = fel.GetValidQueuesType(symbol);
            int dbNumberOfRows = pl.GetTrackingDataRowsForSymbol(connStr, sym);
            Assert.AreEqual(dbNumberOfRows, numberOfExpectedRows, "GetTrackingDataRowsForSymbol failed row count of " + numberOfExpectedRows.ToString());
        }

        [TestMethod]
        public void PutTransactionDataOnQueueTest()
        {
            ProcessLogic pl = new ProcessLogic();
            TransactionData td = new TransactionData();
            td.Symbol = "SIRI";
            td.Price = 18.875m;
            td.TradeTimestamp = DateTime.Now;
            td.Units = 100;

            Assert.IsTrue(pl.PutTransactionDataOnQueue(ref td,EngineEnums.ValidQueues.SIRI));
        }
    }
}
