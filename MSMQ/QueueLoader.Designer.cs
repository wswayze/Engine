namespace MSMQ
{
    partial class QueueLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.buttonLoadQueue = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonPurge = new System.Windows.Forms.Button();
            this.buttonProcessOne = new System.Windows.Forms.Button();
            this.labelDatabaseRows = new System.Windows.Forms.Label();
            this.labelQueueRows = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(23, 13);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(100, 20);
            this.textBoxSymbol.TabIndex = 0;
            this.textBoxSymbol.TextChanged += new System.EventHandler(this.textBoxSymbol_TextChanged);
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(20, 36);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(94, 13);
            this.labelSymbol.TabIndex = 1;
            this.labelSymbol.Text = "Symbol to Process";
            // 
            // buttonLoadQueue
            // 
            this.buttonLoadQueue.Location = new System.Drawing.Point(23, 227);
            this.buttonLoadQueue.Name = "buttonLoadQueue";
            this.buttonLoadQueue.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadQueue.TabIndex = 2;
            this.buttonLoadQueue.Text = "Load Queue";
            this.buttonLoadQueue.UseVisualStyleBackColor = true;
            this.buttonLoadQueue.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(23, 76);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(38, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Ready";
            // 
            // buttonPurge
            // 
            this.buttonPurge.Location = new System.Drawing.Point(138, 227);
            this.buttonPurge.Name = "buttonPurge";
            this.buttonPurge.Size = new System.Drawing.Size(75, 23);
            this.buttonPurge.TabIndex = 4;
            this.buttonPurge.Text = "Purge";
            this.buttonPurge.UseVisualStyleBackColor = true;
            this.buttonPurge.Click += new System.EventHandler(this.buttonPurge_Click);
            // 
            // buttonProcessOne
            // 
            this.buttonProcessOne.Location = new System.Drawing.Point(256, 227);
            this.buttonProcessOne.Name = "buttonProcessOne";
            this.buttonProcessOne.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessOne.TabIndex = 5;
            this.buttonProcessOne.Text = "Process One";
            this.buttonProcessOne.UseVisualStyleBackColor = true;
            this.buttonProcessOne.Click += new System.EventHandler(this.buttonProcessOne_Click);
            // 
            // labelDatabaseRows
            // 
            this.labelDatabaseRows.AutoSize = true;
            this.labelDatabaseRows.Location = new System.Drawing.Point(295, 75);
            this.labelDatabaseRows.Name = "labelDatabaseRows";
            this.labelDatabaseRows.Size = new System.Drawing.Size(83, 13);
            this.labelDatabaseRows.TabIndex = 6;
            this.labelDatabaseRows.Text = "Database Rows";
            // 
            // labelQueueRows
            // 
            this.labelQueueRows.AutoSize = true;
            this.labelQueueRows.Location = new System.Drawing.Point(298, 104);
            this.labelQueueRows.Name = "labelQueueRows";
            this.labelQueueRows.Size = new System.Drawing.Size(69, 13);
            this.labelQueueRows.TabIndex = 7;
            this.labelQueueRows.Text = "Queue Rows";
            // 
            // QueueLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 305);
            this.Controls.Add(this.labelQueueRows);
            this.Controls.Add(this.labelDatabaseRows);
            this.Controls.Add(this.buttonProcessOne);
            this.Controls.Add(this.buttonPurge);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonLoadQueue);
            this.Controls.Add(this.labelSymbol);
            this.Controls.Add(this.textBoxSymbol);
            this.Name = "QueueLoader";
            this.Text = "QueueLoader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Button buttonLoadQueue;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonPurge;
        private System.Windows.Forms.Button buttonProcessOne;
        private System.Windows.Forms.Label labelDatabaseRows;
        private System.Windows.Forms.Label labelQueueRows;
    }
}