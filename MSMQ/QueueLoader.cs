using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using EngineLogic;
using EngineClasses;


namespace MSMQ
{
    public partial class QueueLoader : Form
    {
        
        IEvents id1 = new EventClass1();

        public QueueLoader()
        {
            InitializeComponent();
            id1.event1 += new dele(ContinueButton1_Click);
        }

        /// <summary>
        /// Clicking the button for Load Queue reads the database and fills the queues for testing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSymbol.Text != "")
            {
                labelStatus.Text = "Load Starting";
                id1.FireEvent();
            }
            else
            {
                labelStatus.Text = "Needs a Symbol to Load Queue";
            }
        }

        private void ContinueButton1_Click()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            FrontEndLogic fel = new FrontEndLogic();
            EngineEnums.ValidQueues vq = fel.GetValidQueuesType(textBoxSymbol.Text.ToUpper());

            fel.LoadQueue(connStr, vq);
            labelStatus.Text = "Load Completed";

            ProcessLogic pl = new ProcessLogic();
            labelDatabaseRows.Text = pl.GetTrackingDataRowsForSymbol(connStr, vq).ToString() + " Database Rows";
            labelQueueRows.Text = pl.GetQueueMessageCount(vq).ToString() + " Queue Rows";
        }

        /// <summary>
        /// Clicking the putton for Purge clears out the identified queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPurge_Click(object sender, EventArgs e)
        {
            FrontEndLogic fel = new FrontEndLogic();
            EngineEnums.ValidQueues vq = fel.GetValidQueuesType(textBoxSymbol.Text.ToUpper());
            string queueName = fel.GetQueueName(vq);
            fel.PurgeQueue(vq);
            labelStatus.Text = "Queue Purge Completed";
        }

        private void buttonProcessOne_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Not Implemented Yet.";
        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public delegate void dele();
    public interface IEvents
    {
        event dele event1;
        void FireEvent();
    }

    public class EventClass1 : IEvents
    {
        public event dele event1;
        public void FireEvent()
        {
            event1();
        }
    }

}
