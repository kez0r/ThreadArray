namespace ThreadArray
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtNumThreads = new System.Windows.Forms.TextBox();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblOperations = new System.Windows.Forms.Label();
            this.txtOperations = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.threadTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumThreads
            // 
            this.txtNumThreads.Location = new System.Drawing.Point(12, 12);
            this.txtNumThreads.Name = "txtNumThreads";
            this.txtNumThreads.Size = new System.Drawing.Size(49, 22);
            this.txtNumThreads.TabIndex = 0;
            this.txtNumThreads.Text = "10";
            this.txtNumThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(67, 15);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(46, 13);
            this.lblThreads.TabIndex = 1;
            this.lblThreads.Text = "threads";
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Location = new System.Drawing.Point(174, 15);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(101, 13);
            this.lblOperations.TabIndex = 3;
            this.lblOperations.Text = "operations/thread";
            // 
            // txtOperations
            // 
            this.txtOperations.Location = new System.Drawing.Point(119, 12);
            this.txtOperations.Name = "txtOperations";
            this.txtOperations.Size = new System.Drawing.Size(49, 22);
            this.txtOperations.TabIndex = 2;
            this.txtOperations.Text = "50";
            this.txtOperations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // threadTimer
            // 
            this.threadTimer.Tick += new System.EventHandler(this.threadTimer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(171, 40);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.txtOperations);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.txtNumThreads);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "Thread Array Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumThreads;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.TextBox txtOperations;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer threadTimer;
        private System.Windows.Forms.Button btnStop;
    }
}

