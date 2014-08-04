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
        public QueueLoader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the button for Load Queue reads the database and fills the queues for testing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            FrontEndLogic fel = new FrontEndLogic();
            EngineEnums.ValidQueues vq = fel.GetValidQueuesType(textBoxSymbol.Text.ToUpper());

            labelStatus.Text = "Load Starting";
            fel.LoadQueue(connStr, vq);
            labelStatus.Text = "Load Completed";
        }
    }
}
